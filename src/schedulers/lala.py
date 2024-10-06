# Autoloader
import sys
import os
from pathlib import Path
from typing import List

path = Path(__file__).resolve()
sys.path.append(str(path.parents[2]))
from database.sqlite import Database
import numpy as np
import copy
import random
import math

from src.goals.goal import Goal
from src.scheduler.actions.move_action import MoveAction
from src.scheduler.actions.harvest_action import HarvestAction
from src.scheduler.actions.battle_action import BattleAction
from src.scheduler.actions.check_pods_action import CheckPodsAction
from src.scheduler.actions.action_interface import ActionInterface
from src.state.state import State, Status
from src.character.battle_movements.play_alone import BattleMovementPlayAlone


class Resource(Goal):
    def __init__(
        self,
        database: Database,
        state: State,
        resources: list,
        accounts_name: List[str],
    ):
        self.state = state
        self.database = database
        self.accounts_name = accounts_name
        self.resources = [int(i) for i in resources]
        self.number_of_resources = len(self.resources)
        self.distance = 2
        self.index = 0
        self.cluster_list = list()
        self.routines = dict()
        self.battle_control = {"last_id": -1, "battles": {}}
        self.create_routines()

    def get_closest_map(self):
        pass

    def get_next_step(self, character_name: str) -> ActionInterface:
        cluster_index = self.routines[character_name]["cluster_index"]
        print(f"next_sep_cluster_index: {cluster_index}")
        print("pegando proximo passo")
        if self.state.get("characters_status").get(character_name) == Status.BATTLE:
            print(f"viu que tava no battle")
            self.routines[character_name]["action"] = "BATTLE"
            instructor = self.get_battle_instructor(character_name=character_name)
            return BattleAction(instructor=instructor)

        if self.routines[character_name]["action"] == "BATTLE":
            battle_id = self.get_player_battle_id(character_name=character_name)
            self.delete_battle(battle_id=battle_id)

        if self.routines[character_name]["harvest_counter"] > 10:
            print(f"Pegou {self.routines[character_name]['action']}")
            self.routines[character_name]["harvest_counter"] = 0
            return CheckPodsAction(goal_callback=self.change_cluster_index)

        if self.routines[character_name]["action"] == "MOVE":
            next_map = self.get_next_map(
                character_name=character_name, cluster_index=cluster_index
            )
            self.routines[character_name]["action"] = "HARVEST"
            return MoveAction(map_id=next_map)
        else:
            print(f"Pegou {self.routines[character_name]['action']}")
            self.routines[character_name]["harvest_counter"] += 1
            self.routines[character_name]["action"] = "MOVE"
            return HarvestAction(
                items=self.routines[character_name]["clusters"][cluster_index][
                    "resources"
                ]
            )

    def change_cluster_index(self, character_name):
        cluster_index = self.routines[character_name]["cluster_index"]
        print(f"cluster_index: {cluster_index}")
        total_clusters = len(self.routines[character_name]["clusters"])
        print(f"total_clusters {total_clusters}")
        if cluster_index < total_clusters - 1:
            print("entrei total clusters")
            self.routines[character_name]["cluster_index"] += 1
        else:
            self.routines[character_name]["cluster_index"] = 0
        print(f"changed cluster_index {self.routines[character_name]['cluster_index']}")

    def get_next_map(self, character_name, cluster_index):
        next_map = self.routines[character_name]["clusters"][cluster_index][
            "maps_id"
        ].pop(0)
        self.routines[character_name]["clusters"][cluster_index]["maps_id"].append(
            next_map
        )
        print(
            f'cluster rotation: {self.routines[character_name]["clusters"][cluster_index]["maps_id"]}'
        )
        return next_map

    def create_battle(self, players):
        battle_id = self.battle_control.get("last_id") + 1
        self.battle_control["last_id"] = battle_id
        self.battle_control["battles"][battle_id] = {
            "instructor": BattleMovementPlayAlone(),
            "players": players,
        }
        return battle_id

    def delete_battle(self, battle_id):
        self.battle_control["battles"][battle_id] = None
        del self.battle_control["battles"][battle_id]

    def get_player_battle_id(self, character_name):
        for battle_id in self.battle_control["battles"]:
            if character_name in self.battle_control["battles"][battle_id]["players"]:
                return battle_id
        return None

    def get_battle_instructor(self, character_name):
        battle_id = self.get_player_battle_id(character_name=character_name)
        if battle_id:
            return self.battle_control["battles"][battle_id]["instructor"]
        battle_id = self.create_battle(players=[character_name])
        return self.battle_control["battles"][battle_id]["instructor"]

    #  ::::::::  :::       :::    :::  :::::::: ::::::::::: :::::::::: :::::::::   ::::::::
    # :+:    :+: :+:       :+:    :+: :+:    :+:    :+:     :+:        :+:    :+: :+:    :+:
    # +:+        +:+       +:+    +:+ +:+           +:+     +:+        +:+    +:+ +:+
    # +#+        +#+       +#+    +:+ +#++:++#++    +#+     +#++:++#   +#++:++#:  +#++:++#++
    # +#+        +#+       +#+    +#+        +#+    +#+     +#+        +#+    +#+        +#+
    # #+#    #+# #+#       #+#    #+# #+#    #+#    #+#     #+#        #+#    #+# #+#    #+#
    #  ########  ########## ########   ########     ###     ########## ###    ###  ########

    def get_world_maps_by_harvestables(self):
        connections = self.database.get_world_map_with_harvestable_indication(
            self.resources
        )
        world_map_dict = dict()
        harvestables_map = list()
        for connection in connections:
            if world_map_dict.get(connection[0]) is None:
                world_map_dict[connection[0]] = {
                    "destinies": [connection[1]],
                    "harvestable_quantity": dict(),
                }
                if connection[3] is not None:
                    world_map_dict[connection[0]]["harvestable_quantity"].update(
                        {connection[3]: connection[2]}
                    )
                if connection[2] != 0:
                    harvestables_map.append(connection[0])
                continue
            if connection[1] not in world_map_dict[connection[0]]["destinies"]:
                world_map_dict[connection[0]]["destinies"].append(connection[1])
            if (
                connection[3] is not None
                and connection[3]
                not in world_map_dict[connection[0]]["harvestable_quantity"]
            ):
                world_map_dict[connection[0]]["harvestable_quantity"][connection[3]] = (
                    connection[2]
                )
        return world_map_dict, harvestables_map

    def clusterise(
        self,
        world_map_dict: dict,
        harvestables_map: list,
        map_id: int,
        current_distance: int = -1,
    ):
        if map_id in harvestables_map:
            harvestables_map.remove(map_id)
        map_metadata = world_map_dict.get(map_id)
        if map_metadata is None:
            return
        del world_map_dict[map_id]
        harvestable_quantity_metadata = map_metadata.get("harvestable_quantity")
        total = 0
        for harvestable_quantity in harvestable_quantity_metadata:
            if harvestable_quantity not in self.cluster_list[self.index]["quantities"]:
                self.cluster_list[self.index]["quantities"][harvestable_quantity] = 0
            self.cluster_list[self.index]["quantities"][
                harvestable_quantity
            ] += harvestable_quantity_metadata.get(harvestable_quantity)
            self.cluster_list[self.index]["quantities"][
                "total"
            ] += harvestable_quantity_metadata.get(harvestable_quantity)
            total += harvestable_quantity_metadata.get(harvestable_quantity)
        if total == 0:
            current_distance += 1
            if current_distance == self.distance:
                return
        else:
            self.cluster_list[self.index]["maps_id"].append(map_id)
        for destiny_map_id in map_metadata.get("destinies"):
            self.clusterise(
                world_map_dict=world_map_dict,
                harvestables_map=harvestables_map,
                map_id=destiny_map_id,
                current_distance=current_distance,
            )

    def get_clusters(self):
        world_map_dict, harvestables_map = self.get_world_maps_by_harvestables()
        while len(harvestables_map) > 0:
            self.cluster_list.append(
                {"quantities": {"total": 0}, "maps_id": list(), "score": 0}
            )
            map_id = harvestables_map.pop()
            self.clusterise(
                world_map_dict=world_map_dict,
                harvestables_map=harvestables_map,
                map_id=map_id,
            )
            self.index += 1

    def assing_score(self, criterion: callable, weight=1):
        score = len(self.cluster_list) + 1
        last_criterion_value = None
        for cluster in self.cluster_list:
            actual_criterion_value = criterion(cluster)
            if actual_criterion_value != last_criterion_value:
                score -= 1
            cluster["score"] += weight * score
            last_criterion_value = actual_criterion_value

    def gaussian(self, cluster):
        quantities = cluster["quantities"]
        middle = 1 / self.number_of_resources  # (len(quantities) - 1)
        exponent = sum(
            [
                (quantities[i] / quantities["total"] - middle) ** 2
                for i in quantities
                if i != "total"
            ]
        )
        return math.exp(-exponent)

    @staticmethod
    def get_cluster_total_resources(cluster):
        return cluster["quantities"]["total"]

    @staticmethod
    def get_cluster_density(cluster):
        return cluster["quantities"]["total"] / len(cluster["maps_id"])

    def rank_clusters(self):
        # quantity
        self.cluster_list = sorted(
            self.cluster_list,
            key=lambda u: self.get_cluster_total_resources(u),
            reverse=True,
        )
        self.assing_score(criterion=self.get_cluster_total_resources, weight=10)
        # density
        self.cluster_list = sorted(
            self.cluster_list, key=lambda u: self.get_cluster_density(u), reverse=True
        )
        self.assing_score(criterion=self.get_cluster_density, weight=5)
        # gaussian
        self.cluster_list = sorted(
            self.cluster_list, key=lambda u: self.gaussian(u), reverse=True
        )
        self.assing_score(criterion=self.gaussian)
        # sorting
        self.cluster_list = sorted(
            self.cluster_list, key=lambda u: u["score"], reverse=True
        )

    def get_cluster_list(self):
        self.get_clusters()
        self.rank_clusters()

    def select_best_clusters(
        self, clusters: list, already_contemplated_resources: list = list()
    ):
        remaining_resources = self.get_remaining_resources(
            resources=already_contemplated_resources
        )
        if len(remaining_resources) > 0:
            remaining_resource = remaining_resources.pop(0)
            cluster = self.get_first_cluster_with_giving_resource(
                resource_id=remaining_resource
            )
            clusters.append(cluster)
            already_contemplated_resources += self.get_cluster_resources(
                cluster=cluster
            )
            self.select_best_clusters(
                clusters=clusters,
                already_contemplated_resources=already_contemplated_resources,
            )

    def create_routines(self):
        self.get_cluster_list()
        clusters = list()
        self.select_best_clusters(clusters=clusters)
        while True:
            clusters_len = len(clusters)
            if clusters_len < len(self.accounts_name):
                if cluster := self.cluster_list.pop(0):
                    clusters.append(cluster)
            else:
                break
        self.distribute_all_clusters(clusters=clusters)
        print(self.routines)

    def distribute_all_clusters(self, clusters: list):
        for account in self.accounts_name:
            if self.routines.get(account) is None:
                self.routines.update(
                    {
                        account: {
                            "clusters": list(),
                            "cluster_index": 0,
                            "harvest_counter": 0,
                            "action": "MOVE",
                        }
                    }
                )
        direction = True
        while True:
            for account in self.accounts_name:
                if len(clusters) == 0:
                    break
                if direction:
                    cluster = clusters.pop(0)
                else:
                    cluster = clusters.pop(-1)
                cluster = self.normalise_cluster_for_use(cluster=cluster)
                cluster = self.sort_cluster_list(cluster)
                self.routines[account]["clusters"].append(cluster)
            if len(clusters) == 0:
                break
            direction = not direction

    def sort_cluster_list(self, cluster):
        cluster_maps = cluster.get("maps_id").copy()
        sorted_cluster_maps = [cluster_maps.pop(0)]
        while len(cluster_maps) > 0:
            map_id = self.get_closest_map(
                map_id=sorted_cluster_maps[-1], possible_maps=cluster_maps
            )
            # print(f"map_id: {sorted_cluster_maps[-1]}, closest_map: {map_id}, cluster: {cluster_maps}")
            cluster_maps.remove(map_id)
            sorted_cluster_maps.append(map_id)
        cluster["maps_id"] = sorted_cluster_maps
        return cluster

    def get_closest_map(self, map_id, possible_maps):
        processed = [map_id]
        neighborhoods = [[map_id]]
        while True:
            last_neighborhoods = neighborhoods[-1]
            next_neighborhoods = list(
                set(self.database.get_neighborhoods_by_map_id(last_neighborhoods))
                - set(processed)
            )
            intersection = list(set(next_neighborhoods) & set(possible_maps))
            if intersection:
                random.shuffle(intersection)
                print("Abrakadabrahh !!")
                return intersection[0]
            processed.extend(next_neighborhoods)
            neighborhoods.append(next_neighborhoods)

    @staticmethod
    def normalise_cluster_for_use(cluster: dict) -> dict:
        resources = list()
        for key in cluster.get("quantities").keys():
            if key != "total":
                resources.append(key)
        del cluster["score"]
        del cluster["quantities"]
        cluster.update({"resources": resources})
        return cluster

    def get_first_cluster_with_giving_resource(self, resource_id: int):
        index = 0
        to_return = None
        for cluster in self.cluster_list:
            if resource_id in cluster.get("quantities").keys():
                to_return = cluster
                break
            index += 1
        if to_return is not None:
            del self.cluster_list[index]
        return to_return

    def get_remaining_resources(self, resources: list):
        return list(set(self.resources) - set(resources))

    def get_cluster_resources(self, cluster: dict):
        return [i for i in cluster["quantities"].keys() if i != "total"]


if __name__ == "__main__":
    database = Database()
    resource = Resource(
        database=database,
        resources=[60, 59, 47, 48, 9],
        accounts_name=["lala", "lele", "lili", "lolo"],
    )
    resource.create_routines()
