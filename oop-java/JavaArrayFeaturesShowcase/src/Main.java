import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.println("=================================================");
        System.out.println("  Welcome to the Java Array Features Showcase!   ");
        System.out.println("=================================================");

        // 1. Array Search Demo
        ArraySearchDemo.runDemo();
        System.out.println("\n-------------------------------------------------");

        // 2. Array Sorting Demo
        ArraySortingDemo.runDemo();
        System.out.println("\n-------------------------------------------------");

        // 3. Array Class Methods Demo (asList, copyOfRange, fill)
        ArrayClassMethods.runDemo();
        System.out.println("\n-------------------------------------------------");

        // 4. Array Comparison Demo (equals)
        ArrayComparison.runDemo();
        System.out.println("\n-------------------------------------------------");

        // 5. Multi-Dimensional Array Demo
        MultiDimensionalArrayDemo.runDemo();
        System.out.println("\n-------------------------------------------------");

        // 6. Custom Matrix Addition Demo (Requires user input)
        // Note: Running this demo requires closing the Scanner resource inside the method.
        ArrayCustomMethods.runMatrixAdditionDemo();

        System.out.println("=================================================");
        System.out.println("  All Array Demos Completed!                     ");
        System.out.println("=================================================");
    }
}