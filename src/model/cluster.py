from dataclasses import dataclass
from typing import Self


@dataclass(slots=True, frozen=True)
class HarvestableCluster:
    locations: list[tuple]
    maps: set[int]
    quantities: dict
    score: float

    @classmethod
    def assign_score(cls, score: float) -> Self:
        return cls(
            locations=cls.locations,
            maps=cls.maps,
            quantities=cls.quantities,
            score=cls.score + score,
        )
