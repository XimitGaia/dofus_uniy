from src.actions.base import BaseAction


class CollectHarvestableAction(BaseAction):
    max_retry = 2
    timeout = 10

    async def _wait(self):
        pass

    async def execute(self):
        pass