package abstract_pack;

public abstract class Employee {
    String name;
    double wage;


    public Employee(String name, double wage) {
        this.name = name;
        this.wage = wage;
    }

    abstract double computeSalary();
}
