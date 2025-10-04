public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("  Static vs. Instance Variable Demo      ");
        System.out.println("=========================================");

        // Create the first employee
        Employee e1 = new Employee(222, "Mustafa");

        // Create the second employee
        Employee e2 = new Employee(888, "Seyyit");

        System.out.println("\n--- Instance (Non-Static) Variable: instanceCount ---");
        System.out.println("e1's instanceCount: " + e1.getInstanceCount());
        System.out.println("e2's instanceCount: " + e2.getInstanceCount());

        // Explanation: instanceCount shows the sequential creation number for the object
        System.out.println("\n--- Static Variable: totalEmployeeCount ---");

        // Accessing the static variable via the object (possible but discouraged)
        System.out.println("e1's totalEmployeeCount: " + Employee.getTotalEmployeeCount());
        System.out.println("e2's totalEmployeeCount: " + Employee.getTotalEmployeeCount());

        // Accessing the static variable via the Class name (Preferred way)
        System.out.println("Class's totalEmployeeCount: " + Employee.getTotalEmployeeCount());

        System.out.println("\n--- Company Name (Shared Static Data) ---");
        System.out.println("e1 works at: " + Employee.companyName);

        // Change the static variable using the class name
        Employee.companyName = "Global Tech Co.";
        System.out.println("Updated company name to: " + Employee.companyName);

        // The change is reflected in the new object and all existing objects
        Employee e3 = new Employee(111, "Dogan");
        System.out.println("e3 works at: " + Employee.companyName);
    }
}