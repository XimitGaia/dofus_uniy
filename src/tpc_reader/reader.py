import proto_test_pb2
from src.tpc_reader._binarystream import _BinaryStream
import io


class TCPReader:

    def __init__(self, payload: bytes):
        self._stream = io.BytesIO(payload)
        # D2O_file_binary = _BinaryStream(self._stream, True)
        # self._bin_file_binary = D2O_file_binary

    def read(self):
        self._stream.read(107)
        new_buffer =  io.BytesIO()
        while True:
            a = self._stream.read(1)
            if b'"' == a:
                break
            new_buffer.write(a)
        map_event = proto_test_pb2.MapComplementaryInformationEvent()
        new_buffer.seek(0)
        map_event.ParseFromString(new_buffer.read())
        print(map_event.subareaId, map_event.mapId)