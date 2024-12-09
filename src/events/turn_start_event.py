from dataclasses import dataclass
from typing import Self

from src.events.base import BaseEvent


@dataclass(slots=True, frozen=True)
class TurnStartEvent(BaseEvent):
    starts: bool

    @staticmethod
    def get_signature() -> bytes:
        return b"FightNewRoundEvent"

    @classmethod
    def from_proto(cls, _) -> Self:
        return cls(True)
