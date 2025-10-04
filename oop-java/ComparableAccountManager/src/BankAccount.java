public class BankAccount implements Comparable<BankAccount> {
    private int accountNo;
    private String holderName;
    private double balance;

    // Public Constructor
    public BankAccount(int accountNo, String holderName, double balance) {
        this.accountNo = accountNo;
        this.holderName = holderName;

        // Basic validation for initial balance
        this.balance = (balance > 0.0) ? balance : 0.0;
    }

    // --- Transaction Methods ---

    /** Deposits a positive amount to the account. */
    public void deposit(double amount) {
        if (amount > 0) {
            this.balance += amount;
        } else {
            System.err.println("Deposit amount must be positive.");
        }
    }

    /** Withdraws a positive amount from the account if sufficient funds exist. */
    public boolean withdraw(double amount) {
        if (amount > 0 && this.balance >= amount) {
            this.balance -= amount;
            return true;
        } else {
            System.err.println("Withdrawal failed: Insufficient funds or invalid amount.");
            return false;
        }
    }

    // --- Accessor (Getter) Methods ---

    public int getAccountNo() {
        return accountNo;
    }

    public String getHolderName() {
        return holderName;
    }

    public double getBalance() {
        return balance;
    }

    // --- Sorting and Display Methods ---

    /** Defines the natural order: sort accounts alphabetically by holder name. */
    @Override
    public int compareTo(BankAccount other) {
        // String's compareTo method provides alphabetical sorting
        return this.holderName.compareTo(other.holderName);
    }

    /** Provides a formatted string representation of the object. */
    @Override
    public String toString() {
        return String.format("Account No: %d, Holder: %s, Balance: $%.2f",
                accountNo, holderName, balance);
    }
}