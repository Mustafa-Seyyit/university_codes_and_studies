def insertion_sort(arr):
    """
    Insertion Sort algoritması.
    Listeyi küçükten büyüğe sıralar.

    ZAMAN KARMAŞIKLIĞI:
    En iyi durum: O(n)
    Ortalama durum: O(n²)
    En kötü durum: O(n²)

    BELLEK KARMAŞIKLIĞI:
    O(1)  

    Parametre:
        arr: Sıralanacak liste

    Geri dönüş:
        Sıralanmış liste
    """

    # 1. eleman zaten tek başına sıralı kabul edilir.
    # Bu yüzden döngü 1. indisten başlar.
    for i in range(1, len(arr)):
        key = arr[i]      # Yerine yerleştirilecek eleman
        j = i - 1         # key'in solundaki elemanları kontrol etmek için

        # Soldaki elemanlar key'den büyük olduğu sürece sağa kaydırılır
        while j >= 0 and arr[j] > key:
            arr[j + 1] = arr[j]
            j -= 1

        # key doğru boşluğa yerleştirilir
        arr[j + 1] = key

    return arr


# Örnek kullanım
numbers = [5, 2, 4, 6, 1, 3]

print("Sıralanmamış liste:", numbers)

sorted_numbers = insertion_sort(numbers)

print("Sıralanmış liste:", sorted_numbers)