import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        // Use try-with-resources for safe Scanner management
        try (Scanner scanner = new Scanner(System.in)) {

            System.out.println("=========================================");
            System.out.println("  Employee Data Entry:                   ");
            System.out.println("=========================================");

            // Get employee details
            System.out.print("Enter Full Name: ");
            String name = scanner.nextLine();

            System.out.print("Enter Gross Salary (double): $");
            double salary = scanner.nextDouble();

            System.out.print("Enter Work Hours per week (int): ");
            int workHours = scanner.nextInt();

            System.out.print("Enter Hire Year (int, e.g., 2004): ");
            int hireYear = scanner.nextInt();

            // Create employee object and display results using the toString() method
            Employee employee = new Employee(name, salary, workHours, hireYear);
            System.out.println("\n--- Compensation Report ---");
            System.out.println(employee); // Calls employee.toString() automatically

        } catch (InputMismatchException e) {
            System.err.println("\nError: Please ensure you enter the correct data types (numbers for salary, hours, and year).");
        } catch (Exception e) {
            System.err.println("\nAn unexpected error occurred: " + e.getMessage());
        }
    }
}