import asyncio

from pyautogui import moveTo

from src.actions.base import BaseAction
from src.model.state import State
from src.repository.bot import BotData
from src.screen.screen import Screen


class ChangeMapAction(BaseAction):
    max_retry = 3
    timeout = 10

    def __init__(self, map_from, map_to):
        self.map_from, self.map_to, self.cell_id, self.offset_x, self.offset_y = BotData.find_connectors(
            map_id_from=map_from, map_id_to=map_to)
        self.lock = True

    async def _wait(self):
        while self.lock:
            await asyncio.sleep(0.1)

    async def callback(self, value) -> bool:
        _state = State()
        if _state.map_id == self.map_to:
            self.lock = False

    async def execute(self):
        _state = State()
        _x, _y = Screen().from_cell(cell_id=self.cell_id, offset_x=self.offset_x, offset_y=self.offset_y)
        _state.watch("map_id", self.callback)
        moveTo(x=_x, y=_y, duration=1.3)
        await self._wait()

