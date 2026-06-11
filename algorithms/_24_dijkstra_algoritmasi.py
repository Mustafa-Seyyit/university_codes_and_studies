"""
    Dijkstra Algoritması

Problem:
    Ağırlıklı bir grafta, seçilen başlangıç düğümünden
    diğer tüm düğümlere olan en kısa yolları bulmak.

Önemli:
    Dijkstra algoritması negatif ağırlıklı kenarlarda kullanılmaz.

Kullanım alanları:
    - Harita uygulamaları
    - Yol bulma problemleri
    - Ağ yönlendirme
    - En kısa mesafe hesaplama

"""


# 1. EN KÜÇÜK MESAFEYE SAHİP DÜĞÜMÜ BULMA

def find_min_distance(distance, visited, vertex_count):
    """
    Henüz ziyaret edilmemiş düğümler arasından
    distance değeri en küçük olan düğümü bulur.

    Parametreler:
        distance:
            Başlangıç düğümünden diğer düğümlere olan
            mevcut en kısa mesafeleri tutar.

        visited:
            Düğümün kalıcı olarak işlenip işlenmediğini tutar.

    Geri dönüş:
        En küçük mesafeye sahip düğümün indeksi.
    """

    min_value = 999999999
    min_index = -1

    for i in range(vertex_count):
        if visited[i] == False and distance[i] < min_value:
            min_value = distance[i]
            min_index = i

    return min_index


# 2. DIJKSTRA ALGORİTMASI

def dijkstra(graph, vertices, start_index):
    """
    Dijkstra algoritması.

    Parametreler:
        graph:
            Komşuluk matrisi.
            graph[i][j] = 0 ise i ile j arasında kenar yoktur.
            graph[i][j] > 0 ise kenar ağırlığıdır.

        vertices:
            Düğüm isimlerini tutan liste.

        start_index:
            Başlangıç düğümünün indeksi.

    Geri dönüş:
        distance:
            Başlangıçtan her düğüme olan en kısa mesafe.

        parent:
            En kısa yol ağacında her düğümün önceki düğümü.
    """

    vertex_count = len(vertices)

    distance = []
    visited = []
    parent = []

    for i in range(vertex_count):
        distance.append(999999999)
        visited.append(False)
        parent.append(-1)

    # Başlangıç düğümünün kendisine uzaklığı 0'dır.
    distance[start_index] = 0

    for count in range(vertex_count):

        # Henüz ziyaret edilmemiş en küçük mesafeli düğümü seç.
        u = find_min_distance(distance, visited, vertex_count)

        # Eğer u -1 ise kalan düğümlere ulaşılamıyor demektir.
        if u == -1:
            break

        visited[u] = True

        # u düğümünün tüm komşularını kontrol et.
        for v in range(vertex_count):

            # graph[u][v] > 0:
            #     u ile v arasında kenar var.
            #
            # visited[v] == False:
            #     v düğümü henüz kesinleşmemiş.
            #
            # distance[u] + graph[u][v] < distance[v]:
            #     Daha kısa yol bulundu.
            if (
                graph[u][v] > 0
                and visited[v] == False
                and distance[u] + graph[u][v] < distance[v]
            ):
                distance[v] = distance[u] + graph[u][v]
                parent[v] = u

    return distance, parent


# 3. EN KISA YOLU YAZDIRMA

def print_path(parent, vertex_index, vertices):
    """
    Başlangıç düğümünden vertex_index düğümüne giden yolu yazdırır.

    parent dizisi kullanılarak geriye doğru gidilir.
    """

    if parent[vertex_index] == -1:
        print(vertices[vertex_index], end="")
        return

    print_path(parent, parent[vertex_index], vertices)
    print(" -> " + vertices[vertex_index], end="")


# 4. SONUÇLARI YAZDIRMA

def print_result(distance, parent, vertices, start_index):
    """
    Dijkstra algoritmasının sonuçlarını yazdırır.
    """

    print("Başlangıç düğümü:", vertices[start_index])
    print()

    print("Düğüm\tMesafe\tYol")
    print("-----------------------------")

    for i in range(len(vertices)):
        print(vertices[i], end="\t")

        if distance[i] == 999999999:
            print("Ulaşılamaz", end="\t")
            print("-")
        else:
            print(distance[i], end="\t")
            print_path(parent, i, vertices)
            print()


# 5. KOMŞULUK MATRİSİNİ YAZDIRMA

def print_graph_matrix(graph, vertices):
    """
    Grafın komşuluk matrisini yazdırır.
    """

    print("Komşuluk Matrisi")
    print("----------------")

    print("   ", end="")

    for i in range(len(vertices)):
        print(vertices[i], end=" ")

    print()

    for i in range(len(graph)):
        print(vertices[i], end=": ")

        for j in range(len(graph[i])):
            print(graph[i][j], end=" ")

        print()


# 6. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    print("DIJKSTRA ALGORİTMASI")
    print("====================")

    vertices = ["A", "B", "C", "D", "E", "F"]

    # Komşuluk matrisi
    #
    # 0 değeri kenar yok demektir.
    #
    # Graf kenarları:
    # A-B: 4
    # A-C: 2
    # B-C: 1
    # B-D: 5
    # C-D: 8
    # C-E: 10
    # D-E: 2
    # D-F: 6
    # E-F: 3

    graph = [
        [0, 4, 2, 0, 0, 0],
        [4, 0, 1, 5, 0, 0],
        [2, 1, 0, 8, 10, 0],
        [0, 5, 8, 0, 2, 6],
        [0, 0, 10, 2, 0, 3],
        [0, 0, 0, 6, 3, 0]
    ]

    print_graph_matrix(graph, vertices)

    print()

    start_index = 0  # A düğümü

    distance, parent = dijkstra(graph, vertices, start_index)

    print_result(distance, parent, vertices, start_index)

    print("\nKarmaşıklık")
    print("Bu kod komşuluk matrisi kullandığı için:")
    print("Zaman karmaşıklığı : O(V^2)")
    print("Bellek karmaşıklığı: O(V)")
    print("V = düğüm sayısı")

    print("\nÖzet")
    print("Dijkstra algoritması başlangıç düğümünden diğer tüm düğümlere")
    print("olan en kısa yolları bulur.")
    print("Negatif kenar ağırlıkları varsa Dijkstra kullanılmamalıdır.")
