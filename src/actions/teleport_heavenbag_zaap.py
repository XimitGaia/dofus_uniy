import asyncio

from keyboard import press_and_release, write
from pyautogui import typewrite, press

from src.actions.base import BaseAction
from src.model.state import State


class TeleportHeavenbagZaapAction(BaseAction):
    max_retry = 2
    timeout = 7

    def __init__(self, zaap_name, map_to):
        self.zaap_name = zaap_name
        self.map_to = map_to


    async def callback(self) -> bool:
        if self.lock is False:
            return True
        _state = State()
        if _state.map_id == self.map_to:
            self.lock = False
            return True
        return False


    async def execute(self):
        _state = State()
        _state.watch("map_id", self.callback)
        write(self.zaap_name, delay=0.1)
        await asyncio.sleep(0.1)
        press_and_release("enter")
        await self._wait()
