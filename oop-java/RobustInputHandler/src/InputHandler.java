import java.util.InputMismatchException;
import java.util.Scanner;

public class InputHandler {

    /**
     * Continuously prompts the user for an integer until valid input is received.
     */
    public static void main(String[] args) {

        // Using try-with-resources to ensure the Scanner object is closed automatically.
        try (Scanner scanner = new Scanner(System.in)) {
            int inputNumber;
            boolean validInput = false;

            System.out.println("--- Robust Integer Input Program ---");

            while (!validInput) {
                try {
                    System.out.print("Please enter an integer: ");

                    // Attempt to read the integer
                    inputNumber = scanner.nextInt();

                    System.out.println("Success! You entered: " + inputNumber);
                    validInput = true; // Exit the loop

                } catch (InputMismatchException e) {
                    System.out.println("Error: Invalid input type. You must enter a whole number (integer).");

                    // Consume the rest of the invalid line from the scanner buffer
                    // This prevents the program from looping infinitely on the same bad token.
                    scanner.nextLine();
                }
            }
            // Scanner is automatically closed here due to try-with-resources.

        } catch (Exception e) {
            // Catches exceptions related to Scanner initialization (rare)
            System.err.println("An unexpected system error occurred: " + e.getMessage());
        }
    }
}