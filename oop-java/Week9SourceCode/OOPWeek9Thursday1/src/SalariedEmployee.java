public class SalariedEmployee extends Employee{
    double weeklySalary;
    SalariedEmployee(String fName, String lName, int ssn, double weeklySalary)
    {
        super(fName,lName,ssn);
        this.weeklySalary = weeklySalary;
    }

    @Override
    double earning() {
        return weeklySalary;
    }

    @Override
    public String toString() {
        return super.toString()+String.format(" Weekly Salary: %.2f",weeklySalary);
    }
}
