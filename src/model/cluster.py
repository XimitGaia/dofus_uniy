from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class Cluster:
    harvestables: dict
