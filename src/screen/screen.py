import json
import time
from dataclasses import dataclass

import meeseeks
import pyautogui
from PIL import ImageGrab


@meeseeks.OnlyOne()
class Screen:
    screen_size: tuple[int, int]
    gameplay_screen: tuple[int, int, int, int]
    cell_width: float
    cell_height: float
    # height_const: float = 0.87555
    # width_const: float = 1.425 * height_const

    def __init__(self):
        height_const: float = 0.87555
        width_const: float = 1.425 * height_const
        screen_img = ImageGrab.grab()
        _width = screen_img.size[0]
        _height = screen_img.size[1]
        _gameplay_width = _height * width_const
        _gameplay_height = _height * height_const
        _x_offset = (_width - _gameplay_width) / 2
        self.cell_width = _gameplay_width / 14.5
        self.cell_height = _gameplay_height / 20.5
        self.screen_size = (int(_width), int(_height))
        self.gameplay_screen = (
            int(_x_offset),
            0,
            int(_x_offset + _gameplay_width),
            int(_gameplay_height),
        )

    def from_cell(self, cell_id: int, offset_x: float = 0, offset_y: float = 0):
        _row = cell_id // 14
        _column = cell_id % 14
        _x = self.gameplay_screen[0] + (_column + 0.5) * self.cell_width
        _y = (_row + 1) * self.cell_height / 2
        if _row % 2:
            _x += self.cell_width / 2
        return int(_x + offset_x * self.screen_size[1]), int(
            _y + offset_y * self.screen_size[1]
        )

    def find(self):
        pass


# _resolutions = [
#     (640, 480),
#     (720, 400),
#     (720, 480),
#     (800, 600),
#     (832, 624),
#     (1024, 768),
#     (1152, 864),
#     (1152, 870),
#     (1152, 870),
#     (1280, 720),
#     (1280, 800),
#     (1280, 1024),
# ]
#
# _data1 = {
#     "cell": 455,
#     "transform": {
#         "m11": 100.0,
#         "m12": 0.0,
#         "m21": 0.0,
#         "m22": 100.0,
#         "m31": 23.5,
#         "m32": 333.25,
#     },
#     "element": {
#         "m_id": 88321,
#         "m_type": 1,
#         "m_gfxId": 63672,
#         "m_height": 0,
#         "m_horizontalSymmetry": 0,
#         "m_origin": {"x": 18, "y": 124},
#         "m_size": {"x": 602, "y": 319},
#     },
# }
# _data2 = {
#     "cell": 383,
#     "transform": {
#         "m11": 100.0,
#         "m12": 0.0,
#         "m21": 0.0,
#         "m22": 100.0,
#         "m31": 31.0,
#         "m32": 152.25,
#     },
#     "element": {
#         "m_id": 88307,
#         "m_type": 1,
#         "m_gfxId": 63662,
#         "m_height": 0,
#         "m_horizontalSymmetry": 0,
#         "m_origin": {"x": 18, "y": 124},
#         "m_size": {"x": 147, "y": 270},
#     },
# }
# _data3 = {
#     "cell": 246,
#     "transform": {
#         "m11": -100.0,
#         "m12": 0.0,
#         "m21": 0.0,
#         "m22": 100.0,
#         "m31": 134.5,
#         "m32": 169.75,
#     },
#     "element": {
#         "m_origin": {"x": 0, "y": 0},
#         "m_size": {"x": 0, "y": 0},
#     },
# }
# _data4 = {
#     "cell": 397,
#     "transform": {
#         "m11": 100.0,
#         "m12": 0.0,
#         "m21": 0.0,
#         "m22": 100.0,
#         "m31": -135.5,
#         "m32": -100.75,
#     },
#     "element": {
#         "m_id": 88207,
#         "m_type": 1,
#         "m_gfxId": 63583,
#         "m_height": 0,
#         "m_horizontalSymmetry": 0,
#         "m_origin": {"x": 26, "y": 81},
#         "m_size": {"x": 82, "y": 127},
#     },
# }
# _data = _data1
# _x = _data["element"]["m_origin"]["x"]
# _y = _data["element"]["m_origin"]["y"]
# s = Screen.new()
# _w = s.gameplay_screen[2] - s.gameplay_screen[0]
# _h = s.gameplay_screen[3]
# _resize_const = s.screen_size[1] / 1024
# print(f"resize_const: {_resize_const}")
# # _new_x = _x * _resize_const
# # _new_y = _y * _resize_const
# # _new_x = (_x + _data["element"]["m_size"]["x"]/2 ) * _resize_const
# # _new_y = (_y + _data["element"]["m_size"]["y"]/2 + _data["transform"]["m32"] + _data["transform"]["m31"]) * _resize_const
# _new_x = _x * _resize_const + _data["transform"]["m31"] / 100 * _w / 100
# _new_y = _y * _resize_const + _data["transform"]["m32"] / 100 * _w / 100
# _new_x = -int(_new_x)
# _new_y = -int(_new_y)
# _pos_x, _pos_y = s._pos_from_cell(_data["cell"], _new_x, _new_y)
# cell_pos = s._pos_from_cell(_data["cell"])
# print("cell:", cell_pos)
# print("click:", _pos_x, _pos_y)
# print(
#     "img_size:",
#     int(_data["element"]["m_size"]["x"] * _resize_const),
#     int(_data["element"]["m_size"]["y"] * _resize_const),
# )
# print(f"offsets:", _new_x, _new_y)
#
#
# if __name__ == "__main__":
#     c_height = 0.87555
#     g_screen = 1.425
#     c_width = c_height * g_screen
#     # pyautogui.moveTo(cell_pos)
#     # time.sleep(0.5)
#     # pyautogui.moveTo(_pos_x, _pos_y)
#     print((s.cell_height) / s.screen_size[1])
#     e = 4, 420
#     d = 0, 321
#     b = 2, 536
#     pyautogui.moveTo(s._pos_from_cell(6, 0, -s.cell_height))
#
#     # time.sleep(0.5)
#
#     # pyautogui.moveTo(s._pos_from_cell(455, -_new_x, -_new_y))
#     # pyautogui.moveTo(s.gameplay_screen[0] +_x/1024 * s.screen_size[1], s.gameplay_screen[1] + _y/1024 * s.screen_size[1])
