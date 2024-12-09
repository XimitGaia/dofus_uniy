from dataclasses import dataclass
from typing import Self

from src.events.base import BaseEvent


@dataclass(slots=True, frozen=True)
class OverSizedEvent(BaseEvent):
    go_bank: bool

    @staticmethod
    def get_signature() -> bytes:
        return b"InventoryWeightEvent"

    @classmethod
    def from_proto(cls, proto) -> Self:
        go_bank = (proto.inventoryWeight / proto.weightMax) > 0.95
        return cls(go_bank)
