from dataclasses import dataclass
from typing import Self

from src.events.base import BaseEvent


@dataclass(slots=True, frozen=True)
class FightEndedEvent(BaseEvent):
    fight_done: bool

    @staticmethod
    def get_signature() -> bytes:
        return b"FightEndEvent"

    @classmethod
    def from_proto(cls, _) -> Self:
        return cls(True)
