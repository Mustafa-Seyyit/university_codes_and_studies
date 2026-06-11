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
        data < root.data ise sol tarafa,
        data > root.data ise sağ tarafa gidilir.
    """

    if root is None:
        return Node(data)

    if data < root.data:
        root.left = insert(root.left, data)

    elif data > root.data:
        root.right = insert(root.right, data)

    # Eşit değerler tekrar eklenmez.
    return root


# 3. ITERATIVE MINIMUM BULMA

def find_min_iterative(root):
    """
    BST'de minimum elemanı iterative şekilde bulur.

    Mantık:
        Minimum değer için sürekli sol çocuğa gidilir.
        Sol çocuk yoksa bulunduğumuz düğüm minimumdur.

    Geri dönüş:
        Minimum düğüm

    Eğer ağaç boşsa:
        None döner.
    """

    if root is None:
        return None

    current = root

    while current.left is not None:
        current = current.left

    return current


# 4. RECURSIVE MINIMUM BULMA

def find_min_recursive(root):
    """
    BST'de minimum elemanı recursive şekilde bulur.

    Mantık:
        Sol çocuk varsa minimum sol alt ağaçtadır.
        Sol çocuk yoksa mevcut düğüm minimumdur.
    """

    if root is None:
        return None

    if root.left is None:
        return root

    return find_min_recursive(root.left)


# 5. INORDER DOLAŞMA

def inorder(root):
    """
    BST'yi inorder şekilde yazdırır.

    Inorder:
        Sol -> Kök -> Sağ

    BST'de inorder sonuç küçükten büyüğe sıralıdır.
    """

    if root is not None:
        inorder(root.left)
        print(root.data, end=" ")
        inorder(root.right)


# 6. PROGRAMI ÇALIŞTIRMA

if __name__ == "__main__":

    root = None

    values = [50, 30, 70, 20, 40, 60, 80, 10]

    for i in range(len(values)):
        root = insert(root, values[i])

    print("BST elemanları:")
    print(values)

    print("\nInorder gösterim:")
    inorder(root)

    min_node_iterative = find_min_iterative(root)
    min_node_recursive = find_min_recursive(root)

    print("\n\nIterative minimum bulma:")
    if min_node_iterative is not None:
        print("Minimum değer:", min_node_iterative.data)
    else:
        print("Ağaç boş.")

    print("\nRecursive minimum bulma:")
    if min_node_recursive is not None:
        print("Minimum değer:", min_node_recursive.data)
    else:
        print("Ağaç boş.")

    print("\nKarmaşıklık")
    print("En iyi durum: O(1)")
    print("Ortalama durum: O(log n)  dengeli ağaçta")
    print("En kötü durum: O(n)       ağaç sola doğru liste gibi olursa")
    print("Bellek karmaşıklığı iterative: O(1)")
    print("Bellek karmaşıklığı recursive: O(h)")
    print("h = ağacın yüksekliği")
