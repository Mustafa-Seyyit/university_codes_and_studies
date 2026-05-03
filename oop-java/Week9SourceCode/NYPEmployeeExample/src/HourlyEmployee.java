public class HourlyEmployee extends Employee{
double wage;
int hours;

    public HourlyEmployee(String fName, String lName, int ssn, double wage, int hours) {
        super(fName, lName, ssn);
        this.wage = wage;
        this.hours = hours;
    }


    @Override
    double earning() {
        if(hours<=40) return wage*hours;
        else return 40*wage + (hours -40)*wage*1.5;
    }

    @Override
    public String toString() {
        return super.toString() + String.format("%.2f %d",wage ,hours);
    }
}
