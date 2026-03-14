import os
import fitz
import cv2
import numpy as np
from ultralytics import YOLO


MODEL_PATH = "/Users/mustafaseyyitdogan/Desktop/gorsel_algilama_proje/runs/detect/train/weights/best.pt"
PDF_PATH = "/Users/mustafaseyyitdogan/Desktop/gorsel_algilama_proje/test_pdfs/afet-ve-acil-durum-eylem-plani.pdf"
OUTPUT_DIR = "/Users/mustafaseyyitdogan/Desktop/gorsel_algilama_proje/output"


def pdf_to_images(pdf_path):
    doc = fitz.open(pdf_path)
    pages = []

    for page_num in range(len(doc)):
        page = doc.load_page(page_num)
        pix = page.get_pixmap()
        img = np.frombuffer(pix.samples, dtype=np.uint8).reshape(pix.height, pix.width, pix.n)

        if pix.n == 4:
            img = cv2.cvtColor(img, cv2.COLOR_RGBA2BGR)
        else:
            img = cv2.cvtColor(img, cv2.COLOR_RGB2BGR)

        pages.append((page_num + 1, img))

    return pages


def detect_and_crop(model, page_img, page_num, output_dir):
    results = model.predict(source=page_img, conf=0.25, verbose=False)

    for r in results:
        boxes = r.boxes.xyxy.cpu().numpy()
        classes = r.boxes.cls.cpu().numpy()

        for i, (box, cls_id) in enumerate(zip(boxes, classes)):
            x1, y1, x2, y2 = map(int, box)
            crop = page_img[y1:y2, x1:x2]

            class_name = model.names[int(cls_id)]
            class_dir = os.path.join(output_dir, class_name)
            os.makedirs(class_dir, exist_ok=True)

            filename = f"page_{page_num}_crop_{i+1}.png"
            save_path = os.path.join(class_dir, filename)

            cv2.imwrite(save_path, crop)


def process_pdf(pdf_path, model_path, output_dir):
    os.makedirs(output_dir, exist_ok=True)

    model = YOLO(model_path)
    pages = pdf_to_images(pdf_path)

    for page_num, page_img in pages:
        detect_and_crop(model, page_img, page_num, output_dir)

    print("İşlem tamamlandı.")


if __name__ == "__main__":
    process_pdf(PDF_PATH, MODEL_PATH, OUTPUT_DIR)