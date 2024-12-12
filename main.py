import asyncio
from asyncio import Future

from clandestino import clandestino
from queue import Queue

from src.orchestrator.paparovsck import Paparovisck
from src.sniffer.sniffer import Sniffer


async def main():
    await clandestino.migrate_database()

    # h = {312,345}
    # z = {3123,123}
    #
    _queue = Queue()
    _sniffer = Sniffer(queue=_queue)
    _p = Paparovisck(queue=_queue, data={"zaaps": [84806401], "harvestables": [1]})
    _t = asyncio.Task(_p.play())
    _sniffer.start()
    await Future()


if __name__ == "__main__":
    asyncio.run(main())
