import asyncio

from pyautogui import moveTo

from src.actions.base import BaseAction
from src.model.state import State
from src.screen.screen import Screen


class OpenZaapAction(BaseAction):
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
        if _state.is_zaap_open:
            self.lock = False
            return True
        return False

    async def execute(self):
        _state = State()
        if _state.map_id == 162791424:
            cell_id = 310
        else:
            cell_id = 310
        _x, _y = Screen().from_cell(cell_id=cell_id, offset_x=0, offset_y=0)
        _state.watch("is_zaap_open", self.callback)
        moveTo(x=_x, y=_y, duration=1.3)
        await self._wait()
