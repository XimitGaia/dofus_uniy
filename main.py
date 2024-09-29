from scapy.all import sniff

from src.tcp_reader.reader import TCPReader


def packet_callback(packet):
    _payload = bytes(packet['TCP'].payload)
    if b"MapComplementaryInformationEvent" in _payload:
        print(_payload)
        TCPReader(bytes(packet['TCP'].payload)).read()


if __name__ == "__main__":
    sniff(filter="tcp", prn=packet_callback)
