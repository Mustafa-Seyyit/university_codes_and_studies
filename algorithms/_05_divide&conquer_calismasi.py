# 1. BINARY SEARCH

"""
Binary Search bir Divide & Conquer örneğidir.

Şart:
    Liste sıralı olmalıdır.

Mantık:
    - Ortadaki elemana bakılır.
    - Aranan değer küçükse sol tarafa gidilir.
    - Büyükse sağ tarafa gidilir.
    - Her adımda problem yarıya iner.

Yineleme bağıntısı:
    T(n) = T(n / 2) + 1

Zaman karmaşıklığı:
    O(log n)
"""


def binary_search(arr, target, left, right):
    if left > right:
        return -1

    middle = (left + right) // 2

    if arr[middle] == target:
        return middle
    elif target < arr[middle]:
        return binary_search(arr, target, left, middle - 1)
    else:
        return binary_search(arr, target, middle + 1, right)


# 2. MERGE SORT

"""
Merge Sort da Divide & Conquer örneğidir.

Mantık:
    - Liste ikiye bölünür.
    - Sol taraf sıralanır.
    - Sağ taraf sıralanır.
    - İki sıralı liste birleştirilir.

Yineleme bağıntısı:
    T(n) = 2T(n / 2) + n

Zaman karmaşıklığı:
    O(n log n)

Bellek karmaşıklığı:
    O(n)
"""


def merge_sort(arr):
    if len(arr) <= 1:
        return arr

    middle = len(arr) // 2

    left = []
    right = []

    # Sol yarıyı oluştur
    for i in range(0, middle):
        left.append(arr[i])

    # Sağ yarıyı oluştur
    for i in range(middle, len(arr)):
        right.append(arr[i])

    left = merge_sort(left)
    right = merge_sort(right)

    return merge(left, right)


def merge(left, right):
    result = []
    i = 0
    j = 0

    # İki listedeki küçük elemanlar sırayla alınır
    while i < len(left) and j < len(right):
        if left[i] <= right[j]:
            result.append(left[i])
            i = i + 1
        else:
            result.append(right[j])
            j = j + 1

    # Sol listede kalan elemanları ekle
    while i < len(left):
        result.append(left[i])
        i = i + 1

    # Sağ listede kalan elemanları ekle
    while j < len(right):
        result.append(right[j])
        j = j + 1

    return result


# 3. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":
    print("DIVIDE & CONQUER ÇALIŞMASI")
    print("==========================")

    sorted_numbers = [3, 7, 12, 18, 25, 31, 40]
    target = 25

    index = binary_search(sorted_numbers, target, 0, len(sorted_numbers) - 1)

    print("\nBinary Search")
    print("Liste:", sorted_numbers)
    print("Aranan değer:", target)
    print("Bulunan indeks:", index)

    numbers = [38, 27, 43, 3, 9, 82, 10]

    print("\nMerge Sort")
    print("Sıralanmamış liste:", numbers)
    print("Sıralanmış liste:", merge_sort(numbers))
