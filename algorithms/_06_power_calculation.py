# 1. NORMAL YÖNTEM

"""
Örnek:
    2^5 = 2 * 2 * 2 * 2 * 2

Bu yöntemde taban sayı, üs kadar çarpılır.

Eğer üs n ise:
    Döngü n kez çalışır.

Zaman karmaşıklığı:
    O(n)

Bellek karmaşıklığı:
    O(1)
"""


def power_normal(base, exponent):
    """
    Normal yöntemle kuvvet alma.

    Parametreler:
        base: Taban sayı
        exponent: Üs değeri

    Geri dönüş:
        base üzeri exponent sonucu

    Örnek:
        power_normal(2, 5) -> 32
    """

    # Negatif üs durumunda:
    # 2^-3 = 1 / 2^3
    if exponent < 0:
        return 1 / power_normal(base, -exponent)

    result = 1

    # base sayısını exponent kadar tekrar tekrar çarpıyoruz
    for i in range(exponent):
        result = result * base

    return result


# 2. BÖL VE FETHET YÖNTEMİ
"""
Böl ve Fethet mantığı:

Problem:
    base^exponent

Eğer exponent çift ise:
    base^exponent = (base^(exponent / 2)) * (base^(exponent / 2))

Örnek:
    2^8 = 2^4 * 2^4

Eğer exponent tek ise:
    base^exponent = base * base^(exponent - 1)

Daha verimli hali:
    2^9 = 2 * 2^8
        = 2 * (2^4 * 2^4)

Her adımda üs yaklaşık yarıya indiği için daha hızlıdır.

Yineleme bağıntısı:
    T(n) = T(n / 2) + 1

Zaman karmaşıklığı:
    O(log n)

Bellek karmaşıklığı:
    O(log n)
    Çünkü recursive çağrılar stack üzerinde tutulur.
"""


def power_divide_and_conquer(base, exponent):
    """
    Böl ve Fethet yöntemiyle kuvvet alma.

    Parametreler:
        base: Taban sayı
        exponent: Üs değeri

    Geri dönüş:
        base üzeri exponent sonucu

    Örnek:
        power_divide_and_conquer(2, 5) -> 32
    """

    # Negatif üs durumunda:
    # 2^-3 = 1 / 2^3
    if exponent < 0:
        return 1 / power_divide_and_conquer(base, -exponent)

    # Her sayının 0. kuvveti 1'dir
    if exponent == 0:
        return 1

    # Üs 1 ise sonuç tabanın kendisidir
    if exponent == 1:
        return base

    # Üssün yarısını hesapla
    half_power = power_divide_and_conquer(base, exponent // 2)

    # Eğer üs çift ise:
    # base^n = base^(n/2) * base^(n/2)
    if exponent % 2 == 0:
        return half_power * half_power

    # Eğer üs tek ise:
    # base^n = base * base^(n//2) * base^(n//2)
    else:
        return base * half_power * half_power


# 3. İŞLEM SAYISI KARŞILAŞTIRMA

"""
Aşağıdaki iki fonksiyon gerçek sonucu hesaplamaktan çok,
yaklaşık kaç çarpma işlemi yapıldığını göstermek için yazılmıştır.

Amaç:
    Normal yöntem ile Böl ve Fethet yönteminin farkını görmek.
"""


def count_operations_normal(exponent):
    """
    Normal yöntemde üs kadar çarpma yapılır.

    Örnek:
        exponent = 8 ise yaklaşık 8 işlem
    """

    if exponent < 0:
        exponent = -exponent

    count = 0

    for i in range(exponent):
        count = count + 1

    return count


def count_operations_divide_and_conquer(exponent):
    """
    Böl ve Fethet yönteminde üs her adımda ikiye bölünür.

    Örnek:
        exponent = 8 için:
            8 -> 4 -> 2 -> 1

    Bu yüzden işlem sayısı log n mantığıyla büyür.
    """

    if exponent < 0:
        exponent = -exponent

    if exponent <= 1:
        return 1

    return count_operations_divide_and_conquer(exponent // 2) + 1


# 4. PROGRAMI ÇALIŞTIRMA BÖLÜMÜ

if __name__ == "__main__":
    print("BİR SAYININ KUVVETİNİ ALMA PROBLEMİ")
    print("===================================")

    base = 2
    exponent = 10

    print("Taban:", base)
    print("Üs:", exponent)

    print("\n1) Normal Yöntem")
    normal_result = power_normal(base, exponent)
    print("Sonuç:", normal_result)
    print("Yaklaşık işlem sayısı:", count_operations_normal(exponent))
    print("Zaman karmaşıklığı: O(n)")

    print("\n2) Böl ve Fethet Yöntemi")
    divide_conquer_result = power_divide_and_conquer(base, exponent)
    print("Sonuç:", divide_conquer_result)
    print("Yaklaşık işlem sayısı:", count_operations_divide_and_conquer(exponent))
    print("Zaman karmaşıklığı: O(log n)")

    print("\nKarşılaştırma")
    print("Normal yöntem daha kolaydır ama büyük üslerde yavaştır.")
    print("Böl ve Fethet yöntemi daha hızlıdır çünkü üs her adımda ikiye bölünür.")

    print("\nNegatif üs örneği")
    print("2^-3 =", power_divide_and_conquer(2, -3))
