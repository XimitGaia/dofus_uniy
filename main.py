from scapy.all import sniff

from src.tpc_reader.reader import TCPReader


def packet_callback(packet):
    TCPReader(bytes(packet['TCP'].payload)).read()


if __name__ == "__main__":
    sniff(filter="tcp", prn=packet_callback)
