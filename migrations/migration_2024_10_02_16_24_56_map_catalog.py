from clandestino_interfaces import AbstractMigration

from clandestino_sqlite.infra import SQLiteInfra


class Migration(AbstractMigration):

    infra = SQLiteInfra()

    async def up(self) -> None:
        """Do modifications in database"""
        pass

    async def down(self) -> None:
        """Undo modifications in database"""
        pass
