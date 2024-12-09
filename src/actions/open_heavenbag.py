import asyncio

from pyautogui import press

from src.actions.base import BaseAction
from src.model.state import State


class OpenHeavenBagAction(BaseAction):
    max_retry = 3
    timeout = 5

    def __init__(self):
        self.lock = True

    async def _wait(self):
        while self.lock:
            await asyncio.sleep(0.1)

    async def callback(self) -> bool:
        if self.lock == False:
            return True
        _state = State()
        if _state.map_id in [162791424, 162793472]:
            self.lock = False
            return True
        return False

    async def execute(self):
        _state = State()
        _state.watch("map_id", self.callback)
        press("h")
        await self._wait()
