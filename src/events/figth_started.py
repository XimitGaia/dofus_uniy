from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class FightStartedEvent:
    has_started: bool
