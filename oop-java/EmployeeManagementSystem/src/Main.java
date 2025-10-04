import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("  Employee Management System Demo        ");
        System.out.println("=========================================");

        // --- Employee 1: Initialized using Constructor (Good Practice) ---
        Employee employee1 = new Employee("Ali", 1001, 50.0f, 40);

        System.out.println("\n--- Employee 1 (Hardcoded Data) ---");
        employee1.displayInfo();
        System.out.printf("Salary: $%.2f\n", employee1.calculateSalary());


        // Using try-with-resources to ensure the Scanner is closed
        try (Scanner scanner = new Scanner(System.in)) {

            System.out.println("\n--- Employee 2 (User Input) ---");
            System.out.print("Enter Name: ");
            String name = scanner.nextLine(); // Read full line for name

            System.out.print("Enter SSN (int): ");
            int ssn = scanner.nextInt();

            System.out.print("Enter Hourly Wage (float): ");
            float wage = scanner.nextFloat();

            System.out.print("Enter Hours Worked (int): ");
            int hours = scanner.nextInt();

            // --- Employee 2: Initialized using Constructor from User Input ---
            Employee employee2 = new Employee(name, ssn, wage, hours);

            System.out.println("\n--- Employee 2 Information ---");
            employee2.displayInfo();
            System.out.printf("Salary: $%.2f\n", employee2.calculateSalary());

        } catch (Exception e) {
            System.err.println("Input Error: Please ensure you enter the correct data types.");
        }
    }
}