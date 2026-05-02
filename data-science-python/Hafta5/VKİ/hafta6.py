import pandas as pd
import matplotlib.pyplot as plt
import numpy as np
import warnings
warnings.filterwarnings('ignore')
veri = pd.read_csv('olimpiyatlar_madalya_alanlar.csv')
veri.head()

def plotHistogram(degisken):
    plt.figure()
    plt.hist(veri[degisken], bin = 85, color = 'orange')
    plt.xlabel(degisken)
    plt.ylabel('frekans')
    plt.title(f'{degisken}-Histogram Grafiği')
    plt.show()

plotHistogram("yas", "yil", "boy", "kilo")

veri.describe()

for elem in sayisal_degiskenler:
    plotHistogram(elem)