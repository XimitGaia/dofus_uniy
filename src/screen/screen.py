
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
        _width = screen_img.size[0]/2
        _height = screen_img.size[1]/2
        _gameplay_width = _height * width_const
        _gameplay_height = _height * height_const
        _x_offset = (_width - _gameplay_width)/2
        return Screen(
            cell_width=_gameplay_width/14.5,
            cell_height=_gameplay_height/20.5,
            screen_size=(int(_width), int(_height)),
            gameplay_screen=(int(_x_offset), 0,  int(_x_offset + _gameplay_width), int(_gameplay_height))
        )

    def _pos_from_cell(self, cell_id: int, offset_x: float = 0, offset_y: float = 0):
        _row = cell_id // 14
        _column = cell_id % 14
        _x = self.gameplay_screen[0] + (_column + 0.5) * self.cell_width
        _y = (_row + 1) * self.cell_height / 2
        if _row % 2:
            _x += self.cell_width / 2
        pyautogui.moveTo(int(_x + offset_x * self.screen_size[1]), int(_y + offset_y * self.screen_size[1]))

if __name__ == "__main__":
    c_height = 0.87555
    g_screen = 1.425
    c_width = c_height * g_screen
    s = Screen.new()
    for x in range(0, 560):
        s._pos_from_cell(x)
        time.sleep(0.1)


