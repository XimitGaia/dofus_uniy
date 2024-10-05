from queue import Queue
from socket import socket, AF_INET, SOCK_DGRAM

from scapy.all import AsyncSniffer


class Sniffer:

    def __init__(self, queue: Queue):
        self.filter: str = f"tcp and dst host {self._get_network_ip()}"
        self._sniffer = AsyncSniffer(filter=self.filter, prn=self._callback)
        self.queue: Queue = queue

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
        if b'type.ankama' in _payload[:100]:
            self.queue.put(packet)

    def start(self):
        self._sniffer.start()

    def stop(self):
        self._sniffer.stop()

    def join(self):
        self._sniffer.join()