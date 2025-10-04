import java.util.ArrayList;
import java.util.Collections;

public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("    Bank Account Sorting and Transaction Demo    ");
        System.out.println("=========================================");

        // 1. Create BankAccount objects
        // Using descriptive names for better readability
        BankAccount accMustafa = new BankAccount(101, "Mustafa Y.", 888.88);
        BankAccount accFatmanur = new BankAccount(102, "Fatmanur K.", 222.22);
        BankAccount accDeniz = new BankAccount(103, "Deniz O.", 1666.00);

        // 2. Add accounts to an ArrayList
        ArrayList<BankAccount> myAccounts = new ArrayList<>();
        myAccounts.add(accMustafa);
        myAccounts.add(accFatmanur);
        myAccounts.add(accDeniz);

        System.out.println("\n--- Initial State ---");
        for (BankAccount account : myAccounts) {
            System.out.println(account);
        }

        // 3. Sort the list using the compareTo implementation (by holder name)
        Collections.sort(myAccounts);

        System.out.println("\n--- Sorted State (by Name) and Transactions ---");

        final double withdrawalAmount = 500.00;

        // 4. Iterate through the sorted list, perform a transaction, and print
        for (BankAccount account : myAccounts) {
            System.out.println("Processing: " + account.getHolderName());

            // Perform the transaction
            account.withdraw(withdrawalAmount);

            // Print the updated state
            System.out.println("  -> New State: " + account);
        }

        System.out.println("\n--- Transaction Note ---");
        System.out.println("Note: Mustafa Y. and Fatmanur K. likely failed the withdrawal due to insufficient balance.");
    }
}