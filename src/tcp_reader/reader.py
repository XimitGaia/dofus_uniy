from pathlib import Path
from pprint import pprint
from typing import Type
from uuid import uuid4

from Cryptodome.Util.py3compat import BytesIO

from protobufer import proto_test_pb2
import io

from src.events.base import BaseEvent
from src.events.harvest_completed import HarvestCompletedEvent
from src.events.map_change import MapChangeEvent
from src.events.zaap_opened import ZaapOpenedEvent

map_events = {}


def retry(fn, count: int = 0, stop: int = 3):
    try:
        return fn()
    except Exception as e:
        if count < stop:
            return retry(fn, count + 1, stop)
        else:
            raise e


class TCPReader:
    _map = {}

    def __init__(self):
        map_events.update(
            {
                MapChangeEvent: self.map_change_event,
                ZaapOpenedEvent: self.zaap_open,
                HarvestCompletedEvent: self.harvest_completed,
            }
        )

    def process(self, payload: bytes, event: Type[BaseEvent]):
        _stream = io.BytesIO(payload)
        try:
            _event = retry(lambda: map_events[event](stream=_stream))
            print(_event)
        except Exception as error:
            with open(
                Path(f"./src/tcp_reader/tcp_chunks/{uuid4()}").resolve(), "wb"
            ) as file:
                file.write(payload)

    @staticmethod
    def map_change_event(stream: io.BytesIO):
        stream.seek(0)
        stream.seek(107)
        map_event = proto_test_pb2.MapComplementaryInformationEvent()
        map_event.ParseFromString(stream.read())
        return MapChangeEvent.from_proto(map_event)

    @staticmethod
    def zaap_open(stream: io.BytesIO):
        stream.seek(0)
        stream.seek(108)
        map_event = proto_test_pb2.TeleportDestinationsEvent()
        map_event.ParseFromString(stream.read())
        return ZaapOpenedEvent.from_proto(map_event)

    @staticmethod
    def harvest_completed(stream: io.BytesIO):
        stream.seek(0)
        stream.seek(107)
        map_event = proto_test_pb2.InteractiveUseEndedEvent()
        map_event.ParseFromString(stream.read())
        return HarvestCompletedEvent.from_proto(map_event)


if __name__ == "__main__":
    _data = b'\x8c\x04\x1a\x89\x04\n\x86\x04\n^type.ankama.com/com.ankama.dofus.server.game.protocol.gamemap.MapComplementaryInformationEvent\x12\xa3\x03\x08\xe2\x03\x10\x91\x86\x88*"\x86\x01\x08\x88\x87\xb4\xc1\xf0\t\x12\x02\x10T\x1ay\nG\x08\x9f\'\x1a\x0c\xa5\xaa\x84\x0e\xff\xb1\xe1\x1d\xa2\x81\xf4\x12"\x01U*1\x08\x02\x1a-\x08\x02\x12\x0b(\x93\x10\xb5 \xa1\x1c\x9f\x1c\xdc\x1b\x1a\x18\xf0\xe4\xb2\x0f\x80\x80\x80\x10\xc3\x85\xe0\x1f\x97\xc4\x83 \x8f\x96\x84/\xc2\xc9\x977"\x02\xa5\x01\x12.",\n\nWein-[Crc]\x12\x1e\n\x01\x0b\x1a\x02X\x01 \xbe\xb1\xef\x19*\x10\x08\x04 \xd0\x88\xb4\xc1\xf0\t(\xd0\x88\xb4\xc1\xf0\t""\x08\xde\xe3\xfe\xff\xff\xff\xff\xff\xff\x01\x12\x05\x10\x9a\x03\x18\x01\x1a\x0e\n\x05\x08%"\x01<\x12\x05:\x03\x08\xba7"#\x08\xdc\xe3\xfe\xff\xff\xff\xff\xff\xff\x01\x12\x05\x10\xb6\x03\x18\x07\x1a\x0f\n\x06\x08\x8e\x03"\x01F\x12\x05:\x03\x08\xc07""\x08\xdf\xe3\xfe\xff\xff\xff\xff\xff\xff\x01\x12\x05\x10\xb7\x03\x18\x01\x1a\x0e\n\x05\x08%"\x01<\x12\x05:\x03\x08\xba7" \x08\xe0\xe3\xfe\xff\xff\xff\xff\xff\xff\x01\x12\x05\x10\x9b\x03\x18\x03\x1a\x0c\n\x03\x08\xf2:\x12\x05:\x03\x08\x867*\x12\x08\xb0\xb7\x1e\x10C\x1a\x05\x08G\x10\xc4A(\x010\xc8\x01*\x11\x08\xb4\xae \x10\xbc\x02\x1a\x06\x08\xe8\x02\x10\xc6A(\x01*\x19\x08\x85\xae \x10\xff\xff\xff\xff\xff\xff\xff\xff\xff\x01\x1a\x06\x08\xb8\x01\x10\xc5A(\x01*\x11\x08\x8f\xa9\x1e\x10\xff\x01\x1a\x05\x08E\x10\xbd/0\xc8\x01*\x0e\x08\xb6\xa2\x1e\x10\xff\x01"\x05\x08E\x10\xb1A2\x08\x08\xb0\xb7\x1e\x10d \x012\x07\x08\x8f\xa9\x1e\x10\xa8\x022\t\x08\xb6\xa2\x1e\x10\xa6\x04\x18\x01'
    _a = BytesIO(_data)

    # with open(r"C:\Users\imxim\Documents\dofus_uniy\src\tcp_reader\tcp_chunks\final", "rb") as file:
    #     _a = BytesIO(file.read())

    _a.seek(107)
    map_event = proto_test_pb2.MapComplementaryInformationEvent()
    map_event.ParseFromString(_a.read())
    print(map_event)
    a = MapChangeEvent.from_proto(map_event)
    print(a)
