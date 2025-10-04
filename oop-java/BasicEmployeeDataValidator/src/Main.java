import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {

    // Helper method to consolidate repetitive input and object creation logic
    public static Worker createWorkerFromInput(Scanner scanner) {
        Worker worker = new Worker();

        try {
            System.out.println("\n--- Entering Worker Data ---");
            System.out.print("Enter name: ");
            // Use next() to read the name (single token/word)
            String name = scanner.next();
            worker.setName(name);

            System.out.print("Enter salary: $");
            double salary = scanner.nextDouble();

            // The setSalary method contains the validation logic
            worker.setSalary(salary);

        } catch (InputMismatchException e) {
            System.err.println("\nInput Error: Invalid format for salary. Data entry skipped for this field.");
            // Clears the buffer to allow nextDouble to work on the next iteration
            scanner.nextLine();
        } catch (IllegalArgumentException e) {
            // Catches the error thrown by Worker.setSalary for negative values
            System.err.println("Exception: " + e.getMessage());
        }

        return worker;
    }

    public static void main(String[] args) {

        // Use try-with-resources to ensure the single Scanner instance is closed safely
        try (Scanner scanner = new Scanner(System.in)) {

            System.out.println("=========================================");
            System.out.println("  Employee Data and Validation Demo      ");
            System.out.println("=========================================");

            // Create and process three workers using the helper method
            Worker w1 = createWorkerFromInput(scanner);
            System.out.println("\n--- Worker 1 Info ---");
            w1.displayInfo();

            Worker w2 = createWorkerFromInput(scanner);
            System.out.println("\n--- Worker 2 Info ---");
            w2.displayInfo();

            Worker w3 = createWorkerFromInput(scanner);
            System.out.println("\n--- Worker 3 Info ---");
            w3.displayInfo();

            System.out.println("=========================================");
            // Call the static counter getter method on any instance or the class itself (Worker.getCounter())
            System.out.println("Total worker objects created: " + Worker.getCounter());
            System.out.println("=========================================");

        } catch (Exception e) {
            System.err.println("An unexpected system error occurred: " + e.getMessage());
        }
    }
}