from src.actions.base import BaseAction
from src.model.state import State


class ChangeMapAction(BaseAction):
    max_retry = 3
    timeout = 10

    async def _wait(self):
        pass

    async def execute(self):
        _state = State()