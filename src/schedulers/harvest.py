from src.actions.base import BaseAction
from src.enums import ScheduleType


class HarvestScheduler:

    def __init__(self, zaaps: set, harvestables: set):
        self._zaaps = zaaps
        self._harvestables = harvestables

    def reset(self):
        pass

    def __next__(self) -> BaseAction:
        _state = State()
        _state
        return None
