import java.util.Scanner;

public class ArrayParameterHandler {

    // Constant for array size, for clean code.
    private static final int ARRAY_SIZE = 3;

    public static void runDemo(Scanner scanner) {
        String[] inputArray = new String[ARRAY_SIZE];

        System.out.println("Please enter " + ARRAY_SIZE + " string elements:");
        for (int i = 0; i < ARRAY_SIZE; i++) {
            System.out.print((i + 1) + ". element: ");
            inputArray[i] = scanner.nextLine();
        }

        System.out.println("Array contents received by the method:");
        printArray(inputArray);
    }

    /** Prints all elements of a String array. */
    private static void printArray(String[] array) {
        for (String element : array) {
            System.out.println(element);
        }
    }
}