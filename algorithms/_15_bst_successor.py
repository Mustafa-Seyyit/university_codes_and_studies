"""
    Binary Search Tree (BST) içinde ardıl (successor) bulma

Ardıl nedir?
    Bir düğümün ardılı, o düğümden büyük olan en küçük değerdir.

Örnek:
    BST elemanları:
        20, 30, 40, 50, 60, 70, 80

    50'nin ardılı 60'tır.
    40'ın ardılı 50'dir.
    80'in ardılı yoktur.

BST'de ardıl bulma mantığı:
    1. Eğer aranan düğümün sağ alt ağacı varsa:
        Ardıl = sağ alt ağacın minimum elemanı

    2. Eğer sağ alt ağacı yoksa:
        Kökten başlayarak aranan değere doğru ilerlenir.
        Aranan değerden büyük olan en yakın ata aday olarak tutulur.

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


# 4. MINIMUM DÜĞÜM BULMA

def find_min_node(root):
    """
    Verilen alt ağaçtaki minimum düğümü bulur.

    BST'de minimum eleman daima en soldaki düğümdür.
    """

    if root is None:
        return None

    current = root

    while current.left is not None:
        current = current.left

    return current


# 5. ARDIL BULMA

def find_successor(root, target):
    """
    BST içinde verilen değerin ardılını bulur.

    Parametreler:
        root   : BST'nin kökü
        target : Ardılı bulunacak değer

    Geri dönüş:
        Ardıl düğüm varsa Node döner.
        Ardıl yoksa None döner.
    """

    # Önce aranan değerin ağaçta olup olmadığını bulalım.
    target_node = search_node(root, target)

    if target_node is None:
        return None

    # Durum 1:
    # Eğer düğümün sağ alt ağacı varsa,
    # ardıl sağ alt ağacın minimum elemanıdır.
    if target_node.right is not None:
        return find_min_node(target_node.right)

    # Durum 2:
    # Sağ alt ağaç yoksa kökten başlayarak ardıl adayı aranır.
    successor = None
    current = root

    while current is not None:

        if target < current.data:
            # current, target'tan büyük olduğu için ardıl adayı olabilir.
            successor = current
            current = current.left

        elif target > current.data:
            current = current.right

        else:
            break

    return successor


# 6. INORDER DOLAŞMA

def inorder(root):
    """
    BST'yi inorder şekilde yazdırır.

    Inorder:
        Sol -> Kök -> Sağ

    BST'de inorder çıktı küçükten büyüğe sıralıdır.
    Ardıl mantığını görmek için faydalıdır.
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

    print("\n\nArdıl bulma sonuçları:")

    for i in range(len(test_values)):
        target = test_values[i]
        successor = find_successor(root, target)

        if successor is not None:
            print(target, "değerinin ardılı:", successor.data)
        else:
            print(target, "değerinin ardılı yok veya değer ağaçta bulunamadı.")

    print("\nKarmaşıklık")
    print("En iyi durum: O(1)")
    print("Ortalama durum: O(log n)  dengeli ağaçta")
    print("En kötü durum: O(n)       ağaç liste gibi olursa")
    print("Bellek karmaşıklığı: O(1)")
