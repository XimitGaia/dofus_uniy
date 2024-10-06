from src.actions.base import BaseAction


class IScheduler:
    pass


class BankScheduler(IScheduler):

    def next(self) -> BaseAction:
        return BaseAction()
