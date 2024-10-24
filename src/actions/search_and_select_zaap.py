from src.actions.base import BaseAction


class SearchAndSelectZaapAction(BaseAction):
    max_retry = 2
    timeout = 7

    async def _wait(self):
        pass

    async def execute(self):
        pass
