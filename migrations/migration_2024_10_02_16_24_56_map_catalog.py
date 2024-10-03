from clandestino_interfaces import AbstractMigration

from clandestino_sqlite.infra import SQLiteInfra


class Migration(AbstractMigration):

    infra = SQLiteInfra()

    async def up(self) -> None:
        """Do modifications in database"""
        async with self.infra.get_cursor() as cursor:
            sql = f"""
                CREATE TABLE IF NOT EXISTS MAP_CATALOG (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    map_id_from INTEGER NOT NULL,
                    map_id_to INTEGER NOT NULL,
                    direction INTEGER NOT NULL,
                    cell_id INTEGER NOT NULL,
                    offset_x REAL NOT NULL,
                    offset_y REAL NOT NULL
                )
            """
            cursor.execute(sql)
            sql = f"""
                CREATE INDEX from_to
                ON MAP_CATALOG(map_id_from, map_id_to)
            """
            cursor.execute(sql)

    async def down(self) -> None:
        """Undo modifications in database"""
        async with self.infra.get_cursor() as cursor:
            sql = f"""
                DROP TABLE MAP_CATALOG
            """
            cursor.execute(sql)
            sql = f"""
                DROP TABLE MAP_CATALOG
            """
            cursor.execute(sql)
