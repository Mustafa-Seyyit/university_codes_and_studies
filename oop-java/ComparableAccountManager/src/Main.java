import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Main {
    public static void main(String[] args) {

        // Initialize accounts
        BankAccount a1 = new BankAccount(101, "Mustafa", 88888.50);
        BankAccount a2 = new BankAccount(102, "Seyyit", 7777.25);
        BankAccount a3 = new BankAccount(103, "Dogan", 66666.90);
        BankAccount a4 = new BankAccount(104, "Engin", 1.00);

        // Add accounts to a List (using the List interface for better generality)
        List<BankAccount> myAccounts = new ArrayList<>();
        myAccounts.add(a1);
        myAccounts.add(a2);
        myAccounts.add(a3);
        myAccounts.add(a4);

        System.out.println("=========================================");
        System.out.println("      Initial Account List (Unsorted)    ");
        System.out.println("=========================================");
        for (BankAccount account : myAccounts) {
            System.out.println(account);
        }

        // Use Collections.sort() which calls BankAccount's compareTo method
        Collections.sort(myAccounts);

        System.out.println("\n=========================================");
        System.out.println("      Sorted Account List (By Name)      ");
        System.out.println("=========================================");
        for (BankAccount account : myAccounts) {
            System.out.println(account);
        }

        // Example of a transaction
        System.out.println("\n--- Transaction Example ---");
        System.out.println("Attempting to withdraw $50000.00 from " + a1.getHolderName());
        a1.withdraw(50000.00);
        System.out.printf("New balance for %s: $%.2f\n", a1.getHolderName(), a1.getBalance());
    }
}