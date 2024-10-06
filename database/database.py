import meeseeks
from clandestino_sqlite.infra import SQLiteInfra


@meeseeks.OnlyOne()
class Database(SQLiteInfra):

    async def lala(self):
        cursor = await self.get_cursor()
