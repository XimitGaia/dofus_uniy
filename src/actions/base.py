import asyncio
from abc import abstractmethod, ABC
from dataclasses import dataclass

import pyautogui

from src.enums import ScheduleType
from src.model.state import State


@dataclass
class BaseAction(ABC):
    timeout: int
    max_retry: int

    # async def callback(self, value) -> bool:
    #     pass
    #
    # @abstractmethod
    # async def xxx(self):
    #     _state = State()
    #     _state.watch("map_id", self.callback)
    #     pyautogui.click(0,0)
    #     while self._t is False:
    #         await asyncio.sleep(0.5)


class ChangeSchedulerAction(BaseAction):
    pass
