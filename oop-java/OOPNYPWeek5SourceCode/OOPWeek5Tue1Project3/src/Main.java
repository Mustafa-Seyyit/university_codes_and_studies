public class Main {
    public static void main(String[] args) {
        System.out.println("Hello world!");

        Employee employee1 = new Employee(12, "mike");
        Employee employee2 = new Employee(13, "john");
        Employee employee3 = new Employee(14, "jane");

        Employee[] employees = {employee1, employee2,employee3};

        Company company = new Company(employees,CompanyName.APPLE);

        for (Employee e: company.getEmployees())
            System.out.println(e.getName());

        System.out.println(company.getCompanyName());
    }
}