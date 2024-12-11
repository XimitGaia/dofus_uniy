from collections.abc import Callable
from io import BytesIO
from pathlib import Path
from queue import Queue
from socket import socket, AF_INET, SOCK_DGRAM
from typing import Type

from scapy.all import AsyncSniffer
from src.tcp_reader.reader import TCPReader, map_events


class Sniffer:

    def __init__(self, queue: Queue):
        self.filter: str = (
            f"tcp and dst host {self._get_network_ip()} and tcp port 5555"
        )
        self._sniffer = AsyncSniffer(filter=self.filter, prn=self._callback)
        self.queue: Queue = queue
        self.tcp_reader = TCPReader()
        self._counter = 0
        self._buffer = b""

    @staticmethod
    def _get_network_ip():
        _socket = socket(AF_INET, SOCK_DGRAM)
        try:
            _socket.connect(("8.8.8.8", 80))
            _ip = _socket.getsockname()[0]
        finally:
            _socket.close()
        return _ip

    def _callback(self, packet):
        _payload = bytes(packet["TCP"].payload)
        self._counter += 1
        # print(_payload)
        with open(
            Path(f"./src/tcp_reader/tcp_chunks/{self._counter}").resolve(), "wb"
        ) as file:
            file.write(_payload)
        self._buffer += _payload
        keep_buffer = False
        for event in map_events:
            if event.get_signature() not in self._buffer:
                continue
            try:
                print(self._counter, event)
                self.tcp_reader.process(self._buffer, event)
            except:
                self._buffer += _payload
                print("\n\n @error# \n\n")
                keep_buffer = True
        if keep_buffer is False:
            self._buffer = b""


    def start(self):
        self._sniffer.start()

    def stop(self):
        self._sniffer.stop()

    def join(self):
        self._sniffer.join()
