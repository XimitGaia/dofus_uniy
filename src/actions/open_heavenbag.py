import asyncio

from pyautogui import press

from src.actions.base import BaseAction
from src.model.state import State


class OpenHeavenBagAction(BaseAction):
    max_retry = 3
    timeout = 5
    locked = True

    def _gen_callback(self):
        _state = State()
        _count = _state.count

        async def callback(count) -> bool:
            if count != _count + 1:
                return False
            self.locked = False
            return True

        return callback


    async def execute(self):
        _state = State()
        _state.watch("map_id", self._gen_callback())
        press("h")
        while self.locked:
            await asyncio.sleep(0.5)

