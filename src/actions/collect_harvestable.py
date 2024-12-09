import asyncio

from pyautogui import moveTo

from src.actions.base import BaseAction
from src.model.state import State
from src.screen.screen import Screen


class CollectHarvestableAction(BaseAction):
    max_retry = 2
    timeout = 10

    def __init__(self, element_id, cell_id, offset_x, offset_y):
        self.element_id = element_id
        self.cell_id = cell_id
        self.offset_x = offset_x
        self.offset_y = offset_y
        self.lock = True

    async def _wait(self):
        while self.lock:
            await asyncio.sleep(0.1)

    async def callback(self) -> bool:
        if not self.lock:
            return True
        _state = State()
        for _h in _state.harverstables:
            if _h.element_id == self.element_id and _h.is_present is False:
                self.lock = False
                return True
        return False

    async def execute(self):
        _state = State()
        if list(
            filter(
                lambda x: x.element_id == self.element_id and x.is_present,
                _state.harverstables,
            )
        ):
            _x, _y = Screen().from_cell(
                cell_id=self.cell_id, offset_x=self.offset_x, offset_y=self.offset_y
            )
            _state.watch("_harverstables", self.callback)
            moveTo(x=_x, y=_y, duration=1.3)
            await self._wait()
