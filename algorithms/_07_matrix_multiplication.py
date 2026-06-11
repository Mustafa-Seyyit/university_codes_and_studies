# 1. YARDIMCI FONKSİYONLAR

def is_valid_matrix(matrix):
    """
    Matrisin geçerli olup olmadığını kontrol eder.

    Geçerli matris:
        - Boş olmamalı
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
    Matrisi ekrana daha düzgün yazdırır.
    """

    for i in range(len(matrix)):
        print(matrix[i])


def next_power_of_two(number):
    """
    Verilen sayıdan büyük veya ona eşit en küçük 2'nin kuvvetini bulur.

    Örnek:
        3  -> 4
        5  -> 8
        8  -> 8
        10 -> 16

    Divide & Conquer yöntemi için matris boyutunu uygun hale getirir.
    """

    power = 1

    while power < number:
        power = power * 2

    return power


def pad_matrix(matrix, new_size):
    """
    Matrisi new_size x new_size boyutuna sıfırlarla genişletir.

    Örnek:
        2x3 matris, 4x4 matrise çevrilebilir.
        Eksik yerlere 0 yazılır.
    """

    padded = create_zero_matrix(new_size, new_size)

    for i in range(len(matrix)):
        for j in range(len(matrix[0])):
            padded[i][j] = matrix[i][j]

    return padded


def crop_matrix(matrix, row_count, column_count):
    """
    Genişletilmiş matrisi gerçek sonuç boyutuna geri kırpar.
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

    Matrislerin aynı boyutta olduğu varsayılır.
    """

    row_count = len(A)
    column_count = len(A[0])

    C = create_zero_matrix(row_count, column_count)

    for i in range(row_count):
        for j in range(column_count):
            C[i][j] = A[i][j] + B[i][j]

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


# 2. NORMAL MATRİS ÇARPMA YÖNTEMİ

"""
Normal matris çarpımı:

A matrisi: m x n
B matrisi: n x p

Sonuç matrisi:
    C = A x B
    C boyutu = m x p

Formül:
    C[i][j] = A[i][0] * B[0][j]
            + A[i][1] * B[1][j]
            + ...
            + A[i][n-1] * B[n-1][j]

Zaman karmaşıklığı:
    O(m * n * p)

Eğer kare matrislerde n x n çarpım yapılıyorsa:
    O(n^3)
"""


def multiply_normal(A, B):
    """
    Normal yöntemle matris çarpımı yapar.
    """

    if not is_valid_matrix(A):
        raise ValueError("A matrisi geçerli değil.")

    if not is_valid_matrix(B):
        raise ValueError("B matrisi geçerli değil.")

    A_rows = len(A)
    A_columns = len(A[0])

    B_rows = len(B)
    B_columns = len(B[0])

    # Matris çarpımı için A'nın sütun sayısı,
    # B'nin satır sayısına eşit olmalıdır.
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


# 3. DIVIDE & CONQUER MATRİS ÇARPMA YÖNTEMİ

"""
Divide & Conquer ile matris çarpımı:

A ve B matrisleri 4 parçaya bölünür:

    A = A11 | A12
        ----+----
        A21 | A22

    B = B11 | B12
        ----+----
        B21 | B22

Sonuç matrisi C de 4 parçadan oluşur:

    C11 = A11*B11 + A12*B21
    C12 = A11*B12 + A12*B22
    C21 = A21*B11 + A22*B21
    C22 = A21*B12 + A22*B22

Dikkat:
    Burada Strassen algoritması kullanılmaz.

Strassen olsaydı 7 recursive çarpma kullanılırdı.
Bu klasik Divide & Conquer yönteminde 8 recursive çarpma yapılır.

Yineleme bağıntısı:
    T(n) = 8T(n / 2) + O(n^2)

Master Theorem sonucu:
    T(n) = O(n^3)
"""


def multiply_divide_and_conquer(A, B):
    """
    Divide & Conquer yöntemiyle matris çarpımı yapar.

    Bu fonksiyon farklı boyutlardaki uyumlu matrisleri de desteklemek için
    önce matrisleri sıfırlarla kare ve 2'nin kuvveti boyuta genişletir.

    Sonra sonucu gerçek boyuta geri kırpar.
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

    # Divide & Conquer için tek bir kare boyut seçiyoruz.
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

    padded_C = multiply_divide_and_conquer_recursive(padded_A, padded_B)

    # Gerçek sonuç boyutu: A_rows x B_columns
    C = crop_matrix(padded_C, A_rows, B_columns)

    return C


def multiply_divide_and_conquer_recursive(A, B):
    """
    Recursive klasik Divide & Conquer matris çarpımı.

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

    # Klasik Divide & Conquer:
    # Her C parçası için 2 çarpma gerekir.
    # Toplamda 8 recursive çarpma yapılır.

    C11_left = multiply_divide_and_conquer_recursive(A11, B11)
    C11_right = multiply_divide_and_conquer_recursive(A12, B21)
    C11 = add_matrices(C11_left, C11_right)

    C12_left = multiply_divide_and_conquer_recursive(A11, B12)
    C12_right = multiply_divide_and_conquer_recursive(A12, B22)
    C12 = add_matrices(C12_left, C12_right)

    C21_left = multiply_divide_and_conquer_recursive(A21, B11)
    C21_right = multiply_divide_and_conquer_recursive(A22, B21)
    C21 = add_matrices(C21_left, C21_right)

    C22_left = multiply_divide_and_conquer_recursive(A21, B12)
    C22_right = multiply_divide_and_conquer_recursive(A22, B22)
    C22 = add_matrices(C22_left, C22_right)

    C = combine_quadrants(C11, C12, C21, C22)

    return C


# 4. SONUÇLARI KARŞILAŞTIRMA

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
    print("MATRİS ÇARPMA PROBLEMİ")
    print("----------------------")

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

    print("\n1) Normal yöntem sonucu:")
    normal_result = multiply_normal(A, B)
    print_matrix(normal_result)

    print("\n2) Divide & Conquer yöntemi sonucu:")
    divide_conquer_result = multiply_divide_and_conquer(A, B)
    print_matrix(divide_conquer_result)

    print("\nSonuçlar aynı mı?")
    print(are_matrices_equal(normal_result, divide_conquer_result))

    print("\nKarmaşıklık karşılaştırması:")
    print("Normal yöntem: O(n^3)")
    print("Divide & Conquer, Strassen olmadan: O(n^3)")
    print("Strassen kullanılmadığı için teorik zaman karmaşıklığı iyileşmez.")
    print("Ama Divide & Conquer mantığını anlamak için önemlidir.")
