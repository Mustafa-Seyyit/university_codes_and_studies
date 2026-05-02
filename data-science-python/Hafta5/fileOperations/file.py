import os
# print(os.getcwd()) # projenin aktif dizinin gösterir
# os.chdir('/Users/mustafaseyyitdogan/Desktop') #aktif dizini değiştirme
# print(os.getcwd())

# dosyam = open("deneme.txt","w")
# dosyam.write("Merhaba ANR23")
# dosyam.close()
#

# os.chdir('/Users/mustafaseyyitdogan/Desktop')
# dosyam = open("deneme.txt","w")
# dosyam.write("Merhaba ANR23")
# dosyam.close() #başka bir dizinde işlem yapma

# with open("deneme.txt","w") as dosyam:
#     dosyam.write("Naber Müdür")
# otomatik dosya kapatma

# with open("deneme.txt","a") as dosyam:
#     dosyam.writelines(["NAber Müdür\n","bu da ikinci satır"]) #birden çok satır yazma

# if os.path.isfile('deneme.txt'):
#     with open("deneme.txt","r") as dosyam:
#         print(dosyam.read())
# else:
#     print("dosya bulunamadı")  dosyadana okuma

# if os.path.isfile("deneme.txt"):
#     with open("deneme.txt") as dosyam:
#         print(dosyam.readlines())
# else:
#     print("dosya bulunamadı")  satır satır okuma

# if os.path.isfile("deneme.txt"):
#     with open("deneme.txt") as dosyam:
#         satirlar = dosyam.readlines()
# else:
#     print("dosya bulunamadı")
# for satir in satirlar:
#     print(satir) bir stringe kaydedip yazma

# os.remove("deneme.txt")    dosya silme fonksiyonu

# os.rmdir("bruh") klasör silme fonksiyonu

