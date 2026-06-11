# 1. BIG-O NOTASYONU: O( )
"""
Big-O, algoritmanın en kötü durumda ne kadar büyüyebileceğini gösterir.

Yani üst sınırdır.

Örnek:
    Bir algoritma O(n^2) ise, giriş büyüdükçe çalışma süresi
    en fazla karesel şekilde artar diyebiliriz.

Sınavlarda çoğu zaman "zaman karmaşıklığı nedir?" sorusunda
Big-O istenir.
"""


# O(1) - Sabit zaman
def constant_time_example(arr):
    """
    Zaman karmaşıklığı: O(1)

    Çünkü listenin boyutu kaç olursa olsun sadece ilk elemana bakılır.
    n = 10 olsa da, n = 1.000.000 olsa da yapılan işlem sayısı sabittir.
    """

    if len(arr) == 0:
        return None

    return arr[0]


# O(n) - Doğrusal zaman
def linear_time_example(arr):
    """
    Zaman karmaşıklığı: O(n)

    Çünkü listedeki her eleman bir kez gezilir.
    Liste büyüdükçe işlem sayısı da aynı oranda artar.
    """

    total = 0

    for i in range(len(arr)):
        total = total + arr[i]

    return total


# O(n^2) - Karesel zaman
def quadratic_time_example(arr):
    """
    Zaman karmaşıklığı: O(n^2)

    Çünkü iç içe iki döngü vardır.
    Dış döngü n kez çalışır.
    İç döngü de her dış döngü için n kez çalışır.

    Toplam işlem yaklaşık:
        n * n = n^2
    """

    pair_count = 0

    for i in range(len(arr)):
        for j in range(len(arr)):
            pair_count = pair_count + 1

    return pair_count


# O(log n) - Logaritmik zaman
def logarithmic_time_example(n):
    """
    Zaman karmaşıklığı: O(log n)

    Çünkü her adımda problem yarıya düşürülür.

    Örnek:
        n = 16
        16 -> 8 -> 4 -> 2 -> 1

    16 eleman için sadece 4 adım yeterlidir.
    """

    step_count = 0

    while n > 1:
        n = n // 2
        step_count = step_count + 1

    return step_count


# O(n log n) - Doğrusal-logaritmik zaman
def n_log_n_example(n):
    """
    Zaman karmaşıklığı: O(n log n)

    Merge Sort gibi algoritmalarda görülür.

    Mantık:
        - Problem log n seviyeye kadar ikiye bölünür.
        - Her seviyede toplam n kadar işlem yapılır.

    Bu fonksiyon gerçek sıralama yapmaz.
    Sadece n log n mantığını göstermek için işlem sayısı simülasyonu yapar.
    """

    operation_count = 0
    size = n

    while size > 1:
        # Her seviyede n kadar işlem yapıldığını düşünelim
        for i in range(n):
            operation_count = operation_count + 1

        size = size // 2

    return operation_count


# O(2^n) - Üstel zaman
def exponential_time_example(n):
    """
    Zaman karmaşıklığı: O(2^n)

    Üstel zaman çok hızlı büyür.
    Örneğin bazı recursive problemler kötü yazılırsa O(2^n) olabilir.

    Bu örnekte Fibonacci sayısı saf recursive yöntemle hesaplanır.
    Bu yöntem verimsizdir çünkü aynı değerler tekrar tekrar hesaplanır.
    """

    if n <= 1:
        return n

    return exponential_time_example(n - 1) + exponential_time_example(n - 2)


# 2. OMEGA NOTASYONU: Ω( )

"""
Omega, algoritmanın en iyi durumda en az ne kadar işlem yapacağını gösterir.

Yani alt sınırdır.

Örnek:
    Linear search algoritmasında aranan eleman ilk sıradaysa
    algoritma hemen bulur.

    Bu durumda en iyi durum:
        Ω(1)

Ama eleman sonda olabilir veya hiç olmayabilir.
Bu durumda en kötü durum:
        O(n)
"""


def linear_search(arr, target):
    """
    Linear Search örneği.

    En iyi durum: Ω(1)
        Aranan eleman ilk sıradaysa tek kontrol yeterlidir.

    En kötü durum: O(n)
        Aranan eleman sondaysa veya yoksa tüm liste gezilir.
    """

    for i in range(len(arr)):
        if arr[i] == target:
            return i

    return -1


# 3. THETA NOTASYONU: Θ( )

"""
Theta, algoritmanın hem alt hem üst sınırını gösterir.

Yani algoritmanın büyüme hızı net olarak bellidir.

Bir algoritma Θ(n) ise:
    En iyi durumda da doğrusal,
    En kötü durumda da doğrusal davranır.

Örnek:
    Listedeki tüm elemanları yazdırmak veya toplamak.

Çünkü liste kaç elemanlıysa hepsine bakmak zorundasın.
"""


def theta_example_print_all(arr):
    """
    Zaman karmaşıklığı: Θ(n)

    Çünkü bu fonksiyon her durumda tüm elemanları gezer.
    İlk elemanda durma gibi bir durum yoktur.
    """

    for i in range(len(arr)):
        print(arr[i])


# 4. KÜÇÜK TERİMLERİ VE SABİTLERİ ATMA MANTIĞI


"""
Asimptotik analizde sabitler ihmal edilir.

Örnek:
    5n       -> O(n)
    100n     -> O(n)
    n + 50   -> O(n)

Çünkü n çok büyüdüğünde sabit sayıların etkisi önemsizleşir.

Ayrıca düşük dereceli terimler de atılır.

Örnek:
    n^2 + n + 10      -> O(n^2)
    n^3 + 20n^2 + 5  -> O(n^3)

Çünkü en hızlı büyüyen terim baskındır.
"""


def example_drop_constants(arr):
    """
    Bu fonksiyonda iki ayrı döngü var.

    İlk döngü: n kez çalışır.
    İkinci döngü: n kez çalışır.

    Toplam:
        n + n = 2n

    Ama sabit katsayı atılır:
        O(2n) -> O(n)
    """

    count = 0

    for i in range(len(arr)):
        count = count + 1

    for i in range(len(arr)):
        count = count + 1

    return count


def example_drop_lower_terms(arr):
    """
    Bu fonksiyonda:
        - Bir tane tekli döngü var: O(n)
        - Bir tane iç içe döngü var: O(n^2)

    Toplam:
        O(n + n^2)

    Baskın olan n^2 olduğu için:
        O(n + n^2) -> O(n^2)
    """

    count = 0

    # O(n)
    for i in range(len(arr)):
        count = count + 1

    # O(n^2)
    for i in range(len(arr)):
        for j in range(len(arr)):
            count = count + 1

    return count


# 5. KARMAŞIKLIK SIRALAMASI

"""
Genel olarak küçükten büyüğe karmaşıklık sıralaması:

    O(1)
    O(log n)
    O(n)
    O(n log n)
    O(n^2)
    O(n^3)
    O(2^n)
    O(n!)

En iyiler genelde:
    O(1), O(log n), O(n)

Orta seviye:
    O(n log n)

Daha maliyetli:
    O(n^2), O(n^3)

Çok kötü büyüyenler:
    O(2^n), O(n!)
"""


# 6. PROGRAMI ÇALIŞTIRMA BÖLÜMÜ

if __name__ == "__main__":
    numbers = [10, 20, 30, 40, 50]

    print("Liste:", numbers)
    print("--------------------------------")

    print("O(1) örneği - İlk eleman:", constant_time_example(numbers))
    print("O(n) örneği - Toplam:", linear_time_example(numbers))
    print("O(n^2) örneği - Çift sayısı:", quadratic_time_example(numbers))

    n = 16
    print("O(log n) örneği -", n, "için adım sayısı:", logarithmic_time_example(n))

    n = 8
    print("O(n log n) örneği - Yaklaşık işlem sayısı:", n_log_n_example(n))

    print("Linear Search - 30 elemanının indeksi:", linear_search(numbers, 30))

    print("Sabitleri atma örneği - İşlem sayısı:", example_drop_constants(numbers))
    print("Düşük terimleri atma örneği - İşlem sayısı:", example_drop_lower_terms(numbers))

    # Fibonacci örneğinde büyük n değeri vermemeye dikkat et.
    # Çünkü O(2^n) çok hızlı büyür.
    fib_n = 6
    print("O(2^n) Fibonacci örneği - fib(", fib_n, "):", exponential_time_example(fib_n))
