public class HourlyEmployee extends Employee{
    int hours;
    double wage;
    public HourlyEmployee(String fName, String lName, int ssn, int hours, double wage) {
        super(fName, lName, ssn);
        this.hours = hours;
        this.wage = wage;
    }

    @Override
    double earning() {
        if(hours <= 40) return  wage*hours;
        else return 40*wage + (hours -40)*1.5 * wage;
    }

    @Override
    public String toString() {
        return super.toString() + String.format(" Wage: %.2f hours: %d",wage,hours);
    }
}
