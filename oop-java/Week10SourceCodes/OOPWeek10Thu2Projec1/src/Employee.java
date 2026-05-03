

interface Salary{
     double computeSalary();
}
interface BonusSalary{
    double getBonus();
}
public abstract class Employee implements Salary {

    String name;
    double wage;

    public Employee(String name, double wage) {
        this.name = name;
        this.wage = wage;
    }


}
