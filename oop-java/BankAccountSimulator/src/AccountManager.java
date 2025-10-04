import java.util.Scanner;

public class AccountManager {
    public static void main(String[] args) {

        // Using try-with-resources to ensure the Scanner is closed safely
        try (Scanner scanner = new Scanner(System.in)) {

            // Initialize two accounts
            Account account1 = new Account("Mustafa", 888.80);
            Account account2 = new Account("Seyyit", 222.20);

            System.out.println("=========================================");
            System.out.println("  Initial Account Balances               ");
            System.out.println("=========================================");
            System.out.printf("%s's balance: $%.2f\n", account1.getName(), account1.getBalance());
            System.out.printf("%s's balance: $%.2f\n", account2.getName(), account2.getBalance());

            // --- Deposit to Account 1 ---
            System.out.println("\nEnter deposit amount for " + account1.getName() + ":");
            double depositAmount = scanner.nextDouble();
            account1.deposit(depositAmount);
            System.out.printf("%s's NEW balance: $%.2f\n", account1.getName(), account1.getBalance());

            // --- Deposit to Account 2 ---
            System.out.println("\nEnter deposit amount for " + account2.getName() + ":");
            depositAmount = scanner.nextDouble();
            account2.deposit(depositAmount);
            System.out.printf("%s's NEW balance: $%.2f\n", account2.getName(), account2.getBalance());

        } catch (Exception e) {
            System.err.println("An input error occurred. Please enter a valid number.");
        }
    }
}