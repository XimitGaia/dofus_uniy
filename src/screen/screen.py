import json
import time
from dataclasses import dataclass

import pyautogui
from PIL import ImageGrab


@dataclass(frozen=True, slots=True)
class Screen:
    screen_size: tuple[int, int]
    gameplay_screen: tuple[int, int, int, int]
    cell_width: float
    cell_height: float
    # height_const: float = 0.87555
    # width_const: float = 1.425 * height_const

    @classmethod
    def new(cls):
        height_const: float = 0.87555
        width_const: float = 1.425 * height_const
        screen_img = ImageGrab.grab()
        _width = screen_img.size[0]
        _height = screen_img.size[1]
        _gameplay_width = _height * width_const
        _gameplay_height = _height * height_const
        _x_offset = (_width - _gameplay_width) / 2
        return Screen(
            cell_width=_gameplay_width / 14.5,
            cell_height=_gameplay_height / 20.5,
            screen_size=(int(_width), int(_height)),
            gameplay_screen=(
                int(_x_offset),
                0,
                int(_x_offset + _gameplay_width),
                int(_gameplay_height),
            ),
        )

    def _pos_from_cell(self, cell_id: int, offset_x: float = 0, offset_y: float = 0):
        _row = cell_id // 14
        _column = cell_id % 14
        _x = self.gameplay_screen[0] + (_column + 0.5) * self.cell_width
        _y = (_row + 1) * self.cell_height / 2
        if _row % 2:
            _x += self.cell_width / 2
        return int(_x + offset_x), int(
            _y + offset_y
        )
_resolutions = [
    (640,480),
    (720,400),
    (720,480),
    (800,600),
    (832,624),
    (1024,768),
    (1152,864),
    (1152,870),
    (1152,870),
    (1280,720),
    (1280,800),
    (1280,1024),
]

transform = {
    "m11": 100.0,
    "m12": 0.0,
    "m21": 0.0,
    "m22": 100.0,
    "m31": 23.5,
    "m32": 333.25,
}
# 1104 554
#
# 1.833887

element = {
    "m_id": 88321,
    "m_type": 1,
    "m_gfxId": 63672,
    "m_height": 0,
    "m_horizontalSymmetry": 0,
    "m_origin": {"x": 18, "y": 124},
    "m_size": {"x": 602, "y": 319},
}
_x = element["m_origin"]["x"]
_y = element["m_origin"]["y"]

_new_x = (transform["m11"] * _x + transform["m12"] * _y) + transform["m31"]
_new_y = (transform["m21"] * _x + transform["m22"] * _y) + transform["m32"]
# (1280,1024)
# 3440
# 1440

# -536
# -1006


if __name__ == "__main__":
    c_height = 0.87555
    g_screen = 1.425
    c_width = c_height * g_screen
    s = Screen.new()
    # time.sleep(2)
    # pyautogui.moveTo(s._pos_from_cell(455, -_x, -_y))


    for a in _resolutions:
        print(a)
        _new_x = (_new_x /a[0]) *s.screen_size[0]
        _new_y = _new_y /a[1]*s.screen_size[1]
        time.sleep(2)
        pyautogui.moveTo(s._pos_from_cell(455, -_new_x/1000, _new_y/1000))
