
# 1. EN KÜÇÜK KEY DEĞERİNE SAHİP DÜĞÜMÜ BULMA

def find_min_key(key, visited, vertex_count):
    """
    MST'ye henüz eklenmemiş düğümler arasından
    key değeri en küçük olan düğümü bulur.

    key[i]:
        i düğümünün MST'ye bağlanması için gereken en küçük kenar ağırlığıdır.

    visited[i]:
        i düğümü MST'ye eklendiyse True olur.
    """

    min_value = 999999999
    min_index = -1

    for i in range(vertex_count):
        if visited[i] == False and key[i] < min_value:
            min_value = key[i]
            min_index = i

    return min_index


# 2. PRIM ALGORİTMASI

def prim_algorithm(graph, vertices):
    """
    Prim algoritması ile Minimum Kapsayan Ağaç bulur.

    Parametreler:
        graph:
            Komşuluk matrisi.
            graph[i][j] = 0 ise kenar yoktur.
            graph[i][j] > 0 ise kenar ağırlığıdır.

        vertices:
            Düğüm isimlerini tutan liste.

    Geri dönüş:
        parent:
            MST'de her düğümün bağlı olduğu önceki düğümü tutar.
    """

    vertex_count = len(vertices)

    # key dizisi, her düğüm için MST'ye bağlanma maliyetini tutar.
    key = []

    # parent dizisi, MST kenarlarını tutar.
    parent = []

    # visited dizisi, düğüm MST'ye eklendi mi bilgisini tutar.
    visited = []

    for i in range(vertex_count):
        key.append(999999999)
        parent.append(-1)
        visited.append(False)

    # Başlangıç düğümü olarak 0. düğümü seçiyoruz.
    # Bu düğümün MST'ye eklenme maliyeti 0 kabul edilir.
    key[0] = 0

    # MST'de vertex_count tane düğüm olmalıdır.
    for count in range(vertex_count):

        # MST'ye henüz eklenmemiş ve key değeri en küçük düğümü seç.
        u = find_min_key(key, visited, vertex_count)

        # Eğer u -1 ise graf bağlı değildir.
        if u == -1:
            print("Graf bağlı değil. MST oluşturulamaz.")
            return parent

        visited[u] = True

        # Seçilen u düğümünün komşularını kontrol et.
        for v in range(vertex_count):

            # graph[u][v] > 0 ise u ile v arasında kenar vardır.
            # visited[v] == False ise v henüz MST'de değildir.
            # graph[u][v] < key[v] ise daha ucuz bir bağlantı bulundu demektir.
            if graph[u][v] > 0 and visited[v] == False and graph[u][v] < key[v]:
                key[v] = graph[u][v]
                parent[v] = u

    return parent


# 3. MST SONUCUNU YAZDIRMA

def print_mst(parent, graph, vertices):
    """
    Prim algoritması sonucunda oluşan MST kenarlarını yazdırır.
    """

    total_cost = 0

    print("Minimum Kapsayan Ağaç Kenarları")
    print("--------------------------------")

    for i in range(1, len(vertices)):
        if parent[i] != -1:
            start_vertex = vertices[parent[i]]
            end_vertex = vertices[i]
            weight = graph[i][parent[i]]

            print(start_vertex, "-", end_vertex, ":", weight)

            total_cost = total_cost + weight

    print("\nToplam MST maliyeti:", total_cost)


# 4. GRAFI YAZDIRMA

def print_graph_matrix(graph, vertices):
    """
    Komşuluk matrisini ekrana yazdırır.
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


# 5. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    print("PRIM ALGORİTMASI")
    print("================")

    vertices = ["A", "B", "C", "D", "E"]

    # Komşuluk matrisi
    # 0 değeri kenar yok demektir.
    #
    # Graf:
    # A-B: 2
    # A-C: 3
    # B-C: 1
    # B-D: 4
    # C-D: 5
    # C-E: 6
    # D-E: 7

    graph = [
        [0, 2, 3, 0, 0],
        [2, 0, 1, 4, 0],
        [3, 1, 0, 5, 6],
        [0, 4, 5, 0, 7],
        [0, 0, 6, 7, 0]
    ]

    print_graph_matrix(graph, vertices)

    print()

    parent = prim_algorithm(graph, vertices)

    print_mst(parent, graph, vertices)

    print("\nKarmaşıklık")
    print("Bu kod komşuluk matrisi kullandığı için:")
    print("Zaman karmaşıklığı : O(V^2)")
    print("Bellek karmaşıklığı: O(V)")
    print("V = düğüm sayısı")

    print("\nÖzet")
    print("Prim algoritması her adımda MST'ye bağlanabilecek en küçük kenarı seçer.")
    print("Bu yüzden açgözlü bir algoritmadır.")
