import asyncio

import pyautogui

from src.actions.base import BaseAction
from src.model.state import State
from src.repository.bot import BotData


class SearchAndSelectZaapAction(BaseAction):
    max_retry = 2
    timeout = 7

    def __init__(self, map_id):
        self.map_id = map_id

        _state = State()
        self.current_map_id = _state.map_id

        self.lock = True

    async def _wait(self):
        while self.lock:
            await asyncio.sleep(0.1)

    async def callback(self) -> bool:
        if self.lock == False:
            return True
        _state = State()
        if _state.map_id != self.current_map_id:
            self.lock = False
            return True
        return False

    async def execute(self):
        _state = State()
        _state.watch("map_id", self.callback)
        map_name = await BotData.get_zaap(self.map_id)
        pyautogui.typewrite(map_name)
        await self._wait()
