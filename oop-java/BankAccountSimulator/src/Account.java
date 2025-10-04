public class Account {
    private String accountHolderName;
    private double balance;

    // Constructor: Initializes the account with a name and a starting balance.
    public Account(String name, double initialBalance) {
        this.accountHolderName = name;

        // Ensures the initial balance is non-negative
        if (initialBalance > 0.0) {
            this.balance = initialBalance;
        } else {
            // Error message improved for clarity
            System.err.println("Warning: Initial balance must be greater than 0.0. Balance not set.");
            this.balance = 0.0;
        }
    }

    /** Deposits a specified amount into the account. */
    public void deposit(double depositAmount) {
        if (depositAmount > 0.0) {
            this.balance += depositAmount;
            System.out.printf("Successfully deposited $%.2f.\n", depositAmount);
        } else {
            System.err.println("Deposit amount must be positive.");
        }
    }

    // --- Getter Methods ---

    public double getBalance() {
        return balance;
    }

    public String getName() {
        return accountHolderName;
    }

    // Setter for Name removed for better encapsulation/security.
}