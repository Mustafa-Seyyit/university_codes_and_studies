import java.util.Arrays;

public class ArraySortingDemo {
    public static void runDemo() {
        System.out.println("--- 2. ARRAY SORTING DEMO ---");

        int[] dataArray = {8, 2, 1, 3, -1, 99};

        // Sorts the entire array
        Arrays.sort(dataArray);
        System.out.println("Full Sort Result (Ascending): " + Arrays.toString(dataArray));

        int[] partialArray = {9, 7, 4, 3, 2, 1};
        // Sorts elements from index 1 (7) up to index 4 (3), non-inclusive.
        // Elements at index 0 (9) and index 4 (2), 5 (1) remain untouched.
        Arrays.sort(partialArray, 1, 4);
        System.out.println("Partial Sort Result (Indices 1-3 sorted): " + Arrays.toString(partialArray));
    }
}