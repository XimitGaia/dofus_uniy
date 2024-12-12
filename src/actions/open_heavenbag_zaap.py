import asyncio
import ctypes
from time import sleep

from pyautogui import click, moveTo, mouseDown, mouseUp

from src.actions.base import BaseAction
from src.model.state import State
from src.screen.screen import Screen


class OpenZaapAction(BaseAction):
    max_retry = 3
    timeout = 5

    def __init__(self):
        self.cell_id, self.offset_x, self.offset_y = 254, 0, 0

    async def callback(self) -> bool:
        if self.lock is False:
            return True
        _state = State()
        if _state.is_zaap_open:
            self.lock = False
            return True
        return False

    async def execute(self):
        _state = State()
        _x, _y = Screen().from_cell(cell_id=self.cell_id)
        _state.watch("is_zaap_open", self.callback)
        moveTo(_x, _y, duration=0.8)
        mouseDown()
        await asyncio.sleep(0.2)
        mouseUp()
        await self._wait()

