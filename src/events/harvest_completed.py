from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class HarvestCompletedEvent:
    element_id: id
