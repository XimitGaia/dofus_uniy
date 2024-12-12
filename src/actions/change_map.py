import asyncio
from typing import Self

from pyautogui import moveTo, mouseDown, mouseUp

from src.actions.base import BaseAction
from src.model.state import State
from src.repository.bot import BotData
from src.screen.screen import Screen


class ChangeMapAction(BaseAction):
    max_retry = 3
    timeout = 10

    def __init__(self, map_from, map_to):
        self.cell_id, self.offset_x, self.offset_y = None, None, None
        self.map_from, self.map_to = map_from, map_to

    async def init_async(self) -> Self:
        *_, self.cell_id, self.offset_x, self.offset_y = await BotData.find_connectors(
            map_id_from=self.map_from, map_id_to=self.map_to)
        return self

    async def callback(self) -> bool:
        if self.lock is False:
            return True
        _state = State()
        if _state.map_id == self.map_to:
            self.lock = False
            return True
        return False

    async def execute(self):
        await asyncio.sleep(1)
        _state = State()
        print(self.cell_id, self.offset_x, self.offset_y)
        _x, _y = Screen().from_cell(cell_id=self.cell_id, offset_x=self.offset_x, offset_y=self.offset_y)
        _state.watch("map_id", self.callback)
        moveTo(x=_x, y=_y, duration=0.8)
        mouseDown()
        await asyncio.sleep(0.2)
        mouseUp()
        await self._wait()

if __name__ == "__main__":
    _x, _y = Screen().from_cell(cell_id=279)
    moveTo(x=_x, y=_y, duration=0.8)
