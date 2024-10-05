from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class OverSizedEvent:
    is_open: bool
