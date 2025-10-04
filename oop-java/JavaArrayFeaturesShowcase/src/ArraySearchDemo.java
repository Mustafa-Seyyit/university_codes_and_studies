import java.util.Arrays;

public class ArraySearchDemo {
    public static void runDemo() {
        System.out.println("--- 1. ARRAY SEARCH (BINARY SEARCH) DEMO ---");

        int[] dataArray = {12, 3, 4, 1, 54, 9};

        // Binary search requires a sorted array for a reliable result.
        Arrays.sort(dataArray);
        System.out.println("Sorted Array: " + Arrays.toString(dataArray));

        int targetValue = 9;
        int index = Arrays.binarySearch(dataArray, targetValue);

        if (index >= 0) {
            System.out.printf("Element %d found at index: %d\n", targetValue, index);
        } else {
            System.out.printf("Element %d not found.\n", targetValue);
        }
    }
}