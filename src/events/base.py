from abc import ABC, abstractmethod


class BaseEvent(ABC):

    @abstractmethod
    @staticmethod
    def get_signature() -> bytes:
         pass