public class Main {
    public static void main(String[] args) {

        Employee fte = new FullTimeEmployee("fte",20);
        Employee pte = new PartTimeEmployee("pte",20,8);

        Employee[] employees ={fte,pte};

        if(pte instanceof BonusSalary)
            System.out.println(((BonusSalary)pte).getBonus());

        for (Employee employee: employees)
            System.out.println(employee.computeSalary());
    }
}