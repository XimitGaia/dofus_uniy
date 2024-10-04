import glob
import json
from itertools import chain
from pathlib import Path

from clandestino_interfaces import AbstractMigration

from clandestino_sqlite.infra import SQLiteInfra
from decouple import config



def gen_map(map_files_folder: Path, worldgraph: Path, elements: Path):
    from src.model.map_data import MapRegister

    _map_files = glob.glob(str(map_files_folder / "*"))
    with open(worldgraph.resolve(), "r") as file:
        _wgraph = json.load(file)
    with open(elements.resolve(), "r") as file:
        _elements = json.load(file)
    _maps_wrong_gfx = []
    _maps_wrong = []
    _maps_not_exists = []
    _count = 0
    _edges = _wgraph["m_Structure"]["m_edges"]
    for a in chain(i["m_values"] for i in _edges["m_values"]):
        for _x in a:
            # if _x["m_from"]["m_mapId"] != 162791424:
            #     continue
            for _y in _x["m_transitions"]:
                xxx = {
                    0: (0.08604543103448276, 0),  # right
                    2: (0, -0.016666666666666666),  # down
                    4: (-0.08604543103448276, 0),  # left
                    6: (0, 0.042709756097560975),  # up
                }
                offset_x, offset_y = xxx.get(_y["m_direction"], (0, 0))
                # if _y["m_direction"] == 255:
                #     _map_file_f = list(
                #         filter(
                #             lambda x: re.search(
                #                 r"\\map_" + f"{_x['m_from']['m_mapId']}", x
                #             ),
                #             _map_files,
                #         )
                #     )
                #     if len(_map_file_f) == 0:
                #         _maps_not_exists.append(_x['m_from']['m_mapId'])
                #         continue
                #     _map_file = _map_file_f[0]
                #     with open(_map_file, "r") as file:
                #         _map_json_file = json.load(file)
                #     _possibles_gfx_id = []
                #     for _cell in _map_json_file["references"]["RefIds"]:
                #         if _cell["data"].get("cellId") == _y["m_cellId"]:
                #             _possibles_gfx_id.append(_cell["data"]["gfxId"])
                #
                #     for _cell in _map_json_file["boundingBoxes"]["Array"]:
                #         if _cell.get("cellId") == _y["m_cellId"]:
                #             _possibles_gfx_id.append(_cell["gfxId"])
                #
                #     if len(_possibles_gfx_id) == 0:
                #         _maps_wrong_gfx.append((_y["m_cellId"], _x['m_from']['m_mapId']))
                #         continue

                yield MapRegister(
                    map_id_from=_x["m_from"]["m_mapId"],
                    map_id_to=_x["m_to"]["m_mapId"],
                    direction=_y["m_direction"],
                    cell_id=_y["m_cellId"],
                    offset_x=offset_x,
                    offset_y=offset_y,
                )
                _count += 1

    print(_maps_wrong)


async def insert_data():
    from src.repository.bot import BotData

    buffer = []
    for _m in gen_map(
        Path(config("MAPS_DIRECTORY_PATH")),
        Path(config("WORLD_GRAPH_FILE_PATH")),
        Path(config("ELEMENTS_FILE_PATH")),
    ):
        buffer.append(_m)
        if len(buffer) > 500:
            await BotData.save_maps(buffer)
            buffer = []
    if len(buffer) > 0:
        await BotData.save_maps(buffer)


class Migration(AbstractMigration):

    infra = SQLiteInfra()

    async def up(self) -> None:
        """Do modifications in database"""
        async with self.infra.get_cursor() as cursor:
            sql = f"""
                CREATE TABLE IF NOT EXISTS MAP_CATALOG (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    map_id_from INTEGER NOT NULL,
                    map_id_to INTEGER NOT NULL,
                    direction INTEGER NOT NULL,
                    cell_id INTEGER NOT NULL,
                    offset_x REAL NOT NULL,
                    offset_y REAL NOT NULL
                )
            """
            cursor.execute(sql)
            sql = f"""
                CREATE INDEX from_to
                ON MAP_CATALOG(map_id_from, map_id_to)
            """
            cursor.execute(sql)
        await insert_data()

    async def down(self) -> None:
        """Undo modifications in database"""
        async with self.infra.get_cursor() as cursor:
            sql = f"""
                DROP INDEX from_to
            """
            cursor.execute(sql)
            sql = f"""
                DROP TABLE MAP_CATALOG
            """
            cursor.execute(sql)
