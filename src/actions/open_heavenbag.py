import asyncio
from time import sleep

from keyboard import press_and_release
from pyautogui import press, keyDown, keyUp

from src.actions.base import BaseAction
from src.model.state import State


class OpenHeavenBagAction(BaseAction):
    max_retry = 3
    timeout = 5


    async def callback(self) -> bool:
        if self.lock is False:
            return True
        _state = State()
        if _state.map_id in [162791424, 162793472]:
            self.lock = False
            return True
        return False


    async def execute(self):
        _state = State()
        _state.watch("map_id", self.callback)
        press_and_release("h")
        await self._wait()
