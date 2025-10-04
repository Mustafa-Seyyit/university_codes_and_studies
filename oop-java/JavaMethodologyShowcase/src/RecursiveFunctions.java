import java.util.Scanner;

public class RecursiveFunctions {

    public static void runDemo(Scanner scanner) {
        // --- Recursive Factorial Example ---
        System.out.println("\n-- Recursive Factorial Demo --");
        System.out.print("Enter a number for factorial calculation (recursive): ");
        if (scanner.hasNextInt()) {
            int value = scanner.nextInt();
            scanner.nextLine(); // Consume newline
            long result = factorial(value);
            System.out.printf("Recursive Factorial of %d is: %d\n", value, result);
        } else {
            System.out.println("Skipping recursive factorial demo due to invalid input.");
            scanner.nextLine();
        }

        // --- Summation Example ---
        System.out.println("\n-- Recursive Summation Demo --");
        System.out.println("Sum of numbers up to 5: " + sumToN(5)); // Expected: 15 (5+4+3+2+1)

        // --- Fibonacci Sequence Example ---
        System.out.println("\n-- Recursive Fibonacci Sequence Demo --");
        System.out.println("The 6th element of Fibonacci sequence is: " + fibonacci(6));   // Expected: 8
        System.out.println("The 10th element of Fibonacci sequence is: " + fibonacci(10)); // Expected: 55
    }

    /** Calculates factorial of a number recursively. */
    private static long factorial(int number) {
        if (number < 0) return -1;
        if (number == 0) return 1;
        return number * factorial(number - 1);
    }

    /** Calculates the sum of numbers from N down to 0 recursively. */
    private static int sumToN(int number) {
        if (number == 0) return 0;
        return number + sumToN(number - 1);
    }

    /** Finds the Nth element of the Fibonacci sequence recursively. */
    private static int fibonacci(int number) {
        if (number <= 0) return 0;
        else if (number == 1) return 1;
        // Base case for 2 is covered by the general case
        return fibonacci(number - 1) + fibonacci(number - 2);
    }
}