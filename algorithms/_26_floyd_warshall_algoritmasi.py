"""
    Floyd-Warshall Algoritması

Problem:
    Bir graftaki tüm düğüm çiftleri arasındaki en kısa yolları bulmak.

Dijkstra:
    Tek kaynaklı en kısa yol algoritmasıdır.
    Bir başlangıç düğümünden diğer düğümlere olan en kısa yolları bulur.

Bellman-Ford:
    Tek kaynaklı en kısa yol algoritmasıdır.
    Negatif kenar ağırlıklarıyla çalışabilir.

Floyd-Warshall:
    Tüm düğüm çiftleri arasındaki en kısa yolları bulur.

Önemli:
    - Negatif kenar ağırlıkları olabilir.
    - Ama negatif ağırlıklı döngü olmamalıdır.

"""


# 1. SABİT SONSUZ DEĞER

INF = 999999999


# 2. MATRİS KOPYALAMA

def copy_matrix(matrix):
    """
    Verilen matrisi yeni bir matrise kopyalar.

    Böylece orijinal grafik matrisi bozulmaz.
    """

    new_matrix = []

    for i in range(len(matrix)):
        row = []

        for j in range(len(matrix[i])):
            row.append(matrix[i][j])

        new_matrix.append(row)

    return new_matrix


# 3. NEXT MATRİSİ OLUŞTURMA

def create_next_matrix(graph):
    """
    Yol yazdırmak için next matrisi oluşturur.

    next_node[i][j]:
        i düğümünden j düğümüne giderken ilk gidilecek düğümü tutar.

    Eğer i'den j'ye doğrudan kenar varsa:
        next_node[i][j] = j

    Eğer yol yoksa:
        next_node[i][j] = -1
    """

    vertex_count = len(graph)

    next_node = []

    for i in range(vertex_count):
        row = []

        for j in range(vertex_count):
            if graph[i][j] != INF and i != j:
                row.append(j)
            else:
                row.append(-1)

        next_node.append(row)

    return next_node


# 4. FLOYD-WARSHALL ALGORİTMASI

def floyd_warshall(graph):
    """
    Floyd-Warshall algoritması.

    Parametre:
        graph:
            Komşuluk matrisi.

            graph[i][j] = i'den j'ye olan kenar ağırlığı
            INF = i'den j'ye kenar yok

    Geri dönüş:
        distance:
            Tüm düğüm çiftleri arasındaki en kısa mesafeler

        next_node:
            En kısa yolu yazdırmak için kullanılan yardımcı tablo

        has_negative_cycle:
            Negatif döngü varsa True olur.
    """

    vertex_count = len(graph)

    distance = copy_matrix(graph)
    next_node = create_next_matrix(graph)

    # k: ara düğüm
    # i: başlangıç düğümü
    # j: hedef düğüm
    #
    # Mantık:
    # i -> j direkt gitmek mi daha kısa?
    # yoksa i -> k -> j gitmek mi daha kısa?
    for k in range(vertex_count):
        for i in range(vertex_count):
            for j in range(vertex_count):

                if distance[i][k] != INF and distance[k][j] != INF:

                    new_distance = distance[i][k] + distance[k][j]

                    if new_distance < distance[i][j]:
                        distance[i][j] = new_distance
                        next_node[i][j] = next_node[i][k]

    # Negatif döngü kontrolü:
    # distance[i][i] < 0 ise i düğümünden başlayıp tekrar i'ye
    # negatif maliyetle dönmek mümkündür.
    has_negative_cycle = False

    for i in range(vertex_count):
        if distance[i][i] < 0:
            has_negative_cycle = True

    return distance, next_node, has_negative_cycle


# 5. EN KISA YOLU OLUŞTURMA

def construct_path(next_node, start, end):
    """
    start düğümünden end düğümüne en kısa yolu liste olarak döndürür.

    Eğer yol yoksa boş liste döndürür.
    """

    if next_node[start][end] == -1:
        return []

    path = []
    path.append(start)

    current = start

    while current != end:
        current = next_node[current][end]
        path.append(current)

    return path


# 6. MATRİS YAZDIRMA

def print_distance_matrix(distance, vertices):
    """
    Mesafe matrisini ekrana yazdırır.
    """

    print("En Kısa Mesafe Matrisi")
    print("----------------------")

    print("   ", end="")

    for i in range(len(vertices)):
        print(vertices[i], end="\t")

    print()

    for i in range(len(distance)):
        print(vertices[i], end=": ")

        for j in range(len(distance[i])):
            if distance[i][j] == INF:
                print("INF", end="\t")
            else:
                print(distance[i][j], end="\t")

        print()


def print_path(path, vertices):
    """
    Düğüm indekslerinden oluşan yolu düğüm isimleriyle yazdırır.
    """

    if len(path) == 0:
        print("Yol yok")
        return

    for i in range(len(path)):
        print(vertices[path[i]], end="")

        if i != len(path) - 1:
            print(" -> ", end="")

    print()


# 7. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    print("FLOYD-WARSHALL ALGORİTMASI")
    print("==========================")

    vertices = ["A", "B", "C", "D"]

    # Komşuluk matrisi
    #
    # INF değeri kenar yok anlamına gelir.
    #
    # Graf:
    # A -> B : 5
    # A -> D : 10
    # B -> C : 3
    # C -> D : 1
    # D -> A : 2

    graph = [
        [0,   5,   INF, 10],
        [INF, 0,   3,   INF],
        [INF, INF, 0,   1],
        [2,   INF, INF, 0]
    ]

    distance, next_node, has_negative_cycle = floyd_warshall(graph)

    if has_negative_cycle == True:
        print("Graf içinde negatif ağırlıklı döngü var.")
        print("En kısa yollar güvenilir değildir.")
    else:
        print_distance_matrix(distance, vertices)

        print("\nÖrnek yollar")
        print("------------")

        start = 0  # A
        end = 3    # D

        print("A'dan D'ye en kısa yol:")
        path = construct_path(next_node, start, end)
        print_path(path, vertices)
        print("Mesafe:", distance[start][end])

        start = 3  # D
        end = 2    # C

        print("\nD'den C'ye en kısa yol:")
        path = construct_path(next_node, start, end)
        print_path(path, vertices)
        print("Mesafe:", distance[start][end])

    print("\nKarmaşıklık")
    print("Zaman karmaşıklığı : O(V^3)")
    print("Bellek karmaşıklığı: O(V^2)")
    print("V = düğüm sayısı")

    print("\nÖzet")
    print("Floyd-Warshall algoritması tüm düğüm çiftleri arasındaki")
    print("en kısa yolları bulmak için kullanılır.")
