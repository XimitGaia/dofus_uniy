import asyncio

import clandestino
from scapy.all import sniff

from src.tcp_reader.reader import TCPReader


def packet_callback(packet):
    try:
        _payload = bytes(packet["TCP"].payload)
        if b"MapComplementaryInformationEvent" in _payload:
            TCPReader(bytes(packet["TCP"].payload)).read()
        # elif b"TeleportDestinationsEvent" in _payload:
        #     print("q")
    except Exception as error:
        print(error)


if __name__ == "__main__":
    asyncio.run(clandestino.migrate_database())
    sniff(filter="tcp", prn=packet_callback)
