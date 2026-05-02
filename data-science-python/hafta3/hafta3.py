#Lambda fonksiyonu küük anonim bir fonksiyon 1 değer döndüdrür
# x = lambda a : a+10
"""bir sayının 2 ve 3 katını alma işlemlerinde kullanılabilir lambda
def myfunction(n):
    return lambda a : a *n

myDoubler = myfunction(2)
print(myDoubler(11))

myTripler = myfunction(3)
print(myTripler(11))

lambda ile iki sayının büyüğünü döndürme
Max = lambda a,b : a if(a>b) else b
print(Max(1,2))

List = [[20,3,4],[10,4,16,5],[30,6,9,12]]
sortlist = lambda x : (sorted(i) for i in x)
#sorted verilen girdiyi sıralar ve geriye yeni bir liste döndürür
secondLargest = lambda x,f : [y[len(y)-2] for y in f(x)]
res = secondLargest(List, sortlist)
print(res)
"""
#hata yakalama da try except yapısı kullanılır
#constructor ise _init_dir

#L1_copy =L1 : l1 in kopyasını : oluşturur
#java daki this sburada self dir constructor
"""
try:
    sayi1 = input("sayı girin")
    sayi2 = input("sayi girin")
    sonuc = (int)(sayi1) / (int)(sayi2)
    print(sonuc)

except ZeroDivisionError:
        print("0 a bölme yapamazsınız")
except ValueError:
        print("yanlış değer")

finally:
    print("bölme işlemi gerçekleşti.")
"""
#finally her halükarda çalışır program çalışsada çalışmasada
"""
try:
    f = open("demofile.txt")
    try:
        f.write("Lorum Ipsum")
    except:
        print("something went wrong when writing to the file")
    finally:
        f.close()
except:
    print("something went wrong when opening the file")
#yazılabilir olmayan bir dosya açma alıştırması
"""
"""
def remove_dups(L1, L2):
    for x in L1:
        if x in L2:
            L1.remove(x)

L1 = [10,20,30,40]
L2 = [10,20,50,60]
remove_dups(L1, L2)
print(L1)

#bunun çıktısı [20,30,40] şeklinde yanlış olur doğrusu için kopyasını kullanmalıyız
"""

"""
def remove_dups(L1, L2):
    L1_copy = L1[:] # L1_copy = L1 pointer mantığı ile işler bu yüzden işe yaramaz 
    #aynı nesneyi işaret eder ama  L1_copy = L1[:] işlemi yeni bir nesne oluşturur.
    for e in L1_copy:
        if e in L2:
            L1.remove(e)
L1 = [10,20,30,40]
L2 = [10,20,50,60]
remove_dups(L1, L2)
print(L1)   
"""