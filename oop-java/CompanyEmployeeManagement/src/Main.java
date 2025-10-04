import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("  Company and Employee Management Demo   ");
        System.out.println("=========================================");

        // 1. Create Employee objects
        Employee emp1 = new Employee(1001, "Mustafa Yilmaz", 4567);
        Employee emp2 = new Employee(1002, "Seyyit Dogan", 8901);
        Employee emp3 = new Employee(1003, "Ayse Kaya", 1234);

        // 2. Add employees to a List
        List<Employee> employeeList = new ArrayList<>();
        employeeList.add(emp1);
        employeeList.add(emp2);
        employeeList.add(emp3);

        // 3. Create a Company object using the List and the Enum
        Company google = new Company(employeeList, CompanyName.GOOGLE);

        // 4. Print the entire Company object using its overridden toString()
        System.out.println("\n--- Company Details ---");
        System.out.println(google);

        // 5. Example of accessing data
        System.out.println("\n--- Data Access Example ---");
        System.out.println("Company Name: " + google.getCompanyName());
        System.out.println("First Employee: " + google.getEmployees().get(0).getName());
    }
}