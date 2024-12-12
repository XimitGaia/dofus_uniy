import asyncio
from abc import abstractmethod, ABC
from dataclasses import dataclass
from typing import Self

import pyautogui

from src.enums import ScheduleType
from src.model.state import State


@dataclass
class BaseAction(ABC):
    timeout: int
    max_retry: int
    lock: bool = False

    async def init_async(self) -> Self:
        return self

    async def callback(self) -> bool:
        pass

    async def _wait(self):
        while self.lock:
            await asyncio.sleep(0.1)

    async def execute(self):
        pass


class ChangeSchedulerAction(BaseAction):
    pass
