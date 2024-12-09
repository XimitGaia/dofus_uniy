from src.actions.base import BaseAction


class OpenBankAction(BaseAction):
    max_retry = 3
    timeout = 7

    async def _wait(self):
        pass

    async def execute(self):
        pass
