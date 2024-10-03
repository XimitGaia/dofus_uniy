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
class Harverstable:
    cell_id: int
    element_id: int
    element_type_id: int
    is_present: bool
    # element_type_id: int
    # element_type_id: int

    def __str__(self):
        present = "✅" if self.is_present else "❌"
        return f"{present} eID: {self.element_id} etID: {self.element_type_id} cell: {self.cell_id}"


@dataclass(slots=True, frozen=True)
class MapData:
    map_id: int
    harverstables: list[Harverstable]

    def __str__(self):
        line_buffer = []
        line_buffer.append(f"MapID: {self.map_id}")
        for h in self.harverstables:
            line_buffer.append(h.__str__())
        return "\n".join(line_buffer)
