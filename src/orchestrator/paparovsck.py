import queue
from queue import Queue

from src.actions.base import BaseAction
from src.enums import ScheduleType
from src.schedulers.bank import BankScheduler
from src.schedulers.fight import FightScheduler
from src.schedulers.harvest import HarvestScheduler

class Paparovisck:

    def __init__(self, queue: Queue):
        self._running = True
        self.sniffer_queue = queue
        self.schedules = {
            ScheduleType.HARVEST: HarvestScheduler(),
            ScheduleType.FIGHT: FightScheduler(),
            ScheduleType.BANK: BankScheduler(),
        }
        self.current_schedule = ScheduleType.HARVEST
        self.state = {}

    async def _consume_queue(self):
        while self._running:
            event = self.sniffer_queue.get()

    def _change_schedule(self, schedule: ScheduleType):
        self.current_schedule = schedule

    async def _execute_actions(self):
        while self._running:
            action: BaseAction = self.current_schedule.next()
            action.action()

