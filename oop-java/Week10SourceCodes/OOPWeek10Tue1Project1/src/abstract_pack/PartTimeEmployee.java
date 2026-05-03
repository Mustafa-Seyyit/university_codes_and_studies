package abstract_pack;

public class PartTimeEmployee extends Employee{
    int hours;

    public PartTimeEmployee(String name, double wage, int hours) {
        super(name, wage);
        this.hours = hours;
    }

    @Override
    double computeSalary() {
        return hours*wage;
    }
}
