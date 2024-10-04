from dataclasses import dataclass


@dataclass(slots=True, frozen=True)
class BaseAction:
    action: callable
    callback: callable = None
