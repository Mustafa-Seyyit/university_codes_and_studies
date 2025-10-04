import java.util.Arrays;

public class ArrayComparison {
    public static void runDemo() {
        System.out.println("--- 4. ARRAY COMPARISON (Arrays.equals) DEMO ---");

        int[] array1 = {8, 2, 82, 28};
        int[] array2 = {8, 2, 82, 28};
        int[] array3 = {28, 82, 2, 8}; // Same elements, different order

        // Arrays.equals checks for element equality AND order.
        boolean isEqual1and2 = Arrays.equals(array1, array2);
        boolean isEqual1and3 = Arrays.equals(array1, array3);

        System.out.printf("Array1 vs Array2 (Same order): %b\n", isEqual1and2);
        System.out.printf("Array1 vs Array3 (Different order): %b\n", isEqual1and3);
    }
}