public class SalariedEmployee extends Employee{
    double wSalary;
    SalariedEmployee(String fName, String lName, int ssn, double wSalary){
        super(fName,lName,ssn);
        this.wSalary = wSalary;
    }

    @Override
    double earning() {
        return wSalary;
    }

    @Override
    public String toString() {
        return super.toString() + String.format("%.2f ", wSalary);
    }
}
