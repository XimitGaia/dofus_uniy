from abc import abstractmethod
from dataclasses import dataclass
from typing import Self

from src.events.base import BaseEvent


@dataclass(slots=True, frozen=True)
class Harverstable:
    cell_id: int
    element_id: int
    element_type_id: int
    is_present: bool


@dataclass(slots=True, frozen=True)
class MapChangeEvent(BaseEvent):
    map_id: int
    harverstables: list[Harverstable]

    @staticmethod
    def get_signature() -> bytes:
        return b"MapComplementaryInformationEvent"

    @classmethod
    def from_proto(cls, proto) -> Self:
        cell_map = {
            e.element_id: (e.cell_id, not bool(e.state)) for e in proto.stated_elements
        }
        _h = []
        for i in proto.interactive_elements:
            _h.append(
                Harverstable(
                    cell_id=cell_map.get(i.element_id, (-1, False))[0],
                    is_present=cell_map.get(i.element_id, (-1, False))[1],
                    element_id=i.element_id,
                    element_type_id=i.element_type_id,
                )
            )
        return cls(map_id=proto.map_id, harverstables=_h)
