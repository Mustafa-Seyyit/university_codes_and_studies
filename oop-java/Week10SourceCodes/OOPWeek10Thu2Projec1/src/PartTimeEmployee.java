public class PartTimeEmployee extends Employee implements BonusSalary{

    int hours;

    PartTimeEmployee(String name, double wage, int hours){
        super(name,wage);
        this.hours = hours;
    }
    @Override
   public double computeSalary() {
        return hours*wage + getBonus();
    }

    @Override
    public double getBonus() {
        return 100;
    }
}
