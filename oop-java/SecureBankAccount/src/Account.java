import java.util.Scanner;

public class Account {
    private double balance;
    private String ownerName;
    private final int password = 1202; // Password made final as it's typically set and not changed frequently

    public Account(String name, double balance) {
        this.ownerName = name;
        // Ensure initial balance is non-negative
        this.balance = (balance >= 0) ? balance : 0.0;
    }

    /** Deposits a positive amount to the account. */
    public void deposit(double amount) { // Renamed from add()
        if (amount > 0) {
            this.balance += amount;
            System.out.printf("Successfully deposited $%.2f.\n", amount);
        } else {
            System.err.println("Deposit failed: Amount must be positive.");
        }
    }

    /** Withdraws money after a 3-attempt password verification and balance check. */
    public void withdraw(double amount, Scanner scanner) {
        if (amount <= 0) {
            System.err.println("Withdrawal amount must be greater than zero.");
            return;
        }

        int attemptCount = 0;
        int inputPass;
        final int MAX_ATTEMPTS = 3;

        do {
            System.out.printf("Attempt %d/%d: Please enter the 4-digit PIN: ", attemptCount + 1, MAX_ATTEMPTS);
            inputPass = scanner.nextInt();
            attemptCount++;
        } while (inputPass != password && attemptCount < MAX_ATTEMPTS);

        if (inputPass == password) {
            if (this.balance >= amount) {
                this.balance -= amount;
                System.out.printf("\nPIN correct. Transaction successful! Amount withdrawn: $%.2f\n", amount);
            } else {
                System.err.println("\nPIN correct, but the transaction failed: Insufficient funds ($" + this.balance + ").");
            }
        } else {
            System.err.println("\nPIN entered incorrectly 3 times. Account has been blocked.");
        }
    }

    // --- Getter and Setter Methods ---

    public double getBalance() {
        return balance;
    }

    public String getOwnerName() {
        return ownerName;
    }

    public void setOwnerName(String ownerName) {
        this.ownerName = ownerName;
    }
}