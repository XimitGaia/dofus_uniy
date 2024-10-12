from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class MapRegister:
    map_id_from: int
    map_id_to: int
    direction: int
    cell_id: int
    offset_x: float
    offset_y: float

    def as_tuple(self) -> tuple[int, int, int, int, float, float]:
        return (
            self.map_id_from,
            self.map_id_to,
            self.direction,
            self.cell_id,
            self.offset_x,
            self.offset_y,
        )


@dataclass(slots=True, frozen=True)
class Zaap:
    map_id: int
    name: str

    def as_tuple(self) -> tuple[int, str]:
        return (self.map_id, self.name)


@dataclass(slots=True, frozen=True)
class HarverstableInfo:
    map_id: int
    cell_id: int
    gfxId: int
    interaction_id: int
    offset_x: int
    offset_y: int

    def as_tuple(self) -> tuple[int, int, int, int, int, int]:
        return (
            self.map_id,
            self.cell_id,
            self.gfxId,
            self.interaction_id,
            self.offset_x,
            self.offset_y,
        )
