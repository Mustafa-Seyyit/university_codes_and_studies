public class Main {
    public static void main(String[] args) {
       Employee fte = new FullTimeEmployee("fte", 10);
       Employee pte = new PartTimeEmployee("pte",10, 8);

       Employee[] employees = {fte, pte};

       for(Employee employee : employees)
           System.out.println(employee.computeSalary());
    }
}