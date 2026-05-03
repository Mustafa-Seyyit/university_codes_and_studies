package abstract_pack;

public class FullTimeEmployee extends Employee{

    public FullTimeEmployee(String name, double wage) {
      super(name,wage);
    }
    @Override
    double computeSalary() {
        return wage*10;
    }
}
