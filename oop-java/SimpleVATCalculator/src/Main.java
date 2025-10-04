import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        // Use try-with-resources to ensure the Scanner is closed safely
        try (Scanner scanner = new Scanner(System.in)) {

            double basePrice;
            double vatRate; // Value Added Tax Rate

            System.out.println("=========================================");
            System.out.println("       Simple VAT Calculator             ");
            System.out.println("=========================================");

            System.out.print("Enter the base price: $");
            basePrice = scanner.nextDouble();

            System.out.print("Enter the VAT rate (e.g., 18 for 18%): ");
            vatRate = scanner.nextDouble();

            // Calculate VAT amount and total price
            double vatAmount = basePrice * (vatRate / 100.0);
            double totalPrice = basePrice + vatAmount;

            System.out.println("\n-----------------------------------------");
            System.out.printf("Base Price: $%.2f\n", basePrice);
            System.out.printf("VAT Rate: %.2f%%\n", vatRate);
            System.out.printf("VAT Amount: $%.2f\n", vatAmount);
            System.out.printf("Total Price (VAT Included): $%.2f\n", totalPrice);
            System.out.println("-----------------------------------------");

        } catch (InputMismatchException e) {
            System.err.println("Input Error: Please enter valid numerical values for price and rate.");
        } catch (Exception e) {
            System.err.println("An unexpected error occurred.");
        }
    }
}