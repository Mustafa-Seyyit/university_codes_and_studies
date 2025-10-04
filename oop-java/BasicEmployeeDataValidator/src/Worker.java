public class Worker {
    private String name;
    private double salary;
    // Static counter to track the number of Worker objects created
    private static int counter = 0;

    /** Constructor: Increments the counter whenever a new Worker object is created. */
    public Worker() {
        counter++;
        this.salary = 0.0; // Initialize salary to a safe default
    }

    // --- Mutator (Setter) Methods ---

    public void setName(String name) {
        this.name = name;
    }

    /** * Sets the salary, validating that the amount is non-negative.
     * @throws IllegalArgumentException if the salary is less than zero.
     */
    public void setSalary(double salary) {
        if (salary < 0) {
            // Throw a checked exception for invalid data
            throw new IllegalArgumentException("Salary amount must be zero or greater.");
        } else {
            this.salary = salary;
        }
    }

    // --- Accessor (Getter) Methods ---

    public String getName() {
        return name;
    }

    public double getSalary() {
        return salary;
    }

    /** Returns the static count of all Worker objects created. */
    public static int getCounter() {
        return counter;
    }

    // --- Display Method ---

    public void displayInfo() {
        System.out.println("Name: " + (name != null ? name : "N/A"));
        System.out.printf("Salary: $%.2f\n", salary);
    }
}