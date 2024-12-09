from dataclasses import dataclass
from typing import Self

from src.events.base import BaseEvent


@dataclass(slots=True, frozen=True)
class ZaapOpenedEvent(BaseEvent):
    is_open: bool
    map_destinations: list[int]

    @staticmethod
    def get_signature() -> bytes:
        return b"hfp"

    @classmethod
    def from_proto(cls, proto) -> Self:
        return cls(is_open=True, map_destinations=[i.mapId for i in proto.destinations])
