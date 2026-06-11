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

    Eğer ağaç boşsa yeni düğüm kök olur.
    """

    if root is None:
        return Node(data)

    if data < root.data:
        root.left = insert(root.left, data)

    elif data > root.data:
        root.right = insert(root.right, data)

    # Eşit değerleri bu örnekte tekrar eklemiyoruz.
    return root


# 3. RECURSIVE ARAMA

def search_recursive(root, target):
    """
    BST içinde recursive olarak değer arar.

    Parametreler:
        root   : Ağacın kökü
        target : Aranacak değer

    Geri dönüş:
        True  -> değer bulundu
        False -> değer bulunamadı
    """

    # Ağaç boşsa veya yaprak sonrasına geldiysek değer yoktur.
    if root is None:
        return False

    # Aranan değer kökteyse bulundu.
    if root.data == target:
        return True

    # Aranan değer kökten küçükse sol alt ağaçta aranır.
    if target < root.data:
        return search_recursive(root.left, target)

    # Aranan değer kökten büyükse sağ alt ağaçta aranır.
    return search_recursive(root.right, target)


# 4. ITERATIVE ARAMA

def search_iterative(root, target):
    """
    BST içinde döngü kullanarak değer arar.

    Recursive yerine while döngüsü kullanılır.
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


# 5. BULUNAN DÜĞÜMÜ DÖNDÜREN ARAMA

def search_node(root, target):
    """
    Aranan değeri içeren düğümü döndürür.

    Eğer değer bulunamazsa None döner.
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


# ============================================================
# 6. INORDER DOLAŞMA
# ============================================================

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

    print("BST elemanları:")
    print(values)

    print("\nInorder gösterim:")
    inorder(root)

    target1 = 60
    target2 = 25

    print("\n\nRecursive arama")
    print(target1, "bulundu mu?", search_recursive(root, target1))
    print(target2, "bulundu mu?", search_recursive(root, target2))

    print("\nIterative arama")
    print(target1, "bulundu mu?", search_iterative(root, target1))
    print(target2, "bulundu mu?", search_iterative(root, target2))

    print("\nDüğüm döndüren arama")
    found_node = search_node(root, target1)

    if found_node is not None:
        print(target1, "değeri bulundu. Düğüm değeri:", found_node.data)
    else:
        print(target1, "değeri bulunamadı.")

    print("\nKarmaşıklık")
    print("En iyi durum: O(1)")
    print("Ortalama durum: O(log n)  dengeli ağaçta")
    print("En kötü durum: O(n)       ağaç liste gibi olursa")
    print("Bellek karmaşıklığı recursive: O(h)")
    print("Bellek karmaşıklığı iterative: O(1)")
    print("h = ağacın yüksekliği")
