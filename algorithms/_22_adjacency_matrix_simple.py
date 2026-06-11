
# 1. MATRİS OLUŞTURMA

def create_matrix(vertex_count):
    """
    vertex_count x vertex_count boyutunda sıfır matrisi oluşturur.
    """

    matrix = []

    for i in range(vertex_count):
        row = []

        for j in range(vertex_count):
            row.append(0)

        matrix.append(row)

    return matrix


# 2. KENAR EKLEME

def add_edge(matrix, vertex1, vertex2):
    """
    Yönsüz grafa kenar ekler.

    vertex1 ve vertex2 burada düğümlerin indeksidir.

    Örnek:
        A = 0
        B = 1

        A -- B kenarı için:
            add_edge(matrix, 0, 1)
    """

    matrix[vertex1][vertex2] = 1
    matrix[vertex2][vertex1] = 1


# 3. KENAR KONTROLÜ

def has_edge(matrix, vertex1, vertex2):
    """
    İki düğüm arasında kenar olup olmadığını kontrol eder.
    """

    if matrix[vertex1][vertex2] == 1:
        return True

    return False


# 4. MATRİSİ YAZDIRMA

def print_matrix(matrix, vertices):
    """
    Komşuluk matrisini ekrana yazdırır.
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


# 5. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    vertices = ["A", "B", "C", "D", "E"]

    graph_matrix = create_matrix(len(vertices))

    # Düğüm indeksleri:
    # A = 0
    # B = 1
    # C = 2
    # D = 3
    # E = 4

    add_edge(graph_matrix, 0, 1)  # A -- B
    add_edge(graph_matrix, 0, 2)  # A -- C
    add_edge(graph_matrix, 1, 3)  # B -- D
    add_edge(graph_matrix, 2, 4)  # C -- E
    add_edge(graph_matrix, 3, 4)  # D -- E

    print_matrix(graph_matrix, vertices)

    print("\nKenar kontrolü:")
    print("A ile B arasında kenar var mı?", has_edge(graph_matrix, 0, 1))
    print("A ile E arasında kenar var mı?", has_edge(graph_matrix, 0, 4))

    print("\nKarmaşıklık")
    print("Bellek karmaşıklığı: O(V^2)")
    print("Kenar kontrolü: O(1)")
    print("V = düğüm sayısı")
