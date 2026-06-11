"""
    Matris Zinciri Çarpımı (Matrix Chain Multiplication)

Amaç:
    Birden fazla matrisin hangi sırayla çarpılırsa
    en az skaler çarpma maliyeti oluşacağını bulmak.

Önemli:
    Bu problem matrisleri gerçekten çarpmaz.
    Sadece en düşük çarpma maliyetini ve en iyi parantezleme sırasını bulur.

Örnek:
    A1 boyutu: 10 x 30
    A2 boyutu: 30 x 5
    A3 boyutu: 5 x 60

Boyut dizisi:
    dimensions = [10, 30, 5, 60]

Burada:
    A1 = 10 x 30
    A2 = 30 x 5
    A3 = 5 x 60

"""

# 1. MATRİS ZİNCİRİ ÇARPIMI NEDİR?

"""
Matris çarpımında işlem sırası sonucu değiştirmez,
ama işlem maliyetini değiştirir.

Örnek:
    A1 x A2 x A3

İki farklı parantezleme olabilir:

    1. (A1 x A2) x A3
    2. A1 x (A2 x A3)

Sonuç matrisi aynı olur.
Ama yapılan skaler çarpma sayısı farklı olabilir.

Amaç:
    En az maliyetli parantezlemeyi bulmak.
"""


# 2. DP MANTIĞI

"""
m[i][j]:
    Ai'den Aj'ye kadar olan matrisleri çarpmak için
    gereken minimum skaler çarpma maliyetini tutar.

s[i][j]:
    En iyi bölme noktasını tutar.
    Yani Ai...Aj zinciri en iyi hangi k noktasından bölünür?

Formül:
    m[i][j] = min(
        m[i][k] + m[k+1][j] + p[i-1] * p[k] * p[j]
    )

Burada:
    i <= k < j

p dizisi dimensions dizisidir.

Eğer:
    A1 = 10 x 30
    A2 = 30 x 5
    A3 = 5 x 60

dimensions:
    [10, 30, 5, 60]

A_i boyutu:
    dimensions[i-1] x dimensions[i]
"""


# 3. YARDIMCI FONKSİYONLAR

def create_matrix(row_count, column_count, default_value):
    """
    Verilen boyutta matris oluşturur.

    Parametreler:
        row_count     : satır sayısı
        column_count  : sütun sayısı
        default_value : başlangıç değeri
    """

    matrix = []

    for i in range(row_count):
        row = []

        for j in range(column_count):
            row.append(default_value)

        matrix.append(row)

    return matrix


def print_table(table, title):
    """
    DP tablolarını ekrana yazdırmak için kullanılır.
    """

    print(title)
    print("-" * len(title))

    for i in range(len(table)):
        for j in range(len(table[i])):
            print(table[i][j], end="\t")
        print()

    print()


# 4. MATRIX CHAIN MULTIPLICATION DP

def matrix_chain_order(dimensions):
    """
    Matris zinciri çarpımı için minimum maliyeti hesaplar.

    Parametre:
        dimensions:
            Matris boyutlarını tutan liste.

            Eğer n tane matris varsa dimensions uzunluğu n + 1 olur.

            Örnek:
                dimensions = [10, 30, 5, 60]

                A1 = 10 x 30
                A2 = 30 x 5
                A3 = 5 x 60

    Geri dönüş:
        m tablosu:
            minimum maliyetler

        s tablosu:
            en iyi bölme noktaları
    """

    matrix_count = len(dimensions) - 1

    # m tablosu maliyetleri tutar.
    # 1 tabanlı indeksleme mantığını korumak için n+1 boyutlu oluşturuyoruz.
    m = create_matrix(matrix_count + 1, matrix_count + 1, 0)

    # s tablosu bölme noktalarını tutar.
    s = create_matrix(matrix_count + 1, matrix_count + 1, 0)

    # chain_length zincirde kaç matris olduğunu gösterir.
    # 2'den başlar çünkü tek matrisin maliyeti 0'dır.
    for chain_length in range(2, matrix_count + 1):

        # i başlangıç matrisi
        for i in range(1, matrix_count - chain_length + 2):

            # j bitiş matrisi
            j = i + chain_length - 1

            # Başlangıç için çok büyük bir sayı veriyoruz.
            # min() kullanmamak için manuel karşılaştırma yapacağız.
            m[i][j] = 999999999

            # k bölme noktasıdır.
            # Ai...Ak ve A(k+1)...Aj olarak ikiye böler.
            for k in range(i, j):

                cost = (
                    m[i][k]
                    + m[k + 1][j]
                    + dimensions[i - 1] * dimensions[k] * dimensions[j]
                )

                if cost < m[i][j]:
                    m[i][j] = cost
                    s[i][j] = k

    return m, s


# 5. EN İYİ PARANTEZLEMEYİ YAZDIRMA

def print_optimal_parenthesization(s, i, j):
    """
    En iyi parantezleme sırasını ekrana yazdırır.

    Örnek çıktı:
        ((A1 x A2) x A3)
    """

    if i == j:
        print("A" + str(i), end="")
    else:
        print("(", end="")

        k = s[i][j]

        print_optimal_parenthesization(s, i, k)
        print(" x ", end="")
        print_optimal_parenthesization(s, k + 1, j)

        print(")", end="")


def get_optimal_parenthesization(s, i, j):
    """
    En iyi parantezlemeyi string olarak döndürür.

    GitHub çıktısı veya test için daha kullanışlıdır.
    """

    if i == j:
        return "A" + str(i)

    k = s[i][j]

    left = get_optimal_parenthesization(s, i, k)
    right = get_optimal_parenthesization(s, k + 1, j)

    return "(" + left + " x " + right + ")"


# 6. MATRİS BOYUTLARINI YAZDIRMA

def print_matrix_dimensions(dimensions):
    """
    dimensions dizisine göre matrislerin boyutlarını yazdırır.
    """

    matrix_count = len(dimensions) - 1

    print("Matris boyutları:")
    for i in range(1, matrix_count + 1):
        print("A" + str(i), "=", dimensions[i - 1], "x", dimensions[i])


# 7. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    print("MATRIX CHAIN MULTIPLICATION - DP")
    print("================================")

    # Örnek:
    # A1 = 30 x 35
    # A2 = 35 x 15
    # A3 = 15 x 5
    # A4 = 5 x 10
    # A5 = 10 x 20
    # A6 = 20 x 25
    dimensions = [30, 35, 15, 5, 10, 20, 25]

    print_matrix_dimensions(dimensions)

    m, s = matrix_chain_order(dimensions)

    matrix_count = len(dimensions) - 1

    print("\nMinimum çarpım maliyeti:")
    print(m[1][matrix_count])

    print("\nEn iyi parantezleme:")
    print_optimal_parenthesization(s, 1, matrix_count)

    print("\n\nEn iyi parantezleme string olarak:")
    parenthesization = get_optimal_parenthesization(s, 1, matrix_count)
    print(parenthesization)

    print("\nDP Maliyet Tablosu m:")
    print_table(m, "m tablosu")

    print("Bölme Noktası Tablosu s:")
    print_table(s, "s tablosu")

    print("Karmaşıklık")
    print("-----------")
    print("Zaman karmaşıklığı : O(n^3)")
    print("Bellek karmaşıklığı: O(n^2)")

    print("\nÖzet")
    print("Bu algoritma matrisleri gerçekten çarpmaz.")
    print("Sadece en az skaler çarpma maliyetini ve en iyi parantezlemeyi bulur.")
    print("Dinamik programlama kullanılır çünkü aynı alt problemler tekrar tekrar oluşur.")
