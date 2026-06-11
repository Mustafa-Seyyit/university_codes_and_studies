"""
    Quick Sort (Hızlı Sıralama)

Quick Sort bir Divide & Conquer algoritmasıdır.

Adımlar:
1. Pivot seçilir.
2. Pivot'tan küçük ve büyük elemanlar ayrılır.
3. Sol ve sağ taraf recursive olarak sıralanır.

Bu örnekte pivot olarak SON eleman seçilmiştir.

Zaman Karmaşıklığı
------------------
En iyi durum   : O(n log n)
Ortalama durum : O(n log n)
En kötü durum  : O(n²)

Bellek Karmaşıklığı
-------------------
Recursive çağrılar nedeniyle yaklaşık O(log n)
"""


def partition(arr, low, high):
    """
    Diziyi pivot etrafında böler.

    Pivot:
        Son eleman
    """

    pivot = arr[high]

    i = low - 1

    for j in range(low, high):

        if arr[j] <= pivot:
            i += 1

            temp = arr[i]
            arr[i] = arr[j]
            arr[j] = temp

    temp = arr[i + 1]
    arr[i + 1] = arr[high]
    arr[high] = temp

    return i + 1


def quick_sort(arr, low, high):
    """
    Quick Sort algoritması.
    """

    if low < high:

        # Pivotun doğru konumu bulunur.
        pivot_index = partition(arr, low, high)

        # Sol taraf sıralanır.
        quick_sort(arr, low, pivot_index - 1)

        # Sağ taraf sıralanır.
        quick_sort(arr, pivot_index + 1, high)


if __name__ == "__main__":

    numbers = [38, 27, 43, 3, 9, 82, 10, 15, 7]

    print("Sıralanmamış dizi:")
    print(numbers)

    quick_sort(numbers, 0, len(numbers) - 1)

    print("\nSıralanmış dizi:")
    print(numbers)

    print("\nYineleme Bağıntısı")
    print("En iyi durum : T(n)=2T(n/2)+Θ(n)")
    print("En kötü durum: T(n)=T(n-1)+Θ(n)")
