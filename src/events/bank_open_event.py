from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class BankOpenEvent:
    is_open: bool
