from clandestino_sqlite.infra import SQLiteInfra

from src.model.map_data import MapRegister


class BotData:
    _infra = SQLiteInfra()

    @classmethod
    async def save_maps(cls, maps: list[MapRegister]):
        async with cls._infra.get_cursor() as cursor:
            sql = f"""
                INSERT INTO  MAP_CATALOG (
                    map_id_from,
                    map_id_to,
                    direction,
                    cell_id,
                    offset_x,
                    offset_y
                ) VALUES (?,?,?,?,?,?)
            """
            cursor.executemany(sql, [i.as_tuple() for i in maps])
