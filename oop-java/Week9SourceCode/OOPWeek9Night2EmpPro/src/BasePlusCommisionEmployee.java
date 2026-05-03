public class BasePlusCommisionEmployee extends  CommisionEmployee{
    double baseSalary;

    public BasePlusCommisionEmployee(String fName, String lName, int ssn, float cRate, double gSale, double baseSalary) {
        super(fName, lName, ssn, cRate, gSale);
        this.baseSalary = baseSalary;
    }

    @Override
    double earning() {
        return super.earning() + baseSalary;
    }

    @Override
    public String toString() {
        return super.toString() + String.format(" base salary: %.2f",baseSalary);
    }
}
