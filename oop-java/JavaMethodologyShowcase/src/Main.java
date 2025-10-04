import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.println("=================================================");
        System.out.println("     Welcome to the Java Methodology Showcase!   ");
        System.out.println("=================================================");

        // Using a single scanner for the entire application
        try (Scanner scanner = new Scanner(System.in)) {

            // 1. Array Parameter Passing Demo
            System.out.println("\n--- 1. ARRAY PARAMETER HANDLER ---");
            ArrayParameterHandler.runDemo(scanner);

            // 2. Core Method Demos (Factorial, Full Name)
            System.out.println("\n--- 2. CORE METHOD DEMOS ---");
            CoreMethods.runDemo(scanner);

            // 3. Recursive Functions Demo (Factorial, Fibonacci)
            System.out.println("\n--- 3. RECURSIVE FUNCTIONS DEMO ---");
            RecursiveFunctions.runDemo(scanner);

            // 4. Advanced Method Demos (Overloading, Conditional Logic)
            System.out.println("\n--- 4. ADVANCED METHOD DEMOS ---");
            AdvancedMethods.runDemo();

        } catch (Exception e) {
            System.err.println("An unexpected error occurred during execution: " + e.getMessage());
        }

        System.out.println("\n=================================================");
        System.out.println("     All Method Demos Completed!                 ");
        System.out.println("=================================================");
    }
}