from src.actions.base import BaseAction


class FightMovementAction(BaseAction):
    max_retry = 2
    timeout = 5

    async def _wait(self):
        pass

    async def execute(self):
        pass
