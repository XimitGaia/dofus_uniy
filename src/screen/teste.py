import cv2
import easyocr
import pyautogui


def load_images(image_path1, image_path2):
    img1 = cv2.imread(image_path1)
    img2 = cv2.imread(image_path2)
    return img1, img2


def detect_movement(image1, image2):
    gray1 = cv2.cvtColor(image1, cv2.COLOR_BGR2GRAY)
    gray2 = cv2.cvtColor(image2, cv2.COLOR_BGR2GRAY)

    diff = cv2.absdiff(gray1, gray2)

    _, thresh = cv2.threshold(diff, 30, 255, cv2.THRESH_BINARY)

    contours, _ = cv2.findContours(thresh, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

    for contour in contours:
        if cv2.contourArea(contour) > 50000:  # Filtrar objetos pequenos
            (x, y, w, h) = cv2.boundingRect(contour)
            _img = image2[y : y + h, x : x + w]
            reader = easyocr.Reader(["en"])

            results = reader.readtext(_img)
            for bbox, text, prob in results:
                print(text)
                if "territory" in text.lower():
                    print("achou")
                    top_left = bbox[0]  # (x1, y1)
                    bottom_right = bbox[2]  # (x3, y3)

                    # Coordenadas do meio do bbox
                    center_x = int((top_left[0] + bottom_right[0]) / 2)
                    center_y = int((top_left[1] + bottom_right[1]) / 2)
                    pyautogui.moveTo(x + center_x, y + center_y)
            break
    return image2


if __name__ == "__main__":
    # Especificar o caminho das imagens que você quer testar
    image_path1 = r"C:\Users\imxim\Documents\dofus_uniy\images\base2.png"  # Substitua com o caminho da sua primeira imagem
    image_path2 = r"C:\Users\imxim\Documents\dofus_uniy\images\dif1.png"  # Substitua com o caminho da sua segunda imagem

    # Carregar as imagens
    img1, img2 = load_images(image_path1, image_path2)

    # Detectar e desenhar objetos
    result_image = detect_movement(img1, img2)
