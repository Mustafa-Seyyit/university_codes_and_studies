package interface_pack;

public abstract class Employee implements ISalary {
    String name;
    double wage;

    public Employee(String name, double wage) {
        this.name = name;
        this.wage = wage;
    }

}
