public class PartTimeEmployee extends Employee implements Bonus{

    int hours;

    public PartTimeEmployee(String name, double wage, int hours) {
        super(name, wage);
        this.hours = hours;
    }

    @Override
    public double computeSalary() {
        return wage*hours + computeBonus();
    }

    @Override
    public double computeBonus() {
        return 50;
    }
}
