from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class Harverstable:
    cell_id: int
    element_id: int
    element_type_id: int
    is_present: bool


@dataclass(slots=True, frozen=True)
class MapChangeEvent:
    map_id: int
    harverstables: list[Harverstable]
