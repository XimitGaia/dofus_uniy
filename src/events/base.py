from abc import ABC, abstractmethod
from typing import Self


class BaseEvent(ABC):

    @staticmethod
    @abstractmethod
    def get_signature() -> bytes:
        pass

    @classmethod
    @abstractmethod
    def from_proto(cls, proto) -> Self:
        pass
