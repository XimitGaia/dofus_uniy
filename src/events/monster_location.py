from dataclasses import dataclass
from typing import Self

from src.events.base import BaseEvent


@dataclass(slots=True, frozen=True)
class MonsterLocationEvent(BaseEvent):
    character_id: int
    cell_id: int = None

    @staticmethod
    def get_signature() -> bytes:
        return b"igg"

    @classmethod
    def from_proto(cls, proto) -> Self:
        _path = [i for i in proto.cells]
        if proto.character_id == 0:
            raise ValueError()
        return cls(proto.character_id, _path[-1] if _path else None)
