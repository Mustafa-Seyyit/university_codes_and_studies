

interface BonusSalary{
    double giveBonus();
}
public class PartTimeEmployee extends Employee implements  BonusSalary{
    int hours;

    public PartTimeEmployee(String name, double wage, int hours) {
        super(name, wage);
        this.hours = hours;
    }

    @Override
    public double calculateSalary() {
        return hours*wage + giveBonus();
    }

    @Override
    public double giveBonus() {
        return 10;
    }
}
