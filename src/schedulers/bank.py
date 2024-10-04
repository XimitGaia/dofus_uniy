from src.actions.base import BaseAction
from src.interfaces.scheduler import IScheduler


class BankScheduler(IScheduler):


    def next(self) -> BaseAction:
        return BaseAction()
