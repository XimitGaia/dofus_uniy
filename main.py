import asyncio
import time

import clandestino
import numpy as np
import pyautogui
from PIL import ImageGrab
from scapy.all import sniff

from src.screen.teste import detect_movement
from src.tcp_reader.reader import TCPReader


img1 = None
def packet_callback(packet):
    global img1
    try:
        _payload = bytes(packet["TCP"].payload)
        if b"MapComplementaryInformationEvent" in _payload:
            # TCPReader(bytes(packet["TCP"].payload)).read()
            time.sleep(0.75)
            img1 = ImageGrab.grab()
            print("lala")
        elif b"TeleportDestinationsEvent" in _payload:
            time.sleep(2)
            img2 = ImageGrab.grab()
            detect_movement(np.array(img1), np.array(img2))
            print("q")
    except Exception as error:
        print(error)


if __name__ == "__main__":
    asyncio.run(clandestino.migrate_database())
    sniff(filter="tcp", prn=packet_callback)
