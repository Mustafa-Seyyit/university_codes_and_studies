public class Main {
    public static void main(String[] args) {
        Employee pte = new PartTimeEmployee("part time emp",10,8);
        Employee fte = new FullTimeEmployee("full time emp",10);

        Employee[] employees = {pte,fte};

        for(Employee employee : employees)
            System.out.println(employee.calculateSalary());
    }
}