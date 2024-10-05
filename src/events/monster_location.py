from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class MonsterLocationEvent:
    is_open: bool
