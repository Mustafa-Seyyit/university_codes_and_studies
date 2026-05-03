public class BasePlusCommisionEmployee extends CommisionEmployee{
double bSalary;
    public BasePlusCommisionEmployee(String fName, String lName, int ssn, float cRate, double gSale, double bSalary){
        super(fName,lName,ssn,cRate,gSale);
        this.bSalary = bSalary;
    }

    @Override
    double earning(){
        return super.earning() + bSalary;
    }


    @Override
    public String toString() {
        return super.toString() + String.format(" %.2f", bSalary);
    }
}
