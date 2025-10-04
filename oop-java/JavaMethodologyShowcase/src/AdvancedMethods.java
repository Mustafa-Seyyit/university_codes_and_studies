public class AdvancedMethods {

    public static void runDemo() {
        // --- Method Overloading Demo ---
        System.out.println("\n-- Method Overloading Demo --");
        System.out.println("Method with 3 parameters (2, 3, 5): " + multiply(2, 3, 5));
        System.out.println("Method with 2 parameters (4, 6): " + multiply(4, 6));

        // --- Simple Conditional Logic Demo ---
        System.out.println("\n-- Conditional Return Demo (Checking Modulo 5) --");
        evaluateNumbers(10, 5); // Expected: Both
        evaluateNumbers(7, 10); // Expected: Second only
        evaluateNumbers(5, 7);  // Expected: First only
        evaluateNumbers(8, 9);  // Expected: Neither

        // --- Static Math Method Demo ---
        System.out.println("\n-- Static Utility Method Demo (Math.pow) --");
        int base = 3;
        int exponent = 4;
        System.out.printf("%d raised to the power of %d is: %.0f\n", base, exponent, Math.pow(base, exponent)); // 3^4 = 81
    }

    /** Multiplies three integers (Overload 1). */
    private static int multiply(int a, int b, int c) {
        return a * b * c;
    }

    /** Multiplies two integers (Overload 2). */
    private static int multiply(int a, int b) {
        return a * b;
    }

    /** Executes logic and prints the result based on return value. */
    private static void evaluateNumbers(int num1, int num2) {
        char result = checkModulo(num1, num2);
        System.out.printf("Evaluating (%d, %d): ", num1, num2);
        if (result == 'a')
            System.out.println("Both numbers are divisible by 5.");
        else if (result == 'y')
            System.out.println("Second number is divisible by 5 only.");
        else if (result == 'x')
            System.out.println("First number is divisible by 5 only.");
        else
            System.out.println("Neither number is divisible by 5.");
    }

    /** Checks divisibility by 5 and returns a code. */
    private static char checkModulo(int num1, int num2) {
        boolean div1 = num1 % 5 == 0;
        boolean div2 = num2 % 5 == 0;

        if (div1 && div2)
            return 'a';
        else if (div2)
            return 'y';
        else if (div1)
            return 'x';
        else
            return 'n';
    }
}