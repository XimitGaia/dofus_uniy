from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class FightEndedEvent:
    fight_done: bool
