
import cv2
import numpy as np

def saltPepperNoise(image):
    row,col,ch = image.shape
    s_vs_p = 0.5
    amount = 0.04
    noisy = np.copy(image)
    num_salt = int(np.ceil(amount*image.size*s_vs_p))
    corrds = [np.random.randint(0,i,num_salt) for i in image.shape]
    noisy[tuple(corrds)] = 1
    num_pep = int(np.ceil(amount*image.size*s_vs_p))
    corrds = [np.random.randint(0,i,num_pep) for i in image.shape]
    noisy[tuple(corrds)] = 0
    return noisy

img = cv2.imread("/Users/mustafaseyyitdogan/Desktop/university_codes_and_studies/Computer-Vision/hafta7/input.png")
img = img/255
noise_img = saltPepperNoise(img)
cv2.imshow("Salt and Pepper Noise",noise_img)
cv2.waitKey(0)
cv2.destroyAllWindows()
