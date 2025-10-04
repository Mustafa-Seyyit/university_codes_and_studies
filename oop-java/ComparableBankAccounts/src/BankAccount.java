public class BankAccount implements Comparable<BankAccount> {
    // Fields are now private for encapsulation
    private final int accountId;
    private final String holderName;
    private double balance; // Balance can change

    public BankAccount(int accountId, String holderName, double balance) {
        this.accountId = accountId;
        this.holderName = holderName;
        this.balance = balance;
    }

    /** Subtracts a positive amount from the balance. */
    public void withdraw(double amount) {
        if (amount > 0 && balance >= amount) {
            balance -= amount;
        } else if (amount <= 0) {
            System.out.println("Withdrawal failed: Amount must be positive.");
        } else {
            System.out.println("Withdrawal failed: Insufficient balance.");
        }
    }

    /** Adds a positive amount to the balance. */
    public void deposit(double amount) {
        if (amount > 0) {
            balance += amount;
        } else {
            System.out.println("Deposit failed: Amount must be positive.");
        }
    }

    // --- Accessor Methods (Getters) ---
    public String getHolderName() {
        return holderName;
    }

    public double getBalance() {
        return balance;
    }

    /**
     * Defines the natural sorting order for BankAccount objects,
     * which is based alphabetically on the holder's name.
     */
    @Override
    public int compareTo(BankAccount otherAccount) {
        return this.holderName.compareTo(otherAccount.holderName);
    }

    /** Provides a formatted string representation of the account. */
    @Override
    public String toString() {
        return String.format("Account ID: %d | Holder: %s | Balance: $%.2f",
                accountId, holderName, balance);
    }
}