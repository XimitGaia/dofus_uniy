import queue
import asyncio
from asyncio import CancelledError
from contextlib import asynccontextmanager
from queue import Queue

from src.actions.base import BaseAction, ChangeSchedulerAction
from src.enums import ScheduleType
from src.events.figth_ended import FightEndedEvent
from src.events.figth_started import FightStartedEvent
from src.events.harvest_completed import HarvestCompletedEvent
from src.events.is_heavy import OverSizedEvent
from src.events.map_change import MapChangeEvent
from src.events.monster_location import MonsterLocationEvent
from src.events.turn_start_event import TurnStartEvent
from src.events.zaap_opened import ZaapOpenedEvent
from src.model.state import State
from src.schedulers.bank import BankScheduler
from src.schedulers.fight import FightScheduler
from src.schedulers.harvest import HarvestScheduler


async def ccc(count: int) -> bool:
    return False


class Paparovisck:

    def __init__(self, queue: Queue, data: dict):
        self._running = True
        self.sniffer_queue = queue
        self.schedules = {
            ScheduleType.HARVEST: HarvestScheduler(**data),
            ScheduleType.FIGHT: FightScheduler(),
            ScheduleType.BANK: BankScheduler(),
        }
        self._next_schedule = None
        self._current_schedule = ScheduleType.HARVEST

        self._current_action: BaseAction = None
        self._running_task: asyncio.Task = None
        _state = State()
        _state.watch("is_on_fight", ccc)

    @property
    def current_schedule(self):
        return self._current_schedule

    @current_schedule.setter
    def current_schedule(self, value):
        if value == ScheduleType.HARVEST:
            self._next_schedule = None
        elif value == ScheduleType.BANK:
            self.schedules[ScheduleType.HARVEST].reset()
            self._next_schedule = ScheduleType.HARVEST
        elif value == ScheduleType.FIGHT:
            self._next_schedule = self._current_schedule
        self._current_schedule = value

    @property
    def schedule(self):
        return self.schedules[self._current_schedule]

    async def play(self):
        while True:
            self._current_action = next(self.schedule)
            if isinstance(self._current_action, ChangeSchedulerAction):
                self.current_schedule = self._next_schedule
            await self.execute_with_retry_and_timeout()

    async def execute_with_retry_and_timeout(self, current: int = 0):
        if current == self._current_action.max_retry:
            raise Exception("Tirulabys")
        try:
            async with asyncio.timeout(self._current_action.timeout):
                self._running_task = asyncio.Task(self._current_action.xxx())
                await self._running_task
        except TimeoutError:
            await self.execute_with_retry_and_timeout(current=current + 1)
        except CancelledError:
            pass

    async def _consume_queue(self):
        while self._running:
            event = self.sniffer_queue.get()
            if isinstance(event, MapChangeEvent):
                pass
            elif isinstance(event, ZaapOpenedEvent):
                pass
            elif isinstance(event, HarvestCompletedEvent):
                pass
            elif isinstance(event, FightStartedEvent):
                pass
            elif isinstance(event, FightEndedEvent):
                pass
            elif isinstance(event, OverSizedEvent):
                pass
            elif isinstance(event, MonsterLocationEvent):
                pass
            elif isinstance(event, TurnStartEvent):
                pass

    def _change_schedule(self, schedule: ScheduleType):
        self.current_schedule = schedule

    async def _execute_actions(self):
        while self._running:
            action: BaseAction = self.current_schedule.next()
            action.action()
