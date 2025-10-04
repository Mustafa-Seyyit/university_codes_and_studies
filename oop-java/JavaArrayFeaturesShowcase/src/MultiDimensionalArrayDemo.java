import java.util.Arrays;

public class MultiDimensionalArrayDemo {
    public static void runDemo() {
        System.out.println("--- 5. MULTI-DIMENSIONAL ARRAY DEMO ---");

        // Accessing Multi-Dimensional Array Elements
        int[][] matrix = {{1, 2}, {3, 4}};
        System.out.println("2D Array Example: {{1, 2}, {3, 4}}");
        System.out.println("Element at [1][0]: " + matrix[1][0]);

        // Printing 2D array content easily using deepToString
        System.out.println("Matrix Content (deepToString): " + Arrays.deepToString(matrix));
    }
}