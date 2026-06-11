# 1. SIFIR MATRİSİ OLUŞTURMA
def create_zero_matrix(size):
    """
    size x size boyutunda sıfır matrisi oluşturur.

    Örnek:
        size = 3

        0 0 0
        0 0 0
        0 0 0
    """

    matrix = []

    for i in range(size):
        row = []

        for j in range(size):
            row.append(0)

        matrix.append(row)

    return matrix


# 2. DÜĞÜMÜN İNDEKSİNİ BULMA

def find_vertex_index(vertices, vertex):
    """
    Verilen düğümün vertices listesi içindeki indeksini bulur.

    Hazır index() fonksiyonu kullanılmamıştır.

    Bulursa indeks döndürür.
    Bulamazsa -1 döndürür.
    """

    for i in range(len(vertices)):
        if vertices[i] == vertex:
            return i

    return -1


# 3. YÖNSÜZ GRAFA KENAR EKLEME

def add_undirected_edge(matrix, vertices, vertex1, vertex2):
    """
    Yönsüz grafa kenar ekler.

    Örnek:
        A -- B

    Bu durumda:
        matrix[A][B] = 1
        matrix[B][A] = 1
    """

    index1 = find_vertex_index(vertices, vertex1)
    index2 = find_vertex_index(vertices, vertex2)

    if index1 == -1 or index2 == -1:
        print("Hata: Düğüm bulunamadı.")
        return

    matrix[index1][index2] = 1
    matrix[index2][index1] = 1


# 4. YÖNLÜ GRAFA KENAR EKLEME

def add_directed_edge(matrix, vertices, from_vertex, to_vertex):
    """
    Yönlü grafa kenar ekler.

    Örnek:
        A -> B

    Bu durumda:
        matrix[A][B] = 1
    """

    from_index = find_vertex_index(vertices, from_vertex)
    to_index = find_vertex_index(vertices, to_vertex)

    if from_index == -1 or to_index == -1:
        print("Hata: Düğüm bulunamadı.")
        return

    matrix[from_index][to_index] = 1


# 5. KOMŞULUK MATRİSİNİ YAZDIRMA

def print_adjacency_matrix(matrix, vertices):
    """
    Komşuluk matrisini düğüm isimleriyle birlikte yazdırır.
    """

    print("Komşuluk Matrisi")
    print("----------------")

    print("   ", end="")

    for i in range(len(vertices)):
        print(vertices[i], end=" ")

    print()

    for i in range(len(matrix)):
        print(vertices[i], end=": ")

        for j in range(len(matrix[i])):
            print(matrix[i][j], end=" ")

        print()


# 6. KENAR VAR MI KONTROLÜ

def has_edge(matrix, vertices, vertex1, vertex2):
    """
    İki düğüm arasında kenar olup olmadığını kontrol eder.

    Kenar varsa True,
    yoksa False döndürür.
    """

    index1 = find_vertex_index(vertices, vertex1)
    index2 = find_vertex_index(vertices, vertex2)

    if index1 == -1 or index2 == -1:
        return False

    if matrix[index1][index2] == 1:
        return True

    return False


# 7. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    print("GRAF GÖSTERİMİ - KOMŞULUK MATRİSİ")
    print("=================================")

    vertices = ["A", "B", "C", "D"]

    matrix = create_zero_matrix(len(vertices))

    # Yönsüz graf kenarları:
    # A -- B
    # A -- C
    # B -- D
    # C -- D
    add_undirected_edge(matrix, vertices, "A", "B")
    add_undirected_edge(matrix, vertices, "A", "C")
    add_undirected_edge(matrix, vertices, "B", "D")
    add_undirected_edge(matrix, vertices, "C", "D")

    print("\nYönsüz graf örneği:")
    print_adjacency_matrix(matrix, vertices)

    print("\nKenar kontrolü:")
    print("A ile B arasında kenar var mı?", has_edge(matrix, vertices, "A", "B"))
    print("A ile D arasında kenar var mı?", has_edge(matrix, vertices, "A", "D"))

    print("\nYönlü graf örneği:")

    directed_matrix = create_zero_matrix(len(vertices))

    # Yönlü graf kenarları:
    # A -> B
    # A -> C
    # D -> A
    add_directed_edge(directed_matrix, vertices, "A", "B")
    add_directed_edge(directed_matrix, vertices, "A", "C")
    add_directed_edge(directed_matrix, vertices, "D", "A")

    print_adjacency_matrix(directed_matrix, vertices)

    print("\nKarmaşıklık")
    print("Bellek karmaşıklığı: O(V^2)")
    print("Kenar kontrolü: O(1)  indeksler biliniyorsa")
    print("Bu örnekte düğüm indeksi elle arandığı için kontrol O(V) olabilir.")
    print("V = düğüm sayısı")
