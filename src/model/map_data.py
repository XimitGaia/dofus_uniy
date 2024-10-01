from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class Harverstable:
    cell_id: int
    element_id: int
    element_type_id: int
    is_present: bool

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



