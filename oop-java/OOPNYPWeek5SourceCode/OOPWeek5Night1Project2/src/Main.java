public class Main {
    public static void main(String[] args) {

        Employee employee1 = new Employee(23,"asd");
        Employee employee2 = new Employee(56,"fghgfjgf");
        Employee employee3 = new Employee(78,"aasdasdasd");
        CompanyName companyName = CompanyName.APPLE;

        Employee[] employees = {employee1, employee3};
        Company company = new Company(employees,companyName);


        for(Employee e : company.getEmployees())
            System.out.println(e.getName());

       // System.out.println(company.getEmployee().getName());

    }
}