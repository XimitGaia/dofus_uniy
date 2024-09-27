from src.tpc_reader._binarystream import _BinaryStream
import io


class TCPReader:

    def __init__(self, payload: bytes):
        self._stream = io.BytesIO(b)
        D2O_file_binary = _BinaryStream(self._stream, True)
        self._bin_file_binary = D2O_file_binary

    def read(self):
        pass