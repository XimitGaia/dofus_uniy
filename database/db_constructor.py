import glob
import json
from itertools import chain
from pathlib import Path
import re

from src.model.map_data import MapRegister, HarverstableInfo
from src.repository.bot import BotData


def gen_harvestables(map_files_folder: Path, elements: Path, harvestables: Path):
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
                    _offset["m_interactionId"]["x"],
                    _offset_x,
                    _offset_y,
                )


async def run2():
    buffer = []
    for _m in gen_harvestables(
        Path(r"C:\Users\imxim\Documents\dofus_core_data\maps"),
        Path("./elements.json"),
        Path("./harvestables_back.json"),
    ):
        buffer.append(_m)
        if len(buffer) > 500:
            await BotData.save_harvestable_info(buffer)
            buffer = []
    if len(buffer) > 0:
        await BotData.save_harvestable_info(buffer)


if __name__ == "__main__":
    import asyncio

    # asyncio.run(run1())
    asyncio.run(run2())
