from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class ZaapOpenedEvent:
    is_open: bool
