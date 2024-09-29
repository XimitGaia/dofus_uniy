from pathlib import Path
from uuid import uuid4

from protobufer import proto_test_pb2
import io


class TCPReader:

    def __init__(self, payload: bytes):
        self._stream = io.BytesIO(payload)
        # D2O_file_binary = _BinaryStream(self._stream, True)
        # self._bin_file_binary = D2O_file_binary

    def save_snapshot(self, start: int = 0, size: int = None):
        self._stream.seek(start)
        with open(Path(f"./src/tpc_reader/tcp_chunks/{uuid4()}").resolve(), "wb") as file:
            file.write(self._stream.read(size))


    def read(self):
        self.save_snapshot(107)
        self._stream.seek(107)
        map_event = proto_test_pb2.MapComplementaryInformationEvent()
        map_event.ParseFromString(self._stream.read())
        print(map_event.subareaId, map_event.mapId, map_event.hasAggressiveMonsters)