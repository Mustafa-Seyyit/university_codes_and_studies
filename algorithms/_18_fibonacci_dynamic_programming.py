
# 1. NORMAL RECURSIVE YÖNTEM

"""
Normal recursive Fibonacci yöntemi doğrudan matematiksel tanımı uygular.

Örnek:
    fib(5) = fib(4) + fib(3)

Ama burada aynı değerler tekrar tekrar hesaplanır.

Örneğin:
    fib(5)
        fib(4)
            fib(3)
            fib(2)
        fib(3)
            fib(2)
            fib(1)

Görüldüğü gibi fib(3), fib(2) gibi değerler tekrar hesaplanır.

Yineleme bağıntısı:
    T(n) = T(n - 1) + T(n - 2) + O(1)

Zaman karmaşıklığı:
    O(2^n)

Bellek karmaşıklığı:
    O(n)
    Çünkü recursive çağrı derinliği en fazla n olur.
"""


def fibonacci_recursive(n):
    """
    Normal recursive yöntemle Fibonacci hesaplar.

    Parametre:
        n: Fibonacci dizisindeki indeks

    Geri dönüş:
        F(n) değeri
    """

    if n < 0:
        return None

    if n == 0:
        return 0

    if n == 1:
        return 1

    return fibonacci_recursive(n - 1) + fibonacci_recursive(n - 2)


# 2. DİNAMİK PROGRAMLAMA YÖNTEMİ

"""
Dinamik Programlama yaklaşımında küçük problemlerin sonuçları saklanır.

Bu örnekte Tabulation yöntemi kullanılmıştır.

Tabulation:
    - Aşağıdan yukarıya doğru çözüm yapılır.
    - Önce fib(0), fib(1) bilinir.
    - Sonra fib(2), fib(3), ... fib(n) hesaplanır.
    - Hesaplanan değerler dp listesinde saklanır.

DP tablosu örneği:

    n = 6

    indeks: 0  1  2  3  4  5  6
    değer: 0  1  1  2  3  5  8

Yineleme:
    dp[i] = dp[i - 1] + dp[i - 2]

Zaman karmaşıklığı:
    O(n)

Bellek karmaşıklığı:
    O(n)
"""


def fibonacci_dp(n):
    """
    Dinamik programlama yöntemiyle Fibonacci hesaplar.

    Parametre:
        n: Fibonacci dizisindeki indeks

    Geri dönüş:
        F(n) değeri
    """

    if n < 0:
        return None

    if n == 0:
        return 0

    if n == 1:
        return 1

    # dp[i], F(i) değerini tutar.
    dp = []

    # Listeyi n + 1 uzunluğunda 0 ile dolduruyoruz.
    for i in range(n + 1):
        dp.append(0)

    dp[0] = 0
    dp[1] = 1

    for i in range(2, n + 1):
        dp[i] = dp[i - 1] + dp[i - 2]

    return dp[n]


# 3. DP TABLOSUNU GÖSTERME

def print_fibonacci_dp_table(n):
    """
    Fibonacci DP tablosunu ekrana yazdırır.

    Amaç:
        Dinamik programlamada değerlerin nasıl saklandığını göstermek.
    """

    if n < 0:
        print("Negatif indeks için Fibonacci hesaplanmaz.")
        return

    dp = []

    for i in range(n + 1):
        dp.append(0)

    if n >= 1:
        dp[1] = 1

    for i in range(2, n + 1):
        dp[i] = dp[i - 1] + dp[i - 2]

    print("DP Tablosu")
    print("----------")

    print("İndeksler:")
    for i in range(n + 1):
        print(i, end=" ")

    print("\nDeğerler:")
    for i in range(n + 1):
        print(dp[i], end=" ")

    print()


# 4. FIBONACCI DİZİSİNİ YAZDIRMA

def print_fibonacci_series(n):
    """
    0'dan n'e kadar Fibonacci değerlerini yazdırır.

    Örnek:
        n = 6

        0 1 1 2 3 5 8
    """

    print("Fibonacci dizisi:")

    for i in range(n + 1):
        print(fibonacci_dp(i), end=" ")

    print()


# 5. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    n = 10

    print("FIBONACCI DİZİSİ")
    print("================")

    print("n değeri:", n)

    print("\n1) Normal Recursive Yöntem")
    recursive_result = fibonacci_recursive(n)
    print("F(", n, ") =", recursive_result)

    print("\n2) Dinamik Programlama Yöntemi")
    dp_result = fibonacci_dp(n)
    print("F(", n, ") =", dp_result)

    print("\nSonuçlar aynı mı?")
    if recursive_result == dp_result:
        print("Evet, iki yöntem de aynı sonucu verdi.")
    else:
        print("Hayır, sonuçlar farklı.")

    print("\n")
    print_fibonacci_dp_table(n)

    print("\n")
    print_fibonacci_series(n)

    print("\nKarmaşıklık Karşılaştırması")
    print("---------------------------")
    print("Normal Recursive Yöntem")
    print("Zaman karmaşıklığı : O(2^n)")
    print("Bellek karmaşıklığı: O(n)")

    print("\nDinamik Programlama Yöntemi")
    print("Zaman karmaşıklığı : O(n)")
    print("Bellek karmaşıklığı: O(n)")

    print("\nÖzet")
    print("Normal recursive yöntem aynı alt problemleri tekrar hesaplar.")
    print("DP yöntemi sonuçları tabloda sakladığı için çok daha verimlidir.")
