import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.println("=================================================");
        System.out.println("      Welcome to the User Interaction Toolbox!   ");
        System.out.println("=================================================");

        // Using try-with-resources to ensure the single Scanner is closed safely
        try (Scanner scanner = new Scanner(System.in)) {

            // 1. Basic Scanner Input Methods Demo
            InputScannerDemos.runBasicInputDemo(scanner);
            System.out.println("\n-------------------------------------------------");

            // 2. Iterative Word Reading Demo
            InputScannerDemos.runWordIterationDemo(scanner);
            System.out.println("\n-------------------------------------------------");

            // 3. Conditional Flow Demo (Pass/Fail)
            InputScannerDemos.runConditionalCheckDemo(scanner);
            System.out.println("\n-------------------------------------------------");

            // 4. Sum Between Two Numbers Demo
            InputScannerDemos.runSumBetweenNumbersDemo(scanner);
            System.out.println("\n-------------------------------------------------");

            // 5. Running Sum until Negative/Zero
            InputScannerDemos.runRunningSumDemo(scanner);
            System.out.println("\n-------------------------------------------------");

            // 6. Matrix Input/Output Demo
            InputScannerDemos.runMatrixInputDemo(scanner);
            System.out.println("\n-------------------------------------------------");

            // 7. Random Number Guessing Game
            RandomGame.runGuessingGame(scanner);

        } catch (Exception e) {
            System.err.println("An unexpected error occurred: " + e.getMessage());
        }

        System.out.println("\n=================================================");
        System.out.println("      All Interaction Demos Completed!           ");
        System.out.println("=================================================");
    }
}