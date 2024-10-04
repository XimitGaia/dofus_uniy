from clandestino_sqlite.infra import SQLiteInfra

from src.model.map_data import MapRegister, HarverstableInfo, Zaap


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

    @classmethod
    async def save_harvestable_info(cls, maps: list[HarverstableInfo]):
        async with cls._infra.get_cursor() as cursor:
            sql = f"""
                INSERT INTO  HARVERTABLE_INFO (
                    map_id,
                    cell_id,
                    gfx_id,
                    m_origin_x,
                    m_origin_y,
                    m_size_x,
                    m_size_y
                ) VALUES (?,?,?,?,?,?,?)
            """
            cursor.executemany(sql, [i.as_tuple() for i in maps])

    @classmethod
    async def save_zaap(cls, maps: list[Zaap]):
        async with cls._infra.get_cursor() as cursor:
            sql = f"""
                INSERT INTO  ZAAPS (
                    map_id,
                    name
                ) VALUES (?,?)
            """
            cursor.executemany(sql, [i.as_tuple() for i in maps])
