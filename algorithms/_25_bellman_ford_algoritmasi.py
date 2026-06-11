"""
    Bellman-Ford Algoritması

Problem:
    Ağırlıklı bir grafta, seçilen başlangıç düğümünden
    diğer tüm düğümlere olan en kısa yolları bulmak.

Dijkstra'dan farkı:
    - Bellman-Ford negatif ağırlıklı kenarlarla çalışabilir.
    - Negatif ağırlıklı döngü olup olmadığını tespit edebilir.
    - Dijkstra negatif kenarlarda güvenilir değildir.

Negatif döngü nedir: Toplam ağırlığı negatif olan bir döngüdür.

    Böyle bir döngü varsa en kısa yol kesin olarak bulunamaz.
    Çünkü döngü tekrar tekrar gezilerek mesafe sürekli azaltılabilir.

"""


# 1. KENAR EKLEME

def add_edge(edges, from_vertex, to_vertex, weight):
    """
    Kenar listesine yeni kenar ekler.

    Parametreler:
        edges       : Kenar listesidir.
        from_vertex : Kenarın başladığı düğüm indeksi
        to_vertex   : Kenarın bittiği düğüm indeksi
        weight      : Kenarın ağırlığı

    Örnek:
        A -> B ağırlık 4 ise:
            add_edge(edges, 0, 1, 4)
    """

    edge = [from_vertex, to_vertex, weight]
    edges.append(edge)


# 2. BELLMAN-FORD ALGORİTMASI

def bellman_ford(vertices, edges, start_index):
    """
    Bellman-Ford algoritması.

    Parametreler:
        vertices:
            Düğüm isimlerini tutan liste.

        edges:
            Kenar listesi.
            Her kenar [u, v, w] şeklindedir.
            u -> v kenarı vardır ve ağırlığı w'dir.

        start_index:
            Başlangıç düğümünün indeksi.

    Geri dönüş:
        distance:
            Başlangıçtan her düğüme olan en kısa mesafe.

        parent:
            En kısa yolda her düğümün önceki düğümü.

        has_negative_cycle:
            Negatif döngü varsa True, yoksa False.
    """

    vertex_count = len(vertices)

    distance = []
    parent = []

    for i in range(vertex_count):
        distance.append(999999999)
        parent.append(-1)

    # Başlangıç düğümünün kendisine uzaklığı 0'dır.
    distance[start_index] = 0

    # Bellman-Ford algoritmasında tüm kenarlar V - 1 kez gevşetilir.
    #
    # Neden V - 1?
    # En kısa yol en fazla V - 1 kenardan oluşur.
    # Çünkü basit bir yolda aynı düğüm tekrar edilmez.
    for i in range(vertex_count - 1):

        # Bu değişken, bir turda hiç güncelleme olmadıysa
        # algoritmayı erken bitirmek için kullanılır.
        updated = False

        for j in range(len(edges)):
            u = edges[j][0]
            v = edges[j][1]
            weight = edges[j][2]

            # Eğer u düğümüne ulaşılabiliyorsa ve
            # u üzerinden v'ye gitmek daha kısa ise güncelle.
            if distance[u] != 999999999 and distance[u] + weight < distance[v]:
                distance[v] = distance[u] + weight
                parent[v] = u
                updated = True

        # Eğer bu turda hiçbir mesafe değişmediyse
        # daha fazla devam etmeye gerek yoktur.
        if updated == False:
            break

    # Negatif ağırlıklı döngü kontrolü:
    # V - 1 turdan sonra hâlâ bir mesafe azalabiliyorsa,
    # graf içinde negatif ağırlıklı döngü vardır.
    has_negative_cycle = False

    for j in range(len(edges)):
        u = edges[j][0]
        v = edges[j][1]
        weight = edges[j][2]

        if distance[u] != 999999999 and distance[u] + weight < distance[v]:
            has_negative_cycle = True

    return distance, parent, has_negative_cycle


# 3. EN KISA YOLU YAZDIRMA

def print_path(parent, vertex_index, vertices):
    """
    Başlangıç düğümünden vertex_index düğümüne giden yolu yazdırır.
    """

    if parent[vertex_index] == -1:
        print(vertices[vertex_index], end="")
        return

    print_path(parent, parent[vertex_index], vertices)
    print(" -> " + vertices[vertex_index], end="")


# 4. SONUÇLARI YAZDIRMA

def print_result(distance, parent, vertices, start_index, has_negative_cycle):
    """
    Bellman-Ford sonucunu ekrana yazdırır.
    """

    if has_negative_cycle == True:
        print("Graf içinde negatif ağırlıklı döngü bulundu.")
        print("Bu durumda en kısa yollar güvenilir şekilde hesaplanamaz.")
        return

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


# 5. KENAR LİSTESİNİ YAZDIRMA

def print_edges(edges, vertices):
    """
    Grafın kenar listesini yazdırır.
    """

    print("Kenar Listesi")
    print("-------------")

    for i in range(len(edges)):
        u = edges[i][0]
        v = edges[i][1]
        weight = edges[i][2]

        print(vertices[u], "->", vertices[v], ":", weight)


# 6. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    print("BELLMAN-FORD ALGORİTMASI")
    print("========================")

    vertices = ["A", "B", "C", "D", "E"]

    edges = []

    # Yönlü graf örneği
    #
    # A -> B : 6
    # A -> D : 7
    # B -> C : 5
    # B -> D : 8
    # B -> E : -4
    # C -> B : -2
    # D -> C : -3
    # D -> E : 9
    # E -> A : 2
    # E -> C : 7

    add_edge(edges, 0, 1, 6)
    add_edge(edges, 0, 3, 7)
    add_edge(edges, 1, 2, 5)
    add_edge(edges, 1, 3, 8)
    add_edge(edges, 1, 4, -4)
    add_edge(edges, 2, 1, -2)
    add_edge(edges, 3, 2, -3)
    add_edge(edges, 3, 4, 9)
    add_edge(edges, 4, 0, 2)
    add_edge(edges, 4, 2, 7)

    print_edges(edges, vertices)

    print()

    start_index = 0  # A düğümü

    distance, parent, has_negative_cycle = bellman_ford(vertices, edges, start_index)

    print_result(distance, parent, vertices, start_index, has_negative_cycle)

    print("\nKarmaşıklık")
    print("Zaman karmaşıklığı : O(V * E)")
    print("Bellek karmaşıklığı: O(V)")
    print("V = düğüm sayısı")
    print("E = kenar sayısı")

    print("\nÖzet")
    print("Bellman-Ford algoritması negatif kenar ağırlıklarını destekler.")
    print("Ayrıca negatif ağırlıklı döngü olup olmadığını kontrol eder.")
