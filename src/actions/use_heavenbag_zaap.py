from src.actions.base import BaseAction


class OpenZaapAction(BaseAction):
    max_retry = 3
    timeout = 5

    async def _wait(self):
        pass

    async def execute(self):
        pass