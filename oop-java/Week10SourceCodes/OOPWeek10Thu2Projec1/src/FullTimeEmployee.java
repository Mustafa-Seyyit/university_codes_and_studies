public class FullTimeEmployee extends Employee{

    public FullTimeEmployee(String name, double wage) {
        super(name, wage);
    }

    @Override
    public double computeSalary() {
        return wage * 10;
    }
}
