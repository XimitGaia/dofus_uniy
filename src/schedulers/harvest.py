import asyncio
import math

from src.actions.base import BaseAction
from src.actions.change_map import ChangeMapAction
from src.actions.collect_harvestable import CollectHarvestableAction
from src.actions.open_heavenbag import OpenHeavenBagAction
from src.actions.teleport_heavenbag_zaap import TeleportHeavenbagZaapAction
from src.actions.open_heavenbag_zaap import OpenZaapAction
from src.enums import ScheduleType
from src.model.state import State
from src.repository.bot import BotData


class HarvestScheduler:

    def __init__(self, harvestables: list, zaaps: set, cluster_max_distance: int):
        self._harvestables = harvestables
        self._zaaps = zaaps
        self._cluster_max_distance = cluster_max_distance
        self._current_schedule = None
        self._schedules = asyncio.run(self._create_schedules())

    def reset(self):
        if len(self._schedules) > 1:
            _schedule = self._schedules.pop(0)
            self._schedules.append(_schedule)
            self._current_schedule = self._schedules[0]

    def __next__(self) -> BaseAction:
        _state = State()
        _state
        return None

    async def _create_schedules(self) -> list[list[BaseAction]]:
        _clusters = await self._find_best_clusters()
        _schedules = []
        for cluster in _clusters:
            _schedules.append(await self._schedule_from_cluster(cluster=cluster))
        return []

    async def _schedule_from_cluster(self, cluster: dict):
        _schedule = {"access": [], "schedule": []}
        _access_path = await self._get_access_path(maps=cluster["maps"])
        _access_schedule = [OpenHeavenBagAction, OpenZaapAction, TeleportHeavenbagZaapAction] + [ChangeMapAction for i in _access_path[1:]]
        _schedule["access"] = _access_schedule
        _start_map = _access_path[-1]
        _deepest_path = await self._find_deepest_path(
            start_map=_start_map, maps=cluster["maps"]
        )
        _schedule["schedule"].append(CollectHarvestableAction)  # start_map

        for map in _deepest_path:
            _schedule["schedule"].append(ChangeMapAction)
            _schedule["schedule"].append(CollectHarvestableAction)

    async def _find_deepest_path(
        self,
        start_map: int,
        maps: set[int],
        path: list[int] = None,
        empty_ng_count: int = None,
    ):
        if path is None:
            path = []
        if empty_ng_count is None:
            empty_ng_count = 1
        _path = path.copy()
        _path.append(start_map)
        maps = maps - {
            start_map,
        }
        _neighborhoods = await BotData.get_out_neighborhoods(
            maps={
                start_map,
            },
            exclude=set(_path),
        )
        if _neighborhoods == set() or maps == set():
            if empty_ng_count > 1:
                return _path[:-empty_ng_count]
            return _path
        _valid_neighborhoods = _neighborhoods & maps
        if _valid_neighborhoods == set():
            empty_ng_count += 1
        if empty_ng_count > self._cluster_max_distance:
            return _path[: -self._cluster_max_distance]
        _tasks = list()
        for neighborhood in _valid_neighborhoods:
            _task = asyncio.create_task(
                self._find_deepest_path(
                    start_map=neighborhood,
                    maps=maps,
                    path=_path,
                    empty_ng_count=empty_ng_count,
                )
            )
            _tasks.append(_task)
        _paths = await asyncio.gather(*_tasks)
        return max(_paths, key=lambda x: len(x))

    async def _get_access_path(self, maps: set) -> list[int]:
        _dissembled_path = await self._create_dissembled_start_path(maps=maps)
        return await self._start_path_assembler(dissembled_path=_dissembled_path)

    async def _start_path_assembler(
        self, dissembled_path: list[set], path: list[int] = None
    ):
        _dissembled_path = dissembled_path
        _path = path
        if _path is None:
            _path = [_dissembled_path.pop().pop()]
        _neighborhoods = await BotData.get_in_neighborhoods(maps={_path[-1]})
        _valid_neighborhoods = _dissembled_path.pop() & _neighborhoods
        _path.append(_valid_neighborhoods.pop())
        if not _dissembled_path:
            return _path[::-1]
        return await self._start_path_assembler(
            dissembled_path=_dissembled_path, path=_path
        )

    async def _create_dissembled_start_path(
        self,
        maps: set[int],
        _layers: list[set[int]] = None,
        _processed: set[int] = None,
    ):
        if _layers is None:
            _layers = [
                self._zaaps,
            ]
            _processed = self._zaaps
        _neighborhoods = await BotData.get_out_neighborhoods(
            maps=_layers[-1], exclude=_processed
        )
        _processed = _processed.union(_neighborhoods)
        _closest_maps = maps & _neighborhoods
        if _closest_maps != set():
            _layers.append(_closest_maps)
            return _layers
        _layers.append(_neighborhoods)
        return await self._create_dissembled_start_path(
            maps=maps, _layers=_layers, _processed=_processed
        )

    async def _find_best_clusters(
        self, harvestables: list[int] = None, selections: list[dict] = None
    ):
        _selections = selections
        _harvestables = harvestables
        if _selections is None:
            _selections = list()
        if _harvestables is None:
            _harvestables = self._harvestables
        _harvest_data = await BotData.get_harvestable_quantity_by_id(
            gfx_ids=_harvestables
        )
        _maps = set([i[0] for i in _harvest_data])
        _clusters_maps = await self._get_clusters_maps(maps=_maps)
        _clusters = await self._set_clusters_metadata(
            cluster_maps=_clusters_maps, harvest_data=_harvest_data
        )
        _clusters = await self._rank_clusters(clusters=_clusters)
        _selections.append(max(_clusters, key=lambda w: w["score"]))
        _current_harvestables = self._get_clusters_harvestables_set(_selections)
        _remaining_harvestables = list(set(_harvestables) - set(_current_harvestables))
        if len(_remaining_harvestables) > 0:
            _selections = await self._find_best_clusters(
                harvestables=_remaining_harvestables, selections=_selections
            )
        return _selections

    @staticmethod
    def _get_clusters_harvestables_set(clusters: list[dict]) -> list:
        _harvestables = []
        for cluster in clusters:
            _harvestables.extend(cluster["quantities"].keys())
        return _harvestables

    async def _rank_clusters(self, clusters: list[dict]) -> list[dict]:
        clusters = self._rank_clusters_by_callback(
            clusters=clusters, callback=self._gaussian, weight=5
        )
        clusters = self._rank_clusters_by_callback(
            clusters=clusters, callback=self._density, weight=7
        )
        clusters = self._rank_clusters_by_callback(
            clusters=clusters, callback=self._total, weight=100
        )
        return clusters

    @staticmethod
    def _rank_clusters_by_callback(
        clusters: list[dict], callback: callable, weight: float = 1.0
    ) -> list[dict]:
        _max = 0
        _clusters_with_note = []
        _clusters = []
        for cluster in clusters:
            note = callback(cluster=cluster)
            if note > _max:
                _max = note
            _clusters_with_note.append((cluster, note))
        for cluster, note in _clusters_with_note:
            cluster["score"] += (note / _max) * weight
            _clusters.append(cluster)
        return _clusters

    @staticmethod
    def _gaussian(cluster: dict) -> float:
        _total = len(cluster["quantities"])
        middle = 1 / _total
        exponent = sum(
            [
                (cluster["quantities"][i] / _total - middle) ** 2
                for i in cluster["quantities"]
            ]
        )
        return math.exp(-exponent)

    @staticmethod
    def _density(cluster: dict) -> float:
        return sum(cluster["quantities"].values()) / len(cluster["maps"])

    @staticmethod
    def _total(cluster: dict) -> float:
        return sum(cluster["quantities"].values())

    @staticmethod
    async def _set_clusters_metadata(
        cluster_maps: list[set], harvest_data: list[tuple]
    ) -> list[dict]:
        _clusters = [
            {"data": [], "maps": maps, "quantities": {}, "score": 0}
            for maps in cluster_maps
        ]
        for harvestable in harvest_data:
            _map_id = harvestable[0]
            _gfx_id = harvestable[1]
            _index = 0
            for cluster in cluster_maps:
                if _map_id in cluster:
                    _clusters[_index]["data"].append(harvestable)
                    if _gfx_id not in _clusters[_index]["quantities"]:
                        _clusters[_index]["quantities"].update({_gfx_id: 0})
                    _clusters[_index]["quantities"][_gfx_id] += 1
                _index += 1
        return _clusters

    async def _get_clusters_maps(
        self, maps: set, _clusters_maps: list = None
    ) -> list[set]:
        _maps = maps
        if _clusters_maps is None:
            _clusters_maps: list[set] = []
        _next_map = _maps.pop()
        cluster, _maps = await self._clusterize_maps(start_map=_next_map, maps=_maps)
        _clusters_maps.append(cluster)
        if _maps:
            _clusters_maps = await self._get_clusters_maps(
                maps=_maps, _clusters_maps=_clusters_maps
            )
        return _clusters_maps

    async def _clusterize_maps(self, start_map: int, maps: set, _cluster: set = None):
        if _cluster is None:
            _cluster = {
                start_map,
            }
        _neighborhoods = await self._get_cluster_layer_neighborhoods(
            _neighborhoods=_cluster
        )
        _valid_neighborhoods = maps & _neighborhoods
        if _valid_neighborhoods:
            _cluster, maps = await self._clusterize_maps(
                start_map=start_map,
                maps=maps - _valid_neighborhoods,
                _cluster=_cluster.union(_valid_neighborhoods),
            )
        return _cluster, maps

    async def _get_cluster_layer_neighborhoods(self, _neighborhoods: set, deep=0):
        if _neighborhoods is None:
            _neighborhoods = set()
        if deep < self._cluster_max_distance:
            _last_neighborhoods = await BotData.get_out_neighborhoods(
                maps=_neighborhoods, exclude=_neighborhoods
            )
            _neighborhoods = await self._get_cluster_layer_neighborhoods(
                _neighborhoods=_neighborhoods.union(_last_neighborhoods), deep=deep + 1
            )
        return _neighborhoods


if __name__ == "__main__":
    h = HarvestScheduler(
        harvestables=[657, 664],
        cluster_max_distance=1,
        zaaps={
            88212481,
            68552706,
            88213271,
            185860609,
            88212746,
            88082704,
            68419587,
            88212481,
            197920772,
            191105026,
            212600323,
            212861955,
            156240386,
            165152263,
            14419207,
            126094107,
            84806401,
            147590153,
            164364304,
            142087694,
            202899464,
            100270593,
            108789760,
            54172969,
            54173001,
            73400320,
            156762120,
            173278210,
            20973313,
            154642,
            171967506,
            179831296,
            115083777,
            95422468,
            88085249,
            120062979,
            115737095,
            99615238,
            28050436,
            154010371,
        },
    )
