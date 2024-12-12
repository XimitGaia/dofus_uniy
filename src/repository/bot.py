import asyncio
import random

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
                    interaction_id,
                    offset_x,
                    offset_y
                ) VALUES (?,?,?,?,?,?)
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

    @classmethod
    async def get_harvestable_quantity_by_id(cls, gfx_ids: list[int]):
        async with cls._infra.get_cursor() as cursor:
            sql = f"""
            SELECT 
            map_id, gfx_id, interaction_id, cell_id, offset_x, offset_y 
            FROM HARVERTABLE_INFO 
            WHERE gfx_id IN ({",".join("?" for _ in gfx_ids)})
            """
            result = cursor.execute(sql, gfx_ids)
            return result.fetchall()

    @classmethod
    async def get_out_neighborhoods(
        cls, maps: set[int], exclude: set[int] = None
    ) -> set[int]:
        _to_replace = list(maps)
        async with cls._infra.get_cursor() as cursor:
            sql = f"""
            SELECT map_id_to FROM 'MAP_CATALOG'
            WHERE map_id_from IN ({",".join("?" for _ in maps)})
            """
            if exclude is not None:
                sql += f" AND map_id_to NOT IN ({",".join("?" for _ in exclude)})"
                _to_replace = _to_replace + list(exclude)
            result = cursor.execute(sql, _to_replace)
            _maps = [i[0] for i in result.fetchall()]
            return set(_maps)

    @classmethod
    async def get_in_neighborhoods(
        cls, maps: set[int], exclude: set[int] = None
    ) -> set[int]:
        _to_replace = list(maps)
        async with cls._infra.get_cursor() as cursor:
            sql = f"""
            SELECT map_id_from FROM 'MAP_CATALOG'
            WHERE map_id_to IN ({",".join("?" for _ in maps)})
            """
            if exclude is not None:
                sql += f" AND map_id_to NOT IN ({",".join("?" for _ in exclude)})"
                _to_replace = _to_replace + list(exclude)
            result = cursor.execute(sql, _to_replace)
            _maps = [i[0] for i in result.fetchall()]
            return set(_maps)

    @classmethod
    async def find_connectors(cls, map_id_from: int, map_id_to: int) -> list[tuple]:
        async with cls._infra.get_cursor() as cursor:
            sql = f"""
            SELECT map_id_from, map_id_to, cell_id, offset_x, offset_y FROM 'MAP_CATALOG'
            WHERE map_id_to = {map_id_to}
            AND map_id_from = {map_id_from}
            """
            result = cursor.execute(sql)
            return random.choice(result.fetchall())
