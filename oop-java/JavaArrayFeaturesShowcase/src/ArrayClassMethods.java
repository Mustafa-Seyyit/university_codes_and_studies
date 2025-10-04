import java.util.Arrays;
import java.util.List;

public class ArrayClassMethods {
    public static void runDemo() {
        System.out.println("--- 3. ARRAY UTILITY METHODS DEMO (asList, copy, fill) ---");

        // --- Arrays.asList Example ---
        String[] cities = {"Artvin", "Tokat", "Zile"};
        List<String> cityList = Arrays.asList(cities);

        System.out.println("asList Demo (Array to List): " + cityList);

        // --- Arrays.copyOfRange Example ---
        int[] originalArray = {4, 55, 188, 3};
        // Copies from index 1 (inclusive) to 3 (exclusive) -> {55, 188}
        int[] newArrayRange = Arrays.copyOfRange(originalArray, 1, 3);
        System.out.println("copyOfRange Demo (Indices 1-2): " + Arrays.toString(newArrayRange));

        // --- Arrays.fill Example ---
        int[] arrayToFill = new int[5];
        // Fills the entire array with the value 7
        Arrays.fill(arrayToFill, 7);

        System.out.println("fill Demo (All elements set to 7): " + Arrays.toString(arrayToFill));
    }
}