import asyncio
from dataclasses import dataclass
from typing import Callable, Awaitable, Any

import meeseeks


@meeseeks.OnlyOne()
class State:
    _callbacks = {}
    _count: int = 0
    _map_id: int = None
    _is_on_fight: bool = None

    @property
    def count(self):
        return self._count

    @property
    def map_id(self):
        return self._map_id

    @property
    def is_on_fight(self):
        return self._is_on_fight

    async def setter(self, attr, value) -> None:
        await self._execute_callbacks(attr)
        self._map_id = value

    def watch(self, attribute: str, callback: Callable[[Any], Awaitable[bool]]) -> None:
        if attribute not in self._callbacks:
            self._callbacks.update({attribute: []})
        self._callbacks[attribute].append(callback)

    async def _execute_callbacks(self, attribute: str):
        self._count += 1
        results = await asyncio.gather(
            *[
                _callback(self._count)
                for _callback in self._callbacks.get(attribute, [])
            ]
        )
        for i, v in enumerate(results):
            if v:
                self._callbacks[attribute].pop(i)
