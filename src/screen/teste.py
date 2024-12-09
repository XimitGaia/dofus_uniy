import easyocr
import cv2
import numpy as np
from PIL import Image

def detectar_texto(caminho_imagem, texto_procurado):
    # Inicializa o leitor para português
    reader = easyocr.Reader(['pt'])

    # Realiza OCR na imagem
    resultado = reader.readtext(caminho_imagem)

    # Carrega a imagem com OpenCV
    imagem = cv2.imread(caminho_imagem)

    # Desenha os retângulos para cada texto encontrado
    for bbox, texto, confianca in resultado:
        # Verifica se o texto encontrado contém o texto procurado
        if texto_procurado.lower() in texto.lower():  # Comparação sem case sensitive
            # Extrai as coordenadas do bounding box
            (x1, y1), (x2, y2), (x3, y3), (x4, y4) = bbox

            # Desenha o contorno do texto na imagem
            cv2.polylines(
                imagem, [np.array([bbox], dtype=np.int32)], isClosed=True, color=(0, 255, 0), thickness=2
            )

            # Adiciona o texto na imagem
            cv2.putText(
                imagem, texto, (x1, y1 - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0, 255, 0), 2, cv2.LINE_AA
            )

    # Converte a imagem de BGR para RGB e exibe usando Pillow
    imagem_rgb = cv2.cvtColor(imagem, cv2.COLOR_BGR2RGB)
    img = Image.fromarray(imagem_rgb)
    img.show()



if __name__ == "__main__":
    # Especificar o caminho das imagens
    image_path2 = r"C:\Users\imxim\Documents\dofus_uniy\images\02_zaap.png"
    image_path3 = r"C:\Users\imxim\Documents\dofus_uniy\images\03_zaap.png"

    texto_procurado = "Area"

    detectar_texto(image_path2, texto_procurado)

