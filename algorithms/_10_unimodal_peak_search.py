"""
    Tek Doruklu (Unimodal) Dizide Tepe Eleman Arama

    Dizi önce artar, tek bir maksimum değere ulaştıktan sonra azalır.

Örnek:
    [2, 5, 8, 15, 21, 18, 11, 4]

                21
              /\
            /    \
         artan   azalan

Bu problem Divide & Conquer yaklaşımıyla çözülür.

Zaman Karmaşıklığı:
    O(log n)

Bellek Karmaşıklığı:
    O(log n) (recursive)
"""


def peak_search(arr, left, right):
    """
    Tek doruklu dizide tepe elemanı bulur.

    Parametreler:
        arr   : Tek doruklu dizi
        left  : Sol sınır
        right : Sağ sınır

    Geri dönüş:
        Tepe elemanın indeksi
    """

    # Tek eleman kaldıysa tepe odur.
    if left == right:
        return left

    middle = (left + right) // 2

    # Eğer orta eleman sağındaki elemandan küçükse
    # tepe sağ taraftadır.
    if arr[middle] < arr[middle + 1]:
        return peak_search(arr, middle + 1, right)

    # Aksi halde tepe sol tarafta (orta dahil) bulunur.
    return peak_search(arr, left, middle)


def find_peak(arr):
    """
    Kullanıcıya kolay kullanım sağlayan fonksiyon.
    """

    if len(arr) == 0:
        return None

    index = peak_search(arr, 0, len(arr) - 1)

    return index, arr[index]


if __name__ == "__main__":

    numbers = [2, 5, 8, 12, 18, 27, 34, 41, 36, 30, 22, 15, 7]

    print("Tek doruklu dizi:")
    print(numbers)

    result = find_peak(numbers)

    print("\nTepe elemanın indeksi :", result[0])
    print("Tepe elemanın değeri  :", result[1])

    print("\nYineleme Bağıntısı")
    print("T(n) = T(n/2) + Θ(1)")

    print("\nZaman Karmaşıklığı : O(log n)")
    print("Bellek Karmaşıklığı: O(log n)")
