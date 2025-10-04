import java.util.Scanner;

public class CoreMethods {

    // Class-level variables (fields) for state-based method demo
    private static String firstName;
    private static String lastName;

    public static void runDemo(Scanner scanner) {
        // --- Full Name Example ---
        System.out.println("\n-- Full Name Setting Demo --");
        setValue("Mustafa Seyyit", "Dogan");
        printName();

        // --- Quadratic Equation Example ---
        System.out.println("\n-- Quadratic Equation Solver Demo (a*x^2 + b*x + c = 0) --");
        // Example: x^2 - 9 = 0 (a=1, b=0, c=-9) -> Roots: 3.0, -3.0
        solveQuadratic(1, 0, -9);
        // Example: x^2 - 4x + 4 = 0 (a=1, b=-4, c=4) -> Root: 2.0
        solveQuadratic(1, -4, 4);
        // Example: x^2 + 1 = 0 (a=1, b=0, c=1) -> No real roots
        solveQuadratic(1, 0, 1);

        // --- Factorial Calculation Example ---
        System.out.println("\n-- Iterative Factorial Demo --");
        System.out.print("Enter a number for factorial calculation (iterative): ");
        if (scanner.hasNextInt()) {
            int value = scanner.nextInt();
            scanner.nextLine(); // Consume newline
            long result = calculateFactorial(value);
            System.out.printf("Factorial of %d is: %d\n", value, result);
        } else {
            System.out.println("Skipping factorial demo due to invalid input.");
            scanner.nextLine();
        }
    }

    /** Assigns values to class-level name fields. */
    private static void setValue(String first, String last) {
        firstName = first;
        lastName = last;
    }

    /** Prints the full name using class-level fields. */
    private static void printName() {
        System.out.println("Full Name: " + firstName + " " + lastName);
    }

    /** Solves a quadratic equation and prints the roots. */
    private static void solveQuadratic(int a, int b, int c) {
        double delta = (double)b * b - 4.0 * a * c;
        System.out.printf("Equation: %dx^2 + %dx + %d = 0\n", a, b, c);

        if (delta > 0) {
            double root1 = (-b + Math.sqrt(delta)) / (2.0 * a);
            // Original code error fixed: second root should be -b - sqrt(delta)
            double root2 = (-b - Math.sqrt(delta)) / (2.0 * a);
            System.out.printf("Two real roots found: Root1: %.2f, Root2: %.2f\n", root1, root2);
        } else if (delta == 0) {
            double root = -b / (2.0 * a);
            System.out.printf("One real root found: Root: %.2f\n", root);
        } else {
            System.out.println("No real roots exist.");
        }
    }

    /** Calculates factorial of a number iteratively. */
    private static long calculateFactorial(int number) {
        if (number < 0) return -1; // Indicate error
        long result = 1;
        for (int i = 1; i <= number; i++) {
            result *= i;
        }
        return result;
    }
}