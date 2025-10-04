public class Employee {
    // Current year constant for salary raise calculation
    private static final int CURRENT_YEAR = 2024;

    // Encapsulation and English naming
    private String fullName;
    private double salary; // Changed to double for precise calculations
    private int workHours;
    private int hireYear;

    public Employee(String fullName, double salary, int workHours, int hireYear){
        this.fullName = fullName;
        this.salary = salary;
        this.workHours = workHours;
        this.hireYear = hireYear;
    }

    /** Calculates tax amount (3% if salary > $1000). */
    public double calculateTax() {
        if (salary < 1000.0) {
            return 0.0; // No tax if salary is under $1000
        }
        return this.salary * 0.03; // 3% tax
    }

    /** Calculates bonus for hours exceeding 40 ($30 per hour). */
    public double calculateBonus() {
        int extraHours = this.workHours - 40;
        if (extraHours > 0) {
            return extraHours * 30.0;
        }
        return 0.0;
    }

    /** Calculates the salary raise based on years of service. */
    public double calculateRaise() {
        int yearsOfService = CURRENT_YEAR - this.hireYear;

        // Base raise amount
        double raiseAmount = 0.0;

        if (yearsOfService < 10) {
            // Less than 10 years: 5% of current salary
            raiseAmount = this.salary * 0.05;
        } else if (yearsOfService < 20) {
            // 10 to 19 years: 10% of current salary
            raiseAmount = this.salary * 0.10;
        } else if (yearsOfService >= 20) {
            // 20 or more years: 15% of current salary
            raiseAmount = this.salary * 0.15;
        }

        return raiseAmount;
    }

    /** Overrides the standard toString method to display all calculated data. */
    @Override
    public String toString() {
        double tax = calculateTax();
        double bonus = calculateBonus();
        double raise = calculateRaise();
        double salaryWithTaxAndBonus = this.salary - tax + bonus;
        double totalSalary = this.salary + raise;

        return String.format(
                "=========================================\n" +
                        "Employee Name: %s\n" +
                        "Initial Salary: $%.2f\n" +
                        "Work Hours: %d\n" +
                        "Hire Year: %d\n" +
                        "-----------------------------------------\n" +
                        "Calculated Tax: $%.2f\n" +
                        "Calculated Bonus: $%.2f\n" +
                        "Calculated Raise Amount: $%.2f\n" +
                        "-----------------------------------------\n" +
                        "Salary with Tax and Bonus (Net): $%.2f\n" +
                        "Total Salary with Raise (Future Gross): $%.2f\n" +
                        "=========================================",
                this.fullName, this.salary, this.workHours, this.hireYear,
                tax, bonus, raise, salaryWithTaxAndBonus, totalSalary
        );
    }
}