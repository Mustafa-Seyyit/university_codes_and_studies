# This is a sample Python script.

# Press ⌃R to execute it or replace it with your code.
# Press Double ⇧ to search everywhere for classes, files, tool windows, actions, and settings.
#python da üs alma operatörü '**' şeklindedir

#d, e, f = 413, 1, "veri bilimine giriş" tarzında bir atama vardır.
#oluşturulan değişkenler bellekde nesne olarak oluşturulur ve unutma daha efektif bellek kullanmak için
#değişkenle işin bitince del komutu ile sil

# '4' strinleri birleştirir '*' sonrasında yazdığıınmız sayı kadar stringi tekrearlar
# type bir değişkenin türünün ne olduğunu bize söyleyen bir komuttur.
#355/113 pi sayısına denkdir.
#kesinlikle açıklama yaz kodlara
#append() fonksiyonu bir listeye eleman ekler örnek kullanım fruits.append("banana")
#insert() belirtilen bölüme belirtilen elemanı ekler.
#listeni içine birden fazla eleman eklemek için extend() kullanılır.
#remove() listeden içeriği verilen elemanı çıkartır.
#pop() listenin içerisindeki en son elemanı çıkartır. indeks numarasını verirsek o indeksdekini çıkartır
#del() silme işlemi yapar.
#index() liste içerisindeki indeks numarasını verir örnek: kisiler.index("ozgur")
#sort() sıralama işlemi yapar küçükten büuyüğe veua A->Z şeklinde
#reverse() listeyi terse çevirir
#len() listenin kaç elemanlı oluduğunu gösterir.
#input() klavyeden ne girilirse girilsin strin olarak alır.
#f"string" kullanımını öğren aşağıda örneği var

#num = 3000
#fraction = 1/3
#print(f"{num*fraction} is {fraction} % of {num}")

#range() sayı dizisi döndürür

#for x in range(2) veya for x in range(2, 30, 3) for kullanım örneği

#enumerate kullanımı
#enumerate x de indeks değerini y de değişken ifadesini  tutar.
#fruits = ["apple", "banana", "cherry"]
#for x, y in enumerate(fruits):
#    print(x," ", y)


# a = input("Enter a number: ")
# b = 0
# sayac = 0
# while a != 'q':
#     sayac += 1
#     b += int(a)
#     a = input("Enter a number: ")
# print(b/sayac)

#
# def my_function (x):
#     return 5*x, x**x
#
# print(my_function(3))
# print(my_function(5))
#
# a= my_function(5) #dönen değeri a ya atar ve a tuple olur
#
# a, b = my_function(5) #dönen deperlerin birincisini a ya ikincisini b ye atar
#
# print(type(my_function))

def tekrarla4(A):
    toplam = " "
    for i in range(len(A)):
        print(A[i]*4)
        toplam += A[i]*4
    print(toplam)

tekrarla4(input("ifade girin"))
