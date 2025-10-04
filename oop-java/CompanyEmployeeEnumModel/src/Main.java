public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("  Company and Employee Enum Model Demo   ");
        System.out.println("=========================================");

        // 1. Create an Employee object
        Employee employee1 = new Employee(101, "Mustafa Demir");

        // 2. Create a Company object using an enum value
        Company company1 = new Company(employee1, CompanyName.GOOGLE);

        System.out.println("\n--- Company 1 Details ---");
        company1.displayCompanyInfo();

        // 3. Create another Employee and Company pair
        Employee employee2 = new Employee(205, "Seyyit Kaya");
        Company company2 = new Company(employee2, CompanyName.MICROSOFT);

        System.out.println("\n--- Company 2 Details ---");
        company2.displayCompanyInfo();

        // 4. Demonstrate retrieving data
        System.out.println("\n--- Data Retrieval Example ---");

        // Get the employee's name via the Company object
        String empName = company1.getEmployee().getName();
        String compName = company1.getCompanyName().name();

        System.out.println(empName + " works at " + compName + ".");

        // Enum usage demonstration
        System.out.println("Is Company 2 a member of the enum? " +
                (company2.getCompanyName() == CompanyName.MICROSOFT));
    }
}