import asyncio
from pathlib import Path
from pprint import pprint
from typing import Type
from uuid import uuid4

from Cryptodome.Util.py3compat import BytesIO

from protobufer import proto_test_pb2
import io

from src.events.bank_open_event import BankOpenEvent
from src.events.base import BaseEvent
from src.events.figth_ended import FightEndedEvent
from src.events.figth_started import FightStartedEvent
from src.events.harvest_completed import HarvestCompletedEvent
from src.events.is_heavy import OverSizedEvent
from src.events.map_change import MapChangeEvent
from src.events.monster_location import MonsterLocationEvent
from src.events.turn_start_event import TurnStartEvent
from src.events.zaap_opened import ZaapOpenedEvent
from src.model.exceptions import LostData
from src.model.state import State

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
                FightStartedEvent: self.fight_started,
                FightEndedEvent: self.fight_ended,
                TurnStartEvent: self.turn_starts,
                MonsterLocationEvent: self.monster_location,
                OverSizedEvent: self.over_sized,
                BankOpenEvent: self.bank_open,
            }
        )

    def process(self, payload: bytes, event: Type[BaseEvent]):
        _stream = io.BytesIO(payload)
        try:
            _event = retry(lambda: map_events[event](stream=_stream))
            State().on_event(_event)
        except LostData as error:
            raise error
        except Exception:
            _p = Path(f"./src/tcp_reader/tcp_chunks/{uuid4()}")
            print(_p)
            with open(
                _p.resolve(), "wb"
            ) as file:
                file.write(payload)

    @staticmethod
    def  map_change_event(stream: io.BytesIO):
        stream.seek(0)
        _content =  stream.read()
        stream.seek(0)
        _read_size = None
        _xxx = b"type.ankama.com/com.ankama.dofus.server.game.protocol.house.HousePropertiesEvent"
        if _xxx in _content:
            _read_size = len(_content.split(_xxx)[0]) - 117
        try:
            stream.seek(107)
            map_event = proto_test_pb2.MapComplementaryInformationEvent()
            map_event.ParseFromString(stream.read(_read_size))
            return MapChangeEvent.from_proto(map_event)
        except:
            raise LostData()

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

    @staticmethod
    def fight_started(stream: io.BytesIO):
        return FightStartedEvent(True)

    @staticmethod
    def fight_ended(stream: io.BytesIO):
        return FightEndedEvent(True)

    @staticmethod
    def turn_starts(stream: io.BytesIO):
        stream.seek(113)
        map_event = proto_test_pb2.FightNewRoundEvent()
        map_event.ParseFromString(stream.read())
        return TurnStartEvent.from_proto(map_event)

    @staticmethod
    def monster_location(stream: io.BytesIO):
        stream.seek(0)
        _bytes = stream.read().split(b'\x1a')
        # ;*
        _chunk_data = list(filter(lambda x: MonsterLocationEvent.get_signature() in x, _bytes))
        map_event = proto_test_pb2.MapMovementEvent()
        _pos = []
        for i in _chunk_data:
            stream = io.BytesIO(b'\x1a' + i)
            try:
                stream.seek(0)
                _size = len(stream.read())
                stream.seek(0)
                _stream = BytesIO(stream.read(_size - 1))
                _stream.seek(86)
                map_event.ParseFromString(_stream.read())
                _pos.append(MonsterLocationEvent.from_proto(map_event))
                continue
            except:
                pass

            try:
                stream.seek(86)
                map_event.ParseFromString(stream.read())
                _pos.append(MonsterLocationEvent.from_proto(map_event))
                continue
            except:
                pass

            try:
                stream.seek(90)
                map_event.ParseFromString(stream.read())
                _pos.append(MonsterLocationEvent.from_proto(map_event))
                continue
            except:
                pass

        return _pos[-1] if _pos else MonsterLocationEvent(0)

    @staticmethod
    def over_sized(stream: io.BytesIO):
        stream.seek(93)
        map_event = proto_test_pb2.InventoryWeightEvent()
        map_event.ParseFromString(stream.read())
        return OverSizedEvent.from_proto(map_event)

    @staticmethod
    def bank_open(stream: io.BytesIO):
        return BankOpenEvent(True)

if __name__ == "__main__":
    _data = b'lela\x12\x02\x08\x01\x18\xff\xff\xff\xff\xff\xff\xff\xff\xff\x012\x14\x08\x02\x12\x0e\x08\x02 \x8c\x87\xd0\xf0\x02(\x8c\x87\xd0\xf0\x02\x18\x0eX\x1aV\nT\nNtype.ankama.com/com.ankama.dofus.server.game.protocol.fight.FightNewRoundEvent\x12\x02\x08\x01d\x1ab\n`\nTtype.ankama.com/com.ankama.dofus.server.game.protocol.game.action.SequenceStartEvent\x12\x08\x08\x08\x10\x8a\x87\xd0\xf0\x02}\x1a{\ny\nVtype.ankama.com/com.ankama.dofus.server.game.protocol.game.action.GameActionFightEvent\x12\x1f\x08\xac\x02\x10\x8a\x87\xd0\xf0\x02\x82\x01\x13\x08\x8a\x87\xd0\xf0\x02\x10\xc8\x02(\x012\x06\x08\xc9\x91\x01\x10\x01\x90\x01\x1a\x8d\x01\n\x8a\x01\nVtype.ankama.com/com.ankama.dofus.server.game.protocol.game.action.GameActionFightEvent\x120\x08\xb6\x07\x10\x8a\x87\xd0\xf0\x02B%\n#\x08\x01\x10\x8a\x87\xd0\xf0\x02\x18\x98\xf8\xff\xff\xff\xff\xff\xff\xff\x01 \x02(\xc9\x91\x010\xf9\x94\x0fB\x04\x08\x01 bd\x1ab\n`\nRtype.ankama.com/com.ankama.dofus.server.game.protocol.game.action.SequenceEndEvent\x12\n\x08\x03\x10\x8a\x87\xd0\xf0\x02\x18\x08_\x1a]\n[\nQtype.ankama.com/com.ankama.dofus.server.game.protocol.fight.FightIsTurnReadyEvent\x12\x06\x08\x8a\x87\xd0\xf0\x02'
    _a = BytesIO(_data)

    # _a.seek(92)
    # print(_dat1)
    # print(_a.read())
    # _a.seek(92)
    # map_event = proto_test_pb2.MapMovementEvent()
    # map_event.ParseFromString(_a.read())
    # a = MonsterLocationEvent.from_proto(map_event)

    # with open(r"C:\Users\imxim\Documents\dofus_uniy\src\tcp_reader\tcp_chunks\dd1ff116-adcb-4c43-bdfb-d91889c6f63e", "rb") as file:
    #     _a = BytesIO(file.read())
    # print(_a.read())
    a = TCPReader.turn_starts(_a)
    print(a)
