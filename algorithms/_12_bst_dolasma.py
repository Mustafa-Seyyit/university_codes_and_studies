"""
    Binary Search Tree (BST) Dolaşma Yöntemleri

3 farklı BST dolaşma yöntemi vardır:

    1. Inorder Traversal
        Sol -> Kök -> Sağ

    2. Preorder Traversal
        Kök -> Sol -> Sağ

    3. Postorder Traversal
        Sol -> Sağ -> Kök

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

    BST kuralı:
        Küçük değerler sol tarafa,
        Büyük değerler sağ tarafa eklenir.
    """

    # Ağaç boşsa yeni düğüm kök olur.
    if root is None:
        return Node(data)

    # Eklenecek değer kökten küçükse sol tarafa git.
    if data < root.data:
        root.left = insert(root.left, data)

    # Eklenecek değer kökten büyükse sağ tarafa git.
    elif data > root.data:
        root.right = insert(root.right, data)

    # Eğer değer eşitse bu örnekte tekrar eklemiyoruz.
    return root


# 3. INORDER TRAVERSAL

"""
Inorder Traversal:
    Sol -> Kök -> Sağ

BST üzerinde inorder dolaşma yapıldığında elemanlar
küçükten büyüğe sıralı olarak gelir.

Örnek:
    Ağacın elemanları: 50, 30, 70, 20, 40, 60, 80

Inorder sonucu:
    20 30 40 50 60 70 80
"""


def inorder(root):
    """
    Inorder dolaşma yapar.
    """

    if root is not None:
        inorder(root.left)
        print(root.data, end=" ")
        inorder(root.right)


# 4. PREORDER TRAVERSAL

"""
Preorder Traversal:
    Kök -> Sol -> Sağ

Preorder dolaşma genellikle ağacın kopyasını çıkarmak
veya ağacın yapısını kökten başlayarak görmek için kullanılır.
"""


def preorder(root):
    """
    Preorder dolaşma yapar.
    """

    if root is not None:
        print(root.data, end=" ")
        preorder(root.left)
        preorder(root.right)


# ============================================================
# 5. POSTORDER TRAVERSAL
# ============================================================

"""
Postorder Traversal:
    Sol -> Sağ -> Kök

Postorder dolaşma genellikle ağacı silme işlemlerinde kullanılır.
Çünkü önce çocuklar, sonra kök işlenir.
"""


def postorder(root):
    """
    Postorder dolaşma yapar.
    """

    if root is not None:
        postorder(root.left)
        postorder(root.right)
        print(root.data, end=" ")


# 6. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    root = None

    values = [50, 30, 70, 20, 40, 60, 80]

    # Elemanları BST'ye ekle
    for i in range(len(values)):
        root = insert(root, values[i])

    print("BST elemanları:")
    print(values)

    print("\nInorder Traversal")
    print("Sol -> Kök -> Sağ")
    inorder(root)

    print("\n\nPreorder Traversal")
    print("Kök -> Sol -> Sağ")
    preorder(root)

    print("\n\nPostorder Traversal")
    print("Sol -> Sağ -> Kök")
    postorder(root)

    print("\n\nKarmaşıklık")
    print("Her dolaşma yöntemi tüm düğümleri bir kez ziyaret eder.")
    print("Zaman karmaşıklığı: O(n)")
    print("Bellek karmaşıklığı: O(h)")
    print("h = ağacın yüksekliği")
