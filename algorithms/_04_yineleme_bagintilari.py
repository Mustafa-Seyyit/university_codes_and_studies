
# 1. T(n) = T(n - 1) + 1

"""
Bu bağıntı genellikle her adımda problem boyutunun 1 azaldığı
recursive yapılarda görülür.

T(n) = T(n - 1) + 1

Açılım:

    T(n)     = T(n - 1) + 1
    T(n - 1) = T(n - 2) + 1
    T(n - 2) = T(n - 3) + 1

Yerine koyarsak:

    T(n) = T(n - 2) + 2
    T(n) = T(n - 3) + 3
    ...
    T(n) = T(1) + (n - 1)

Sonuç:
    T(n) = Θ(n)
"""


def recurrence_decrease_by_one(n):
    """
    T(n) = T(n - 1) + 1 örneği.

    Bu fonksiyon n değerini 1'e kadar azaltır.
    Her recursive çağrıda 1 işlem sayar.

    Zaman karmaşıklığı:
        Θ(n)
    """

    if n <= 1:
        return 1

    return recurrence_decrease_by_one(n - 1) + 1


# 2. T(n) = T(n - 1) + n

"""
Bu bağıntıda problem her seferinde 1 azalır ama her seviyede n kadar
iş yapılır.

T(n) = T(n - 1) + n

Açılım:

    T(n) = T(n - 1) + n
    T(n) = T(n - 2) + (n - 1) + n
    T(n) = T(n - 3) + (n - 2) + (n - 1) + n

Toplam:

    1 + 2 + 3 + ... + n

Bu toplam yaklaşık n^2 büyür.

Sonuç:
    T(n) = Θ(n^2)
"""


def recurrence_decrease_by_one_with_n_work(n):
    """
    T(n) = T(n - 1) + n örneği.

    Her seviyede n kadar iş yapıldığını varsayıyoruz.
    Bu yüzden sonuç yaklaşık karesel büyür.

    Zaman karmaşıklığı:
        Θ(n^2)
    """

    if n <= 1:
        return 1

    current_level_work = 0

    # Bu döngü n kadar işi temsil eder
    for i in range(n):
        current_level_work = current_level_work + 1

    return recurrence_decrease_by_one_with_n_work(n - 1) + current_level_work


# 3. T(n) = T(n / 2) + 1

"""
Bu bağıntı problem boyutunun her adımda yarıya indiği algoritmalarda görülür.

Örnek:
    Binary Search

T(n) = T(n / 2) + 1

Açılım:

    n
    n / 2
    n / 4
    n / 8
    ...
    1

Kaç kere ikiye bölersek 1'e ulaşırız?

    log2(n) kere

Sonuç:
    T(n) = Θ(log n)
"""


def recurrence_divide_by_two(n):
    """
    T(n) = T(n / 2) + 1 örneği.

    Her adımda n ikiye bölünür.
    Bu yüzden logaritmik büyüme vardır.

    Zaman karmaşıklığı:
        Θ(log n)
    """

    if n <= 1:
        return 1

    return recurrence_divide_by_two(n // 2) + 1


def binary_search_recursive(arr, target, left, right):
    """
    Binary Search recursive örneği.

    Yineleme bağıntısı:
        T(n) = T(n / 2) + 1

    Çünkü her karşılaştırmadan sonra arama alanı yarıya iner.

    Zaman karmaşıklığı:
        Θ(log n)

    Not:
        Listenin önceden sıralı olduğu varsayılır.
    """

    if left > right:
        return -1

    middle = (left + right) // 2

    if arr[middle] == target:
        return middle
    elif target < arr[middle]:
        return binary_search_recursive(arr, target, left, middle - 1)
    else:
        return binary_search_recursive(arr, target, middle + 1, right)


# 4. T(n) = 2T(n / 2) + n

"""
Bu bağıntı Merge Sort algoritmasının temelidir.

T(n) = 2T(n / 2) + n

Anlamı:
    - Problem iki parçaya bölünür.
    - Her parça n / 2 boyutundadır.
    - Birleştirme işlemi n kadar sürer.

Merge Sort için:

    Bölme seviyesi sayısı: log n
    Her seviyedeki toplam iş: n

Sonuç:
    T(n) = Θ(n log n)
"""


def merge_sort(arr):
    """
    Merge Sort algoritması.

    Yineleme bağıntısı:
        T(n) = 2T(n / 2) + n

    Zaman karmaşıklığı:
        Θ(n log n)

    Bellek karmaşıklığı:
        Θ(n)

    Hazır sort() veya sorted() kullanılmamıştır.
    """

    if len(arr) <= 1:
        return arr

    middle = len(arr) // 2

    left = []
    right = []

    # Sol parçayı oluştur
    for i in range(0, middle):
        left.append(arr[i])

    # Sağ parçayı oluştur
    for i in range(middle, len(arr)):
        right.append(arr[i])

    left = merge_sort(left)
    right = merge_sort(right)

    return merge(left, right)


def merge(left, right):
    """
    İki sıralı listeyi birleştirir.
    """

    result = []
    i = 0
    j = 0

    while i < len(left) and j < len(right):
        if left[i] <= right[j]:
            result.append(left[i])
            i = i + 1
        else:
            result.append(right[j])
            j = j + 1

    while i < len(left):
        result.append(left[i])
        i = i + 1

    while j < len(right):
        result.append(right[j])
        j = j + 1

    return result


def merge_sort_operation_count(n):
    """
    Merge Sort'un işlem sayısını yaklaşık olarak simüle eder.

    T(n) = 2T(n / 2) + n

    Burada gerçek sıralama yapılmaz.
    Sadece bağıntının büyüme mantığı gösterilir.
    """

    if n <= 1:
        return 1

    left_part = merge_sort_operation_count(n // 2)
    right_part = merge_sort_operation_count(n // 2)

    current_level_work = n

    return left_part + right_part + current_level_work


# 5. T(n) = T(n - 1) + T(n - 2) + 1

"""
Bu bağıntı saf recursive Fibonacci algoritmasında görülür.

T(n) = T(n - 1) + T(n - 2) + 1

Problem iki recursive çağrıya ayrılır.
Ama bu çağrılar dengeli değildir ve birçok değer tekrar tekrar hesaplanır.

Sonuç:
    Üstel büyüme vardır.
    Yaklaşık O(2^n) kabul edilir.

Bu yöntem verimsizdir.
Dinamik programlama ile daha verimli hale getirilebilir.
"""


def fibonacci_recursive(n):
    """
    Saf recursive Fibonacci.

    Yineleme bağıntısı:
        T(n) = T(n - 1) + T(n - 2) + 1

    Zaman karmaşıklığı:
        O(2^n)

    Uyarı:
        Büyük n değerlerinde çok yavaş çalışır.
    """

    if n <= 1:
        return n

    return fibonacci_recursive(n - 1) + fibonacci_recursive(n - 2)


def fibonacci_operation_count(n):
    """
    Saf recursive Fibonacci'nin kaç recursive işlem yaptığını yaklaşık sayar.

    Bu fonksiyon Fibonacci değerini değil, işlem sayısını döndürür.
    """

    if n <= 1:
        return 1

    return fibonacci_operation_count(n - 1) + fibonacci_operation_count(n - 2) + 1


# 6. MASTER THEOREM ÖZET

"""
Master Theorem, şu formdaki bağıntılar için kullanılır:

    T(n) = aT(n / b) + f(n)

Genellikle f(n) = n^k şeklinde verilir.

Burada:
    a = alt problem sayısı
    b = problem boyutu kaça bölünüyor
    n^k = bölme veya birleştirme maliyeti

Basit karşılaştırma:

    a ile b^k karşılaştırılır.

1) Eğer a < b^k ise:
       T(n) = Θ(n^k)

2) Eğer a == b^k ise:
       T(n) = Θ(n^k log n)

3) Eğer a > b^k ise:
       T(n) = Θ(n^(log_b a))

Örnekler:

    T(n) = 2T(n / 2) + n
        a = 2
        b = 2
        k = 1
        b^k = 2^1 = 2
        a == b^k
        Sonuç: Θ(n log n)

    T(n) = T(n / 2) + 1
        a = 1
        b = 2
        k = 0
        b^k = 2^0 = 1
        a == b^k
        Sonuç: Θ(log n)

    T(n) = 4T(n / 2) + n
        a = 4
        b = 2
        k = 1
        b^k = 2
        a > b^k
        Sonuç: Θ(n^2)
"""


def master_theorem_simple(a, b, k):
    """
    Master Theorem için basit yorumlayıcı.

    Bağıntı biçimi:
        T(n) = aT(n / b) + n^k

    Parametreler:
        a: alt problem sayısı
        b: problemin bölünme oranı
        k: f(n) = n^k ifadesindeki üs

    Not:
        Bu fonksiyon öğretici amaçlıdır.
        Tüm özel Master Theorem durumlarını kapsamaz.
    """

    b_power_k = 1

    # b^k değerini hesapla
    for i in range(k):
        b_power_k = b_power_k * b

    print("Bağıntı: T(n) =", a, "T(n /", b, ") + n^", k)
    print("a =", a)
    print("b^k =", b_power_k)

    if a < b_power_k:
        print("Durum: a < b^k")
        print("Sonuç: Θ(n^", k, ")")
    elif a == b_power_k:
        print("Durum: a == b^k")

        if k == 0:
            print("Sonuç: Θ(log n)")
        elif k == 1:
            print("Sonuç: Θ(n log n)")
        else:
            print("Sonuç: Θ(n^", k, "log n)")
    else:
        print("Durum: a > b^k")
        print("Sonuç: Θ(n^(log_", b, a, "))")


# 7. RECURSIVE AĞACI MANTIĞI

"""
Recursive ağacı yöntemi, yineleme bağıntısını seviyeler halinde düşünmektir.

Örnek:

    T(n) = 2T(n / 2) + n

Seviye 0:
    n iş

Seviye 1:
    n / 2 + n / 2 = n iş

Seviye 2:
    n / 4 + n / 4 + n / 4 + n / 4 = n iş

Her seviyede toplam n iş yapılır.
Seviye sayısı log n kadardır.

Toplam:
    n * log n

Sonuç:
    Θ(n log n)
"""


def print_merge_sort_recursion_tree(n):
    """
    Merge Sort için recursive ağaç seviyelerini yazdırır.

    T(n) = 2T(n / 2) + n

    Bu fonksiyon konuyu görselleştirmek için yazılmıştır.
    """

    level = 0
    number_of_subproblems = 1
    subproblem_size = n

    while subproblem_size >= 1:
        total_work_at_level = number_of_subproblems * subproblem_size

        print("Seviye:", level)
        print("Alt problem sayısı:", number_of_subproblems)
        print("Her alt problem boyutu:", subproblem_size)
        print("Bu seviyedeki toplam iş:", total_work_at_level)
        print("--------------------------------")

        number_of_subproblems = number_of_subproblems * 2
        subproblem_size = subproblem_size // 2
        level = level + 1

        if subproblem_size == 0:
            break


# 8. PROGRAMI ÇALIŞTIRMA BÖLÜMÜ

if __name__ == "__main__":
    print("YİNELEME BAĞINTILARI ÇALIŞMASI")
    print("================================")

    n = 8

    print("\n1) T(n) = T(n - 1) + 1")
    print("n =", n)
    print("Yaklaşık işlem sayısı:", recurrence_decrease_by_one(n))

    print("\n2) T(n) = T(n - 1) + n")
    print("n =", n)
    print("Yaklaşık işlem sayısı:", recurrence_decrease_by_one_with_n_work(n))

    print("\n3) T(n) = T(n / 2) + 1")
    print("n =", n)
    print("Yaklaşık işlem sayısı:", recurrence_divide_by_two(n))

    print("\n4) Binary Search örneği")
    sorted_numbers = [2, 5, 8, 12, 16, 23, 38, 56]
    target = 23
    index = binary_search_recursive(sorted_numbers, target, 0, len(sorted_numbers) - 1)
    print("Liste:", sorted_numbers)
    print("Aranan:", target)
    print("Bulunan indeks:", index)

    print("\n5) Merge Sort örneği")
    numbers = [38, 27, 43, 3, 9, 82, 10]
    print("Sıralanmamış liste:", numbers)
    sorted_result = merge_sort(numbers)
    print("Sıralanmış liste:", sorted_result)
    print("Merge Sort yaklaşık işlem sayısı:", merge_sort_operation_count(8))

    print("\n6) Fibonacci recursive örneği")
    fib_n = 6
    print("fib(", fib_n, ") =", fibonacci_recursive(fib_n))
    print("Fibonacci yaklaşık işlem sayısı:", fibonacci_operation_count(fib_n))

    print("\n7) Master Theorem örnekleri")
    print("--------------------------------")
    master_theorem_simple(2, 2, 1)

    print("--------------------------------")
    master_theorem_simple(1, 2, 0)

    print("--------------------------------")
    master_theorem_simple(4, 2, 1)

    print("\n8) Merge Sort recursive ağacı")
    print("--------------------------------")
    print_merge_sort_recursion_tree(8)
