
# 1. ALGORİTMA

"""
mantık:

Alg1(A[1...n])
    if n <= 0:
        return
    q = floor(n / 2)

    if q is even:
        Alg1(A[1...q])
    else:
        Alg1(A[q+1...n])

Yineleme bağıntısı:
    T(n) = T(n / 2) + Θ(1)

Sonuç:
    T(n) = Θ(log n)
"""


def alg1(A, left, right):
    """
    algoritmanın Python karşılığı.

    Parametreler:
        A: Liste
        left: Başlangıç indeksi
        right: Bitiş indeksi

    Python'da aralık:
        A[left ... right]
    """

    n = right - left + 1

    # Eğer eleman yoksa dur
    if n <= 0:
        return

    q = n // 2

    print("Alg1 çalıştı -> aralık:", left, "-", right, "n:", n, "q:", q)

    # q çift ise sol yarıya git
    if q % 2 == 0:
        alg1(A, left, left + q - 1)

    # q tek ise sağ yarıya git
    else:
        alg1(A, left + q, right)


# 2. ALGORİTMA

"""
mantık:

Alg2(A[1...n])
    if n <= 0:
        return

    q = floor(n / 4)

    if q is even:
        Alg2(A[1...q])
        Alg2(A[q+1...2q])
    else:
        Alg2(A[2q+1...3q])
        Alg2(A[3q+1...n])

Yineleme bağıntısı:
    T(n) = 2T(n / 4) + Θ(1)

Master Theorem:
    a = 2
    b = 4
    f(n) = Θ(1)

Sonuç:
    T(n) = Θ(n^(log_4 2))
    T(n) = Θ(n^(1/2))
    T(n) = Θ(sqrt(n))
"""


def alg2(A, left, right):
    """
    algoritmanın Python karşılığı.

    Parametreler:
        A: Liste
        left: Başlangıç indeksi
        right: Bitiş indeksi
    """

    n = right - left + 1

    # Eğer eleman yoksa dur
    if n <= 0:
        return

    q = n // 4

    print("Alg2 çalıştı -> aralık:", left, "-", right, "n:", n, "q:", q)

    # q = 0 olursa alt aralıklar boş veya aynı kalabilir.
    # Sonsuz recursive çağrıyı önlemek için durduruyoruz.
    if q == 0:
        return

    # q çift ise ilk iki çeyrek üzerinde çalış
    if q % 2 == 0:
        alg2(A, left, left + q - 1)
        alg2(A, left + q, left + 2 * q - 1)

    # q tek ise üçüncü ve dördüncü kısım üzerinde çalış
    else:
        alg2(A, left + 2 * q, left + 3 * q - 1)
        alg2(A, left + 3 * q, right)


# 3. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":
    A = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16]

    print("Liste:")
    print(A)

    print("\n1. Algoritma")
    print("-------------")
    alg1(A, 0, len(A) - 1)

    print("\n2. Algoritma")
    print("-------------")
    alg2(A, 0, len(A) - 1)

    print("\nKarmaşıklıklar")
    print("Alg1: T(n) = T(n/2) + Θ(1)  -> Θ(log n)")
    print("Alg2: T(n) = 2T(n/4) + Θ(1) -> Θ(sqrt(n))")
