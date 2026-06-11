# 1. GRAF NEDİR?
"""
Graf:
    Düğümlerden ve bu düğümler arasındaki kenarlardan oluşan yapıdır.

Örnek:
    A -- B
    A -- C
    B -- D
    C -- E

Burada:
    A, B, C, D, E düğümdür.
    A-B, A-C, B-D, C-E kenardır.

Bu dosyada yönsüz graf kullanılacaktır.
Yani A-B kenarı varsa B-A da vardır.
"""


# 2. GRAF OLUŞTURMA

def create_graph():
    """
    Boş graf oluşturur.

    Grafı dictionary mantığıyla tutuyoruz.

    Örnek:
        graph["A"] = ["B", "C"]

    Anlamı:
        A düğümü B ve C düğümlerine bağlıdır.
    """

    graph = {}

    return graph


def add_vertex(graph, vertex):
    """
    Grafa yeni düğüm ekler.

    Eğer düğüm zaten varsa tekrar eklemez.
    """

    if vertex not in graph:
        graph[vertex] = []


def add_edge(graph, vertex1, vertex2):
    """
    Yönsüz grafa kenar ekler.

    vertex1 -- vertex2

    Yönsüz olduğu için:
        vertex1 listesine vertex2 eklenir.
        vertex2 listesine vertex1 eklenir.
    """

    add_vertex(graph, vertex1)
    add_vertex(graph, vertex2)

    graph[vertex1].append(vertex2)
    graph[vertex2].append(vertex1)


def print_graph(graph):
    """
    Grafı komşuluk listesi şeklinde yazdırır.
    """

    print("Grafın komşuluk listesi:")

    for vertex in graph:
        print(vertex, "->", graph[vertex])


# 3. BFS - BREADTH FIRST SEARCH

"""
BFS:
    Breadth First Search
    Genişlik öncelikli arama

Mantık:
    Önce başlangıç düğümünün komşuları gezilir.
    Sonra onların komşuları gezilir.

BFS genellikle queue mantığı ile çalışır.

Zaman karmaşıklığı:
    O(V + E)

Burada:
    V = düğüm sayısı
    E = kenar sayısı
"""


def bfs(graph, start):
    """
    BFS algoritması.

    Parametreler:
        graph : Graf
        start : Başlangıç düğümü
    """

    visited = []
    queue = []

    visited.append(start)
    queue.append(start)

    print("BFS sırası:", end=" ")

    while len(queue) > 0:
        current = queue[0]

        # Queue'dan ilk elemanı elle çıkarıyoruz.
        new_queue = []

        for i in range(1, len(queue)):
            new_queue.append(queue[i])

        queue = new_queue

        print(current, end=" ")

        for i in range(len(graph[current])):
            neighbor = graph[current][i]

            if neighbor not in visited:
                visited.append(neighbor)
                queue.append(neighbor)

    print()


# 4. DFS - DEPTH FIRST SEARCH

"""
DFS:
    Depth First Search
    Derinlik öncelikli arama

Mantık:
    Bir yoldan gidilebildiği kadar derine gidilir.
    Sonra geri dönülür.

DFS recursive veya stack ile yazılabilir.
Bu örnekte recursive yöntem kullanılmıştır.

Zaman karmaşıklığı:
    O(V + E)
"""


def dfs(graph, start, visited):
    """
    DFS algoritması recursive olarak yazılmıştır.

    Parametreler:
        graph   : Graf
        start   : Başlangıç düğümü
        visited : Ziyaret edilen düğümler listesi
    """

    visited.append(start)

    print(start, end=" ")

    for i in range(len(graph[start])):
        neighbor = graph[start][i]

        if neighbor not in visited:
            dfs(graph, neighbor, visited)


# 5. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    graph = create_graph()

    add_edge(graph, "A", "B")
    add_edge(graph, "A", "C")
    add_edge(graph, "B", "D")
    add_edge(graph, "B", "E")
    add_edge(graph, "C", "F")
    add_edge(graph, "E", "F")

    print_graph(graph)

    print()
    bfs(graph, "A")

    print("DFS sırası:", end=" ")
    visited = []
    dfs(graph, "A", visited)
    print()

    print("\nKarmaşıklık")
    print("BFS zaman karmaşıklığı: O(V + E)")
    print("DFS zaman karmaşıklığı: O(V + E)")
    print("V = düğüm sayısı")
    print("E = kenar sayısı")
