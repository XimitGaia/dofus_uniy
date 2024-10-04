from clandestino_interfaces import AbstractMigration
from clandestino_sqlite.infra import SQLiteInfra

class Migration(AbstractMigration):

    infra = SQLiteInfra()

    async def up(self) -> None:
        """Do modifications in database"""
        async with self.infra.get_cursor() as cursor:
            sql = f"""
                    CREATE TABLE IF NOT EXISTS HARVERTABLE_INFO (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        map_id INTEGER NOT NULL,
                        cell_id INTEGER NOT NULL,
                        gfx_id INTEGER NOT NULL,
                        m_origin_x INTEGER NOT NULL,
                        m_origin_y INTEGER NOT NULL,
                        m_size_x INTEGER NOT NULL,
                        m_size_y INTEGER NOT NULL
                    )
                """
            cursor.execute(sql)
            sql = f"""
                    CREATE INDEX gfx_id
                    ON HARVERTABLE_INFO(gfx_id)
                """
            cursor.execute(sql)

    async def down(self) -> None:
        """Undo modifications in database"""
        async with self.infra.get_cursor() as cursor:
            sql = f"""
                    DROP TABLE HARVERTABLE_INFO
                """
            cursor.execute(sql)
            sql = f"""
                    DROP INDEX gfx_id
                """
            cursor.execute(sql)

