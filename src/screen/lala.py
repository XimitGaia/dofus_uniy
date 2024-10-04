def calcular_posicao_render(element, transform, screen_width, screen_height):
    # Pega as coordenadas da origem e do tamanho do objeto
    origem_x = element["m_origin"]["x"]
    origem_y = element["m_origin"]["y"]
    tamanho_x = element["m_size"]["x"]
    tamanho_y = element["m_size"]["y"]

    # Aplica a matriz de transformação à origem (canto superior esquerdo)
    novo_x1 = (
        transform["m11"] * origem_x + transform["m21"] * origem_y + transform["m31"]
    )
    novo_y1 = (
        transform["m12"] * origem_x + transform["m22"] * origem_y + transform["m32"]
    )

    # Aplica a matriz de transformação ao canto inferior direito (origem + tamanho)
    novo_x2 = (
        transform["m11"] * (origem_x + tamanho_x)
        + transform["m21"] * (origem_y + tamanho_y)
        + transform["m31"]
    )
    novo_y2 = (
        transform["m12"] * (origem_x + tamanho_x)
        + transform["m22"] * (origem_y + tamanho_y)
        + transform["m32"]
    )

    # Mapeia para coordenadas de tela, assumindo que o ponto (0, 0) é o canto superior esquerdo
    pixel_x1 = (novo_x1 / screen_width) * screen_width
    pixel_y1 = (novo_y1 / screen_height) * screen_height

    pixel_x2 = (novo_x2 / screen_width) * screen_width
    pixel_y2 = (novo_y2 / screen_height) * screen_height

    # Retorna as novas coordenadas em pixels do canto superior esquerdo e inferior direito
    return (pixel_x1, pixel_y1), (pixel_x2, pixel_y2)


# Exemplo de uso
element = {
    "m_id": 88321,
    "m_type": 1,
    "m_gfxId": 63672,
    "m_height": 0,
    "m_horizontalSymmetry": 0,
    "m_origin": {"x": 18, "y": 124},
    "m_size": {"x": 602, "y": 319},
}

transform = {
    "m11": 100.0,
    "m12": 0.0,
    "m21": 0.0,
    "m22": 100.0,
    "m31": 23.5,
    "m32": 333.25,
}

screen_width = 1920  # Full HD width
screen_height = 1080  # Full HD height

if __name__ == "__main__":
    # Calcula as posições de renderização em pixels
    posicao_superior_esquerda, posicao_inferior_direita = calcular_posicao_render(
        element, transform, screen_width, screen_height
    )

    print("Canto superior esquerdo (em pixels):", posicao_superior_esquerda)
    print("Canto inferior direito (em pixels):", posicao_inferior_direita)
