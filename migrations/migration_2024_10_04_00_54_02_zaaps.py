import json
from pathlib import Path

from clandestino_interfaces import AbstractMigration

from clandestino_sqlite.infra import SQLiteInfra
from decouple import config

from src.model.map_data import Zaap


async def insert_data():
    buffer = []
    with open(Path(config("ZAAP_FILE_PATH")).resolve(), "r") as file:
        _data = json.load(file)
        [buffer.append(Zaap(int(_id), name)) for _id, name in _data.items()]


class Migration(AbstractMigration):

    infra = SQLiteInfra()

    async def up(self) -> None:
        async with self.infra.get_cursor() as cursor:
            sql = f"""
                    CREATE TABLE IF NOT EXISTS ZAAPS (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        map_id INTEGER NOT NULL,
                        name TEXT NOT NULL
                    )
                """
            cursor.execute(sql)
            sql = f"""
                    CREATE INDEX zaap_map_id
                    ON ZAAPS(map_id)
                """
            cursor.execute(sql)

    async def down(self) -> None:
        """Undo modifications in database"""
        async with self.infra.get_cursor() as cursor:
            sql = f"""
                    DROP TABLE ZAAPS
                """
            cursor.execute(sql)
            sql = f"""
                    DROP INDEX zaap_map_id
                """
            cursor.execute(sql)
