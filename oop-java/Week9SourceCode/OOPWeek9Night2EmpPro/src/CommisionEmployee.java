public class CommisionEmployee extends Employee {

float cRate;
double gSale;
    public CommisionEmployee(String fName, String lName, int ssn, float cRate, double gSale) {
        super(fName, lName, ssn);
        this.cRate = cRate;
        this.gSale = gSale;
    }

    @Override
    double earning() {
        return cRate * gSale;
    }

    @Override
    public String toString() {
        return super.toString() + String.format(" C Rate %f G Sale : %.2f ", cRate,gSale);
    }
}
