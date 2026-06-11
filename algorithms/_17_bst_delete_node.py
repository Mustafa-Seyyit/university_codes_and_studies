"""
    Binary Search Tree (BST) içinde düğüm silme

BST silme işleminde 3 temel durum vardır:

    1. Silinecek düğüm yaprak düğümdür.
        - Doğrudan silinir.

    2. Silinecek düğümün tek çocuğu vardır.
        - Düğümün yerine çocuğu bağlanır.

    3. Silinecek düğümün iki çocuğu vardır.
        - Sağ alt ağacındaki minimum değer bulunur.
        - Bu değer silinecek düğümün yerine yazılır.
        - Sonra o minimum düğüm sağ alt ağaçtan silinir.

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

    Küçük değerler sol tarafa,
    büyük değerler sağ tarafa eklenir.
    """

    if root is None:
        return Node(data)

    if data < root.data:
        root.left = insert(root.left, data)

    elif data > root.data:
        root.right = insert(root.right, data)

    # Eşit değerler tekrar eklenmez.
    return root


# 3. MINIMUM DÜĞÜM BULMA

def find_min_node(root):
    """
    Verilen alt ağaçtaki minimum düğümü bulur.

    BST'de minimum eleman her zaman en soldaki düğümdür.
    """

    current = root

    while current is not None and current.left is not None:
        current = current.left

    return current


# 4. BST'DE DÜĞÜM SİLME

def delete_node(root, target):
    """
    BST içinde verilen değere sahip düğümü siler.

    Parametreler:
        root   : Ağacın kökü
        target : Silinecek değer

    Geri dönüş:
        Silme işleminden sonraki kök düğüm
    """

    # Ağaç boşsa silinecek bir şey yoktur.
    if root is None:
        return root

    # Silinecek değer kökten küçükse sol alt ağaçta ara.
    if target < root.data:
        root.left = delete_node(root.left, target)

    # Silinecek değer kökten büyükse sağ alt ağaçta ara.
    elif target > root.data:
        root.right = delete_node(root.right, target)

    # Silinecek düğüm bulundu.
    else:

        # Durum 1 ve Durum 2:
        # Sol çocuk yoksa sağ çocuk yukarı bağlanır.
        if root.left is None:
            temp = root.right
            root = None
            return temp

        # Sağ çocuk yoksa sol çocuk yukarı bağlanır.
        elif root.right is None:
            temp = root.left
            root = None
            return temp

        # Durum 3:
        # Düğümün iki çocuğu varsa:
        # Sağ alt ağacın minimum düğümü bulunur.
        successor = find_min_node(root.right)

        # Ardılın değeri mevcut düğüme kopyalanır.
        root.data = successor.data

        # Ardıl düğüm sağ alt ağaçtan silinir.
        root.right = delete_node(root.right, successor.data)

    return root


# 5. BST'DE DEĞER ARAMA

def search(root, target):
    """
    BST içinde verilen değeri arar.
    """

    current = root

    while current is not None:

        if current.data == target:
            return True

        elif target < current.data:
            current = current.left

        else:
            current = current.right

    return False


# 6. INORDER DOLAŞMA

def inorder(root):
    """
    BST'yi inorder şekilde yazdırır.

    Inorder:
        Sol -> Kök -> Sağ

    BST'de inorder çıktı küçükten büyüğe sıralı olur.
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

    print("Başlangıç BST elemanları:")
    print(values)

    print("\nBaşlangıç inorder gösterim:")
    inorder(root)

    # 1. durum: Yaprak düğüm silme
    print("\n\n20 siliniyor. 20 yaprak düğümdür.")
    root = delete_node(root, 20)
    print("Inorder:")
    inorder(root)

    # 2. durum: Tek çocuklu düğüm silme için önce 65 ekleyelim.
    print("\n\n65 ekleniyor.")
    root = insert(root, 65)
    print("Inorder:")
    inorder(root)

    print("\n\n60 siliniyor. 60 tek çocuklu düğümdür.")
    root = delete_node(root, 60)
    print("Inorder:")
    inorder(root)

    # 3. durum: İki çocuklu düğüm silme
    print("\n\n70 siliniyor. 70 iki çocuklu düğümdür.")
    root = delete_node(root, 70)
    print("Inorder:")
    inorder(root)

    print("\n\nArama testi:")
    print("70 ağaçta var mı?", search(root, 70))
    print("65 ağaçta var mı?", search(root, 65))

    print("\nKarmaşıklık")
    print("En iyi durum: O(1)")
    print("Ortalama durum: O(log n)  dengeli ağaçta")
    print("En kötü durum: O(n)       ağaç liste gibi olursa")
    print("Bellek karmaşıklığı recursive: O(h)")
    print("h = ağacın yüksekliği")
