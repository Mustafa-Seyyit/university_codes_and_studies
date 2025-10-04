import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        // Use try-with-resources to ensure the single Scanner instance is closed safely
        try (Scanner scanner = new Scanner(System.in)) {

            // Initial account setup
            Account account = new Account("Mustafa", 8888.00);

            System.out.println("=========================================");
            System.out.println("  Welcome to the Bank Account Simulator  ");
            System.out.println("Holder: " + account.getOwnerName());
            System.out.printf("Current Balance: $%.2f\n", account.getBalance());
            System.out.println("=========================================");

            // --- Withdrawal Process ---
            double withdrawalAmount;

            System.out.print("\nEnter the amount you want to withdraw: $");

            // Check if the next input is a number
            if (scanner.hasNextDouble()) {
                withdrawalAmount = scanner.nextDouble();

                // Pass the amount and the scanner object to the secure withdraw method
                account.withdraw(withdrawalAmount, scanner);

                // Display the final balance
                System.out.printf("\n--- TRANSACTION SUMMARY ---\n");
                System.out.printf("Final Balance for %s: $%.2f\n", account.getOwnerName(), account.getBalance());
            } else {
                System.err.println("Invalid input for withdrawal amount. Must be a number.");
            }

        } catch (InputMismatchException e) {
            System.err.println("Input Error: Please ensure all inputs are in the correct format.");
        }
    }
}