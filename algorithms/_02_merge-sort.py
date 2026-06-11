def merge_sort(arr):
    """
    Merge Sort algoritması.
    Listeyi küçükten büyüğe sıralar.

    ZAMAN KARMAŞIKLIĞI:
    En iyi durum: O(n log n)
    Ortalama durum: O(n log n)
    En kötü durum: O(n log n)

    BELLEK KARMAŞIKLIĞI:
    O(n)
    Parametre:
        arr: Sıralanacak liste

    Geri dönüş:
        Sıralanmış liste
    """

    # Eğer listede 0 veya 1 eleman varsa zaten sıralıdır
    if len(arr) <= 1:
        return arr

    # Listenin orta noktası bulunur
    mid = len(arr) // 2

    # Liste iki parçaya ayrılır
    left = []
    right = []

    # Sol yarıyı oluştur
    for i in range(0, mid):
        left.append(arr[i])

    # Sağ yarıyı oluştur
    for i in range(mid, len(arr)):
        right.append(arr[i])

    # Sol ve sağ parçalar kendi içinde sıralanır
    left = merge_sort(left)
    right = merge_sort(right)

    # Sıralı iki parça birleştirilir
    return merge(left, right)


def merge(left, right):
    """
    İki sıralı listeyi tek bir sıralı liste haline getirir.
    """

    result = []

    i = 0  # left listesi için indeks
    j = 0  # right listesi için indeks

    # İki listede de eleman olduğu sürece karşılaştırma yapılır
    while i < len(left) and j < len(right):
        if left[i] <= right[j]:
            result.append(left[i])
            i += 1
        else:
            result.append(right[j])
            j += 1

    # left listesinde kalan elemanlar eklenir
    while i < len(left):
        result.append(left[i])
        i += 1

    # right listesinde kalan elemanlar eklenir
    while j < len(right):
        result.append(right[j])
        j += 1

    return result


# Örnek kullanım
numbers = [38, 27, 43, 3, 9, 82, 10]

print("Sıralanmamış liste:", numbers)

sorted_numbers = merge_sort(numbers)

print("Sıralanmış liste:", sorted_numbers)