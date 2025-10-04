public class Employee {
    // 1. Kapsülleme: Alanlar private yapıldı.
    private String name;
    private int socialSecurityNum;
    private float hourlyWage;
    private int hoursWorked;

    // 2. Yapıcı Metot (Constructor)
    public Employee(String name, int ssn, float wage, int hours) {
        this.name = name;
        this.socialSecurityNum = ssn;
        this.hourlyWage = wage;
        this.hoursWorked = hours;
    }

    // --- Getter Methods ---
    public String getName() {
        return name;
    }

    public int getSocialSecurityNum() {
        return socialSecurityNum;
    }

    // --- Setter Methods (Example of how to allow modification) ---
    public void setHoursWorked(int hoursWorked) {
        this.hoursWorked = hoursWorked;
    }

    // --- Core Methods ---

    /** Displays the basic information of the employee. */
    public void displayInfo() {
        System.out.println("Employee Name: " + this.name);
        System.out.println("SSN: " + this.socialSecurityNum);
    }

    /** Calculates and returns the employee's total salary. */
    public float calculateSalary() {
        return this.hourlyWage * this.hoursWorked;
    }
}