import json
import time
from dataclasses import dataclass

import pyautogui
from PIL import ImageGrab
from scapy.all import sniff

from src.tcp_reader.reader import TCPReader


def packet_callback(packet):
    try:
        _payload = bytes(packet["TCP"].payload)
        if b"MapComplementaryInformationEvent" in _payload:
            TCPReader(bytes(packet["TCP"].payload)).read()
    except Exception as error:
        print(error)


if __name__ == "__main__":
    sniff(filter="tcp", prn=packet_callback)
