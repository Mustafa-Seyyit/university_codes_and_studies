"""
    Binary Search Tree (BST) içinde öncül (predecessor) bulma

Öncül nedir?
    Bir düğümün öncülü, o düğümden küçük olan en büyük değerdir.

Örnek:
    BST elemanları:
        20, 30, 40, 50, 60, 70, 80

    50'nin öncülü 40'tır.
    60'ın öncülü 50'dir.
    20'nin öncülü yoktur.

BST'de öncül bulma mantığı:
    1. Eğer aranan düğümün sol alt ağacı varsa:
        Öncül = sol alt ağacın maksimum elemanı

    2. Eğer sol alt ağacı yoksa:
        Kökten başlayarak aranan değere doğru ilerlenir.
        Aranan değerden küçük olan en yakın ata aday olarak tutulur.

"""


# 1. NODE SINIFI

class Node:
    """
    BST içindeki her düğüm için Node sınıfı.

    Her düğümde:
        data  : düğümün değeri
        left  : sol çocuk
        right : sağ çocuk
    """

    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None


# 2. BST'YE ELEMAN EKLEME

def insert(root, data):
    """
    BST'ye yeni eleman ekler.
    """

    if root is None:
        return Node(data)

    if data < root.data:
        root.left = insert(root.left, data)

    elif data > root.data:
        root.right = insert(root.right, data)

    # Eşit değerler tekrar eklenmez.
    return root


# 3. BST'DE DEĞER ARAMA

def search_node(root, target):
    """
    BST içinde verilen değere sahip düğümü arar.

    Bulursa düğümü döndürür.
    Bulamazsa None döndürür.
    """

    current = root

    while current is not None:

        if current.data == target:
            return current

        elif target < current.data:
            current = current.left

        else:
            current = current.right

    return None


# 4. MAKSİMUM DÜĞÜM BULMA

def find_max_node(root):
    """
    Verilen alt ağaçtaki maksimum düğümü bulur.

    BST'de maksimum eleman daima en sağdaki düğümdür.
    """

    if root is None:
        return None

    current = root

    while current.right is not None:
        current = current.right

    return current


# 5. ÖNCÜL BULMA

def find_predecessor(root, target):
    """
    BST içinde verilen değerin öncülünü bulur.

    Parametreler:
        root   : BST'nin kökü
        target : Öncülü bulunacak değer

    Geri dönüş:
        Öncül düğüm varsa Node döner.
        Öncül yoksa None döner.
    """

    # Önce hedef değerin ağaçta olup olmadığını kontrol ediyoruz.
    target_node = search_node(root, target)

    if target_node is None:
        return None

    # Durum 1:
    # Eğer düğümün sol alt ağacı varsa,
    # öncül sol alt ağacın maksimum elemanıdır.
    if target_node.left is not None:
        return find_max_node(target_node.left)

    # Durum 2:
    # Sol alt ağaç yoksa kökten başlayarak öncül adayı aranır.
    predecessor = None
    current = root

    while current is not None:

        if target > current.data:
            # current, target'tan küçük olduğu için öncül adayı olabilir.
            predecessor = current
            current = current.right

        elif target < current.data:
            current = current.left

        else:
            break

    return predecessor


# 6. INORDER DOLAŞMA

def inorder(root):
    """
    BST'yi inorder şekilde yazdırır.

    Inorder:
        Sol -> Kök -> Sağ

    BST'de inorder çıktı küçükten büyüğe sıralıdır.
    Öncül mantığını görmek için faydalıdır.
    """

    if root is not None:
        inorder(root.left)
        print(root.data, end=" ")
        inorder(root.right)


# 7. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    root = None

    values = [50, 30, 70, 20, 40, 60, 80]

    for i in range(len(values)):
        root = insert(root, values[i])

    print("BST elemanları:")
    print(values)

    print("\nInorder gösterim:")
    inorder(root)

    test_values = [20, 30, 40, 50, 60, 70, 80, 25]

    print("\n\nÖncül bulma sonuçları:")

    for i in range(len(test_values)):
        target = test_values[i]
        predecessor = find_predecessor(root, target)

        if predecessor is not None:
            print(target, "değerinin öncülü:", predecessor.data)
        else:
            print(target, "değerinin öncülü yok veya değer ağaçta bulunamadı.")

    print("\nKarmaşıklık")
    print("En iyi durum: O(1)")
    print("Ortalama durum: O(log n)  dengeli ağaçta")
    print("En kötü durum: O(n)       ağaç liste gibi olursa")
    print("Bellek karmaşıklığı: O(1)")
