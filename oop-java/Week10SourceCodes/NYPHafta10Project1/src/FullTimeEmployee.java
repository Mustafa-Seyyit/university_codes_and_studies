public class FullTimeEmployee extends Employee{

    public FullTimeEmployee(String name, double wage) {
        super(name, wage);
    }

    @Override
    public double calculateSalary() {
        return 10*wage;
    }
}
