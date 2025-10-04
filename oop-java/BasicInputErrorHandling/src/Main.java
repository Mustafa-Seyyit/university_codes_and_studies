import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        // Use try-with-resources to ensure the Scanner is automatically closed
        try (Scanner scanner = new Scanner(System.in)) {

            System.out.println("=========================================");
            System.out.println("  Basic Input Error Handling Demo        ");
            System.out.println("=========================================");

            System.out.print("Please enter an integer: ");

            try {
                int inputNumber = scanner.nextInt();
                System.out.println("Success! You entered the integer: " + inputNumber);

            } catch (InputMismatchException exception) {
                // Catching the specific error when the input type doesn't match the expected type (int)
                System.err.println("\n--- ERROR ---");
                System.err.println("Input Mismatch! You must enter a valid integer.");
                System.err.println("The program caught the exception and avoided crashing.");
            }

        } // Scanner automatically closes here

        System.out.println("\nProgram finished successfully.");
    }
}