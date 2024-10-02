import glob
import json
from dataclasses import dataclass
from itertools import chain
from pathlib import Path
import re

from decouple import config


@dataclass(slots=True)
class MapRegister:
    map_id_from: int
    map_id_to: int
    direction: int
    cell_id: int
    offset_x: float
    offset_y: float


def gen_map(map_files_folder: Path, worldgraph: Path, elements: Path):
    _map_files = glob.glob(str(map_files_folder/"*"))
    with open(worldgraph.resolve(), "r") as file:
        _wgraph = json.load(file)
    with open(elements.resolve(), "r") as file:
        _elements = json.load(file)

    _edges = _wgraph["m_Structure"]["m_edges"]
    for a in chain(i["m_values"] for i in _edges["m_values"]):
        for _x in a:
            # if _x["m_from"]["m_mapId"] != 192416776:
            #     continue
            for _y in _x["m_transitions"]:
                offset_x = 0
                offset_y = 0
                if _y["m_direction"] == 255:
                    _map_file = list(
                        filter(
                            lambda x: re.search(
                                r"\\map_" + f"{_x['m_from']['m_mapId']}", x
                            ),
                            _map_files,
                        )
                    )[0]
                    with open(_map_file, "r") as file:
                        _map_json_file = json.load(file)
                    _gfx_id = 0
                    for _cell in _map_json_file["references"]["RefIds"]:
                        print(_cell["data"])
                        if _cell["data"].get("cellId") == _y["m_cellId"]:
                            _gfx_id = _cell["data"]["gfxId"]

                    for _cell in _map_json_file["boundingBoxes"]["Array"]:
                        if _cell.get("cellId") == _y["m_cellId"]:
                            _gfx_id = _cell["gfxId"]

                    _m_origin = None
                    _m_size = None

                    for _e in _elements["references"]["RefIds"]:
                        if _e["data"].get("m_gfxId") == _gfx_id:
                            _m_origin = _e["data"].get("m_origin")
                            _m_size = _e["data"].get("m_size")
                    mada_foca = 1024
                    offset_x = (_m_origin["x"]) / mada_foca
                    offset_y = (_m_origin["y"]) / mada_foca

                yield MapRegister(
                        map_id_from=_x["m_from"]["m_mapId"],
                        map_id_to=_x["m_to"]["m_mapId"],
                        direction=_y["m_direction"],
                        cell_id=_y["m_cellId"],
                        offset_x=-offset_x,
                        offset_y=-offset_y,
                    )



if __name__ == "__main__":
    for map in gen_map(Path(r"C:\Users\imxim\Documents\dofus_core_data\maps"), Path("./worldgraph.json"),Path("./elements.json")):
        print(map)