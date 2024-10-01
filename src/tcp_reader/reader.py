from pathlib import Path
from uuid import uuid4

from protobufer import proto_test_pb2
import io

from src.model.map_data import MapData, Harverstable


class TCPReader:

    def __init__(self, payload: bytes):
        self._stream = io.BytesIO(payload)
        # D2O_file_binary = _BinaryStream(self._stream, True)
        # self._bin_file_binary = D2O_file_binary

    def save_snapshot(self, start: int = 0, size: int = None):
        self._stream.seek(start)
        with open(Path(f"./src/tcp_reader/tcp_chunks/{uuid4()}").resolve(), "wb") as file:
            file.write(self._stream.read(size))


    def read(self):
        # self.save_snapshot(107)
        self._stream.seek(107)
        map_event = proto_test_pb2.MapComplementaryInformationEvent()
        map_event.ParseFromString(self._stream.read())
        cell_map = {
            e.element_id: (e.cell_id, not bool(e.state))
            for e in map_event.stated_elements
        }
        _map = MapData(
            map_id=map_event.map_id,
            harverstables=[
                Harverstable(
                    cell_id=cell_map.get(i.element_id,(-1, False))[0],
                    is_present=cell_map.get(i.element_id,(-1, False))[1],
                    element_id=i.element_id,
                    element_type_id=i.element_type_id,
                )
                for i in map_event.interactive_elements
            ]
        )
        print(_map)