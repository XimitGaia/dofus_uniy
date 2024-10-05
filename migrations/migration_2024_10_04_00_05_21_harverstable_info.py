import glob
import json
from pathlib import Path

from clandestino_interfaces import AbstractMigration
from clandestino_sqlite.infra import SQLiteInfra, config



def gen_harvestables(map_files_folder: Path, elements: Path, harvestables: Path):
    from src.model.map_data import HarverstableInfo

    _map_files = glob.glob(str(map_files_folder / "*"))
    with open(elements.resolve(), "r") as file:
        _elements = json.load(file)
    _elements_by_gfx = {}
    for i in _elements["references"]["RefIds"]:
        if "m_gfxId" not in i["data"]:
            continue
        _elements_by_gfx.update({i["data"]["m_gfxId"]: i["data"]})
    with open(harvestables.resolve(), "r") as file:
        _harvestables = json.load(file)

    for _map_file in _map_files:
        with open(_map_file, "r") as file:
            _map_json_file = json.load(file)
        _possibles_gfx_id = []
        if (
            "references" not in _map_json_file
            or "interactiveElements" not in _map_json_file
        ):
            continue

        interactive_elements = [
            i["rid"] for i in _map_json_file["interactiveElements"]["Array"]
        ]

        for _cell in _map_json_file["references"]["RefIds"]:
            if (
                _cell["rid"] in interactive_elements
                and str(_cell["data"]["gfxId"]) in _harvestables
                and _cell["data"]["cellId"] != 559
            ):
                _offset = _elements_by_gfx.get(
                    _cell["data"]["gfxId"],
                    {"m_origin": {"x": 0, "y": 0}, "m_size": {"x": 0, "y": 0}},
                )
                _offset_x = int(_offset["m_origin"]["x"] + _offset["m_size"]["x"] / 2)
                _offset_y = int(_offset["m_origin"]["y"] + _offset["m_size"]["y"] / 2)
                yield HarverstableInfo(
                    int(_map_json_file["m_Name"].split("_")[-1]),
                    _cell["data"]["cellId"],
                    _cell["data"]["gfxId"],
                    _cell["data"]["m_interactionId"],
                    _offset_x,
                    _offset_y,
                )


async def insert_data():
    from src.repository.bot import BotData

    buffer = []
    for _m in gen_harvestables(
        Path(config("MAPS_DIRECTORY_PATH")),
        Path(config("ELEMENTS_FILE_PATH")),
        Path(config("HARVESTABLES_FILE_PATH")),
    ):
        buffer.append(_m)
        if len(buffer) > 500:
            await BotData.save_harvestable_info(buffer)
            buffer = []
    if len(buffer) > 0:
        await BotData.save_harvestable_info(buffer)


class Migration(AbstractMigration):

    infra = SQLiteInfra()

    async def up(self) -> None:
        """Do modifications in database"""
        async with self.infra.get_cursor() as cursor:
            sql = f"""
                    CREATE TABLE IF NOT EXISTS HARVERTABLE_INFO (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        map_id INTEGER NOT NULL,
                        cell_id INTEGER NOT NULL,
                        gfx_id INTEGER NOT NULL,
                        interaction_id INTEGER NOT NULL,
                        offset_x INTEGER NOT NULL,
                        offset_y INTEGER NOT NULL
                    )
                """
            cursor.execute(sql)
            sql = f"""
                    CREATE INDEX gfx_id
                    ON HARVERTABLE_INFO(gfx_id)
                """
            cursor.execute(sql)
        await insert_data()

    async def down(self) -> None:
        """Undo modifications in database"""
        async with self.infra.get_cursor() as cursor:
            sql = f"""
                    DROP INDEX gfx_id
                """
            cursor.execute(sql)
            sql = f"""
                    DROP TABLE HARVERTABLE_INFO
                """
            cursor.execute(sql)

