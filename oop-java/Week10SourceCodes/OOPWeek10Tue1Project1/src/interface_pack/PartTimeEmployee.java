package interface_pack;

public class PartTimeEmployee extends Employee implements IBonus {

    int hours;
    public PartTimeEmployee(String name, double wage, int hours) {
        super(name, wage);
        this.hours = hours;
    }

    @Override
    public double computeSalary() {
        return hours*wage+ addBonus();
    }

    @Override
    public double addBonus() {
        return 10;
    }
}
