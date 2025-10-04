public class Employee {
    private final int id; // ID is usually final
    private final String name;
    private final int ssn; // Social Security Number (kept for demo)

    public Employee(int id, String name, int ssn) {
        this.id = id;
        this.name = name;
        this.ssn = ssn;
    }

    // --- Accessor (Getter) Methods ---

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    // SSN getter is generally avoided in real-world APIs for security

    /** Provides a formatted string representation of the Employee object. */
    @Override
    public String toString() {
        // Corrected format and simplified output
        return String.format("Employee {ID: %d, Name: %s, SSN: %d}", id, name, ssn);
    }
}