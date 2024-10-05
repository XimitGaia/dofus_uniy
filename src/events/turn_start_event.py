from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class TurnStartEvent:
    is_open: bool
