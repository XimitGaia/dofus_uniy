import asyncio
from abc import abstractmethod, ABC
from dataclasses import dataclass

import pyautogui

from src.enums import ScheduleType
from src.model.state import State




@dataclass
class BaseAction(ABC):
    # action: callable
    # callback: callable = None
    cell_id: int
    map_id: int
    timeout: int
    max_retry: int

    async def map_change(self, count: int ) -> bool:


        self._t = True
        return True

    @abstractmethod
    async def xxx(self):
        _state = State()
        _state.watch("map_id", self.map_change)
        pyautogui.click(0,0)
        while self._t is False:
            await asyncio.sleep(0.5)


class ChangeSchedulerAction(BaseAction):
    pass