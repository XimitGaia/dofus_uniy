import asyncio
from dataclasses import dataclass
from typing import Callable, Awaitable, Any

import meeseeks

from src.events.bank_open_event import BankOpenEvent
from src.events.base import BaseEvent
from src.events.figth_ended import FightEndedEvent
from src.events.figth_started import FightStartedEvent
from src.events.harvest_completed import HarvestCompletedEvent
from src.events.is_heavy import OverSizedEvent
from src.events.map_change import MapChangeEvent, Harverstable
from src.events.monster_location import MonsterLocationEvent
from src.events.turn_start_event import TurnStartEvent
from src.events.zaap_opened import ZaapOpenedEvent


@meeseeks.OnlyOne()
class State:
    _callbacks = {}
    _count: int = 0

    _map_id: int = None
    _harverstables: list[Harverstable] = []
    _is_on_fight: bool = None
    _is_zaap_open: bool = None
    _turn_starts: bool = None
    _go_bank: bool = None
    _is_bank_open: bool = None
    _monster_pos: list[tuple[int, int | None]] = []

    @property
    def count(self):
        return self._count

    @property
    def map_id(self):
        return self._map_id

    @property
    def is_on_fight(self):
        return self._is_on_fight

    @property
    def harverstables(self):
        return self._harverstables

    @property
    def is_zaap_open(self):
        return self._is_zaap_open

    @property
    def turn_starts(self):
        return self._turn_starts

    @property
    def go_bank(self):
        return self._go_bank

    @property
    def is_bank_open(self):
        return self._is_bank_open

    @property
    def monster_pos(self):
        return self._monster_pos

    async def setter(self, attr, value) -> None:
        self.__setattr__(attr, value)
        # print(attr, value)
        await self._execute_callbacks(attr)

    def watch(self, attribute: str, callback: Callable[[Any], Awaitable[bool]]) -> None:
        if attribute not in self._callbacks:
            self._callbacks.update({attribute: []})
        self._callbacks[attribute].append(callback)

    async def _execute_callbacks(self, attribute: str):
        self._count += 1
        results = await asyncio.gather(
            *[_callback() for _callback in self._callbacks.get(attribute, [])]
        )
        for i, v in enumerate(results):
            if v:
                self._callbacks[attribute].pop(i)

    def on_event(self, event: BaseEvent):
        _map = {
            MapChangeEvent: self.map_change_event,
            ZaapOpenedEvent: self.zaap_open,
            HarvestCompletedEvent: self.harvest_completed,
            FightStartedEvent: self.fight_started,
            FightEndedEvent: self.fight_ended,
            TurnStartEvent: self.turn_starts_event,
            MonsterLocationEvent: self.monster_location,
            OverSizedEvent: self.over_sized,
            BankOpenEvent: self.bank_open,
        }
        if callback := _map.get(event.__class__):
            asyncio.run(callback(event))

    async def map_change_event(self, event: MapChangeEvent):
        await self.setter("_map_id", event.map_id)
        await self.setter("_harverstables", event.harverstables)
        await self.setter("_monster_pos", [])

    async def zaap_open(self, event: ZaapOpenedEvent):
        await self.setter("_is_zaap_open", event.is_open)

    async def harvest_completed(self, event: HarvestCompletedEvent):
        _harverstables = [*self._harverstables]
        for i in range(len(_harverstables)):
            if _harverstables[i].element_id == event.element_id:
                _ref = _harverstables[i]
                _harverstables[i] = Harverstable(
                    cell_id=_ref.cell_id,
                    element_id=_ref.element_id,
                    element_type_id=_ref.element_type_id,
                    is_present=False,
                )
        await self.setter("_harverstables", _harverstables)

    async def fight_started(self, event: FightStartedEvent):
        await self.setter("_is_on_fight", event.has_started)

    async def fight_ended(self, event: FightEndedEvent):
        await self.setter("_is_on_fight", not event.fight_done)

    async def turn_starts_event(self, event: TurnStartEvent):
        await self.setter("_monster_pos", [])
        await self.setter("_turn_starts", not event.starts)

    async def monster_location(self, event: MonsterLocationEvent):
        _monster_pos = [*self._monster_pos]
        _changed = False
        for i in range(len(_monster_pos)):
            if _monster_pos[i][0] == event.character_id:
                _monster_pos[i] = (event.character_id, event.cell_id)
                _changed = True
        if _changed is False:
            _monster_pos.append((event.character_id, event.cell_id))
        await self.setter("_monster_pos", _monster_pos)

    async def over_sized(self, event: OverSizedEvent):
        await self.setter("_go_bank", event.go_bank)

    async def bank_open(self, event: BankOpenEvent):
        await self.setter("_is_bank_open", event.is_open)
