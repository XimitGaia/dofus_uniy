from dataclasses import dataclass
from typing import Self

from src.events.base import BaseEvent


@dataclass(slots=True, frozen=True)
class FightStartedEvent(BaseEvent):
    has_started: bool

    @staticmethod
    def get_signature() -> bytes:
        return b"FightFighterShowEvent"

    @classmethod
    def from_proto(cls, _) -> Self:
        return cls(True)
