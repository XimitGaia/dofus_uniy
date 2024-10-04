import cv2


def load_images(image_path1, image_path2):
    img1 = cv2.imread(image_path1)
    img2 = cv2.imread(image_path2)
    return img1, img2


def detect_movement(image1, image2):
    # Converter para escala de cinza
    gray1 = cv2.cvtColor(image1, cv2.COLOR_BGR2GRAY)
    gray2 = cv2.cvtColor(image2, cv2.COLOR_BGR2GRAY)

    # Calcular a diferença absoluta entre as imagens
    diff = cv2.absdiff(gray1, gray2)

    # Aplicar um limiar para destacar as áreas com mudanças
    _, thresh = cv2.threshold(diff, 30, 255, cv2.THRESH_BINARY)

    # Encontrar os contornos
    contours, _ = cv2.findContours(thresh, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

    # Desenhar caixas delimitadoras ao redor dos contornos
    for contour in contours:
        if 2000000 > cv2.contourArea(contour) > 500000:  # Filtrar objetos pequenos
            (x, y, w, h) = cv2.boundingRect(contour)
            _img = image2.crop((x, y, x+w, y+h))
            reader = easyocr.Reader(['en'])

            results = reader.readtext(image_path)
            cv2.rectangle(image2, (x, y), (x + w, y + h), (0, 255, 0), 2)

    return image2

if __name__ == "__main__":
    # Especificar o caminho das imagens que você quer testar
    image_path1 = '/Users/lucasalmeida/Desktop/base.png'  # Substitua com o caminho da sua primeira imagem
    image_path2 = '/Users/lucasalmeida/Desktop/dif3.png'  # Substitua com o caminho da sua segunda imagem

    # Carregar as imagens
    img1, img2 = load_images(image_path1, image_path2)

    # Detectar e desenhar objetos
    result_image = detect_movement(img1, img2)

    # Exibir o resultado
    cv2.imshow("Detected Movement", result_image)
    cv2.waitKey(0)
    cv2.destroyAllWindows()
