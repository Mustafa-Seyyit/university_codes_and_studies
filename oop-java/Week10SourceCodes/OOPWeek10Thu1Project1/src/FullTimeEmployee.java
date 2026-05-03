public class FullTimeEmployee extends Employee{

    FullTimeEmployee(String name, double wage){
        super(name, wage);
    }
    @Override
    public double computeSalary() {
        return wage * 50;
    }
}
