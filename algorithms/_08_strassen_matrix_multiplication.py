# 1. YARDIMCI FONKSİYONLAR
"""
KARMAŞIKLIK ÖZETİ:
Normal yöntem: O(n³)
Klasik Divide & Conquer: O(n³)
Strassen algoritması: O(n^log₂7) ≈ O(n².81)
"""

def is_valid_matrix(matrix):
    """
    Matrisin geçerli olup olmadığını kontrol eder.

    Geçerli matris:
        - Boş olmamalı
        - Satırlar boş olmamalı
        - Her satır aynı uzunlukta olmalı
    """

    if len(matrix) == 0:
        return False

    if len(matrix[0]) == 0:
        return False

    column_count = len(matrix[0])

    for i in range(len(matrix)):
        if len(matrix[i]) != column_count:
            return False

    return True


def create_zero_matrix(row_count, column_count):
    """
    Verilen satır ve sütun sayısına göre sıfır matrisi oluşturur.
    """

    matrix = []

    for i in range(row_count):
        row = []

        for j in range(column_count):
            row.append(0)

        matrix.append(row)

    return matrix


def print_matrix(matrix):
    """
    Matrisi ekrana okunabilir şekilde yazdırır.
    """

    for i in range(len(matrix)):
        print(matrix[i])


def next_power_of_two(number):
    """
    Verilen sayıdan büyük veya ona eşit en küçük 2'nin kuvvetini bulur.

    Strassen algoritması, matrisleri sürekli ikiye böldüğü için
    boyutun 2'nin kuvveti olması işi kolaylaştırır.
    """

    power = 1

    while power < number:
        power = power * 2

    return power


def pad_matrix(matrix, new_size):
    """
    Matrisi new_size x new_size boyutuna sıfırlarla genişletir.
    """

    padded = create_zero_matrix(new_size, new_size)

    for i in range(len(matrix)):
        for j in range(len(matrix[0])):
            padded[i][j] = matrix[i][j]

    return padded


def crop_matrix(matrix, row_count, column_count):
    """
    Genişletilmiş sonucu gerçek boyuta geri kırpar.
    """

    cropped = []

    for i in range(row_count):
        row = []

        for j in range(column_count):
            row.append(matrix[i][j])

        cropped.append(row)

    return cropped


def add_matrices(A, B):
    """
    İki matrisi toplar.

    C = A + B
    """

    row_count = len(A)
    column_count = len(A[0])

    C = create_zero_matrix(row_count, column_count)

    for i in range(row_count):
        for j in range(column_count):
            C[i][j] = A[i][j] + B[i][j]

    return C


def subtract_matrices(A, B):
    """
    İki matrisi çıkarır.

    C = A - B
    """

    row_count = len(A)
    column_count = len(A[0])

    C = create_zero_matrix(row_count, column_count)

    for i in range(row_count):
        for j in range(column_count):
            C[i][j] = A[i][j] - B[i][j]

    return C


def split_matrix(matrix):
    """
    Kare matrisi 4 alt parçaya böler.

    A matrisi şu şekilde parçalanır:

        A11 | A12
        ----+----
        A21 | A22
    """

    n = len(matrix)
    middle = n // 2

    A11 = create_zero_matrix(middle, middle)
    A12 = create_zero_matrix(middle, middle)
    A21 = create_zero_matrix(middle, middle)
    A22 = create_zero_matrix(middle, middle)

    for i in range(middle):
        for j in range(middle):
            A11[i][j] = matrix[i][j]
            A12[i][j] = matrix[i][j + middle]
            A21[i][j] = matrix[i + middle][j]
            A22[i][j] = matrix[i + middle][j + middle]

    return A11, A12, A21, A22


def combine_quadrants(C11, C12, C21, C22):
    """
    4 alt matrisi tekrar tek kare matris haline getirir.

        C11 | C12
        ----+----
        C21 | C22
    """

    middle = len(C11)
    n = middle * 2

    C = create_zero_matrix(n, n)

    for i in range(middle):
        for j in range(middle):
            C[i][j] = C11[i][j]
            C[i][j + middle] = C12[i][j]
            C[i + middle][j] = C21[i][j]
            C[i + middle][j + middle] = C22[i][j]

    return C


# 2. NORMAL MATRİS ÇARPIMI


"""
Normal matris çarpımı üç iç içe döngü ile yapılır.

A matrisi: m x n
B matrisi: n x p

Sonuç:
    C matrisi: m x p

Zaman karmaşıklığı:
    O(n^3)

Bu fonksiyon Strassen sonucunu kontrol etmek için de kullanılır.
"""


def multiply_normal(A, B):
    """
    Normal yöntemle matris çarpımı.
    """

    if not is_valid_matrix(A):
        raise ValueError("A matrisi geçerli değil.")

    if not is_valid_matrix(B):
        raise ValueError("B matrisi geçerli değil.")

    A_rows = len(A)
    A_columns = len(A[0])

    B_rows = len(B)
    B_columns = len(B[0])

    if A_columns != B_rows:
        raise ValueError("Matris boyutları çarpma için uygun değil.")

    C = create_zero_matrix(A_rows, B_columns)

    for i in range(A_rows):
        for j in range(B_columns):
            total = 0

            for k in range(A_columns):
                total = total + A[i][k] * B[k][j]

            C[i][j] = total

    return C


# 3. STRASSEN ALGORİTMASI


"""
Strassen algoritması da Divide & Conquer yaklaşımıdır.

Klasik Divide & Conquer matris çarpımında 8 recursive çarpma yapılır.

Strassen algoritması ise 8 çarpma yerine 7 çarpma yapar.
Buna karşılık daha fazla toplama ve çıkarma işlemi kullanır.

Klasik yöntem:
    T(n) = 8T(n / 2) + O(n^2)
    Sonuç: O(n^3)

Strassen yöntemi:
    T(n) = 7T(n / 2) + O(n^2)
    Sonuç: O(n^log2(7))
    Yaklaşık: O(n^2.81)

Strassen formülleri:

    M1 = (A11 + A22) * (B11 + B22)
    M2 = (A21 + A22) * B11
    M3 = A11 * (B12 - B22)
    M4 = A22 * (B21 - B11)
    M5 = (A11 + A12) * B22
    M6 = (A21 - A11) * (B11 + B12)
    M7 = (A12 - A22) * (B21 + B22)

Sonuç parçaları:

    C11 = M1 + M4 - M5 + M7
    C12 = M3 + M5
    C21 = M2 + M4
    C22 = M1 - M2 + M3 + M6
"""


def multiply_strassen(A, B):
    """
    Strassen algoritması ile matris çarpımı yapar.

    Bu dış fonksiyon:
        - Matris geçerliliğini kontrol eder.
        - Boyutları kontrol eder.
        - Matrisleri 2'nin kuvveti kare boyuta genişletir.
        - Recursive Strassen fonksiyonunu çağırır.
        - Sonucu gerçek boyuta geri kırpar.
    """

    if not is_valid_matrix(A):
        raise ValueError("A matrisi geçerli değil.")

    if not is_valid_matrix(B):
        raise ValueError("B matrisi geçerli değil.")

    A_rows = len(A)
    A_columns = len(A[0])

    B_rows = len(B)
    B_columns = len(B[0])

    if A_columns != B_rows:
        raise ValueError("Matris boyutları çarpma için uygun değil.")

    # Strassen için kare ve 2'nin kuvveti olan bir boyut seçilir.
    max_size = A_rows

    if A_columns > max_size:
        max_size = A_columns

    if B_rows > max_size:
        max_size = B_rows

    if B_columns > max_size:
        max_size = B_columns

    new_size = next_power_of_two(max_size)

    padded_A = pad_matrix(A, new_size)
    padded_B = pad_matrix(B, new_size)

    padded_C = strassen_recursive(padded_A, padded_B)

    # Gerçek sonuç boyutu A_rows x B_columns olur.
    C = crop_matrix(padded_C, A_rows, B_columns)

    return C


def strassen_recursive(A, B):
    """
    Recursive Strassen algoritması.

    Matrislerin kare ve boyutunun 2'nin kuvveti olduğu varsayılır.
    """

    n = len(A)

    # Temel durum:
    # 1x1 matris çarpımı doğrudan yapılır.
    if n == 1:
        C = create_zero_matrix(1, 1)
        C[0][0] = A[0][0] * B[0][0]
        return C

    A11, A12, A21, A22 = split_matrix(A)
    B11, B12, B21, B22 = split_matrix(B)

    # Strassen algoritmasının 7 özel çarpımı:

    M1 = strassen_recursive(
        add_matrices(A11, A22),
        add_matrices(B11, B22)
    )

    M2 = strassen_recursive(
        add_matrices(A21, A22),
        B11
    )

    M3 = strassen_recursive(
        A11,
        subtract_matrices(B12, B22)
    )

    M4 = strassen_recursive(
        A22,
        subtract_matrices(B21, B11)
    )

    M5 = strassen_recursive(
        add_matrices(A11, A12),
        B22
    )

    M6 = strassen_recursive(
        subtract_matrices(A21, A11),
        add_matrices(B11, B12)
    )

    M7 = strassen_recursive(
        subtract_matrices(A12, A22),
        add_matrices(B21, B22)
    )

    # Sonuç matrisinin 4 parçası hesaplanır.

    # C11 = M1 + M4 - M5 + M7
    C11_temp_1 = add_matrices(M1, M4)
    C11_temp_2 = subtract_matrices(C11_temp_1, M5)
    C11 = add_matrices(C11_temp_2, M7)

    # C12 = M3 + M5
    C12 = add_matrices(M3, M5)

    # C21 = M2 + M4
    C21 = add_matrices(M2, M4)

    # C22 = M1 - M2 + M3 + M6
    C22_temp_1 = subtract_matrices(M1, M2)
    C22_temp_2 = add_matrices(C22_temp_1, M3)
    C22 = add_matrices(C22_temp_2, M6)

    C = combine_quadrants(C11, C12, C21, C22)

    return C


# 4. SONUÇ KONTROLÜ

def are_matrices_equal(A, B):
    """
    İki matrisin aynı olup olmadığını kontrol eder.
    """

    if len(A) != len(B):
        return False

    if len(A[0]) != len(B[0]):
        return False

    for i in range(len(A)):
        for j in range(len(A[0])):
            if A[i][j] != B[i][j]:
                return False

    return True


# 5. PROGRAMI ÇALIŞTIRMA BÖLÜMÜ

if __name__ == "__main__":
    print("STRASSEN MATRİS ÇARPMA ALGORİTMASI")
    print("----------------------------------")

    A = [
        [1, 2, 3],
        [4, 5, 6]
    ]

    B = [
        [7, 8],
        [9, 10],
        [11, 12]
    ]

    print("\nA matrisi:")
    print_matrix(A)

    print("\nB matrisi:")
    print_matrix(B)

    print("\n1) Normal matris çarpımı sonucu:")
    normal_result = multiply_normal(A, B)
    print_matrix(normal_result)

    print("\n2) Strassen algoritması sonucu:")
    strassen_result = multiply_strassen(A, B)
    print_matrix(strassen_result)

    print("\nSonuçlar aynı mı?")
    print(are_matrices_equal(normal_result, strassen_result))

    print("\nKarmaşıklık karşılaştırması:")
    print("Normal yöntem: O(n^3)")
    print("Klasik Divide & Conquer: O(n^3)")
    print("Strassen algoritması: O(n^log2(7)) ≈ O(n^2.81)")

    print("\nÖzet:")
    print("Strassen algoritması 8 recursive çarpma yerine 7 recursive çarpma yapar.")
    print("Bu yüzden büyük matrislerde teorik olarak klasik yöntemden daha hızlıdır.")
