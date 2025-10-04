public class Employee {
    private int id;
    private String name;

    // Static field: Shared by all instances of the class
    public static String companyName = "Tech Solutions Inc.";

    // Instance field: Each object gets its own copy (although counter logic makes it less intuitive here)
    private int instanceCount;

    // Static field: Tracks the total number of Employee objects created
    private static int totalEmployeeCount = 0;

    public Employee(int id, String name) {
        this.id = id;
        this.name = name;

        // This value is incremented for every object created, but is only visible to the current object.
        this.instanceCount = ++totalEmployeeCount;

        // totalEmployeeCount is updated before assignment to instanceCount
        // totalEmployeeCount is incremented, affecting ALL objects
    }

    // --- Getter Methods ---

    public int getInstanceCount() {
        return instanceCount;
    }

    // Static method to access the static variable (Good OOP Practice)
    public static int getTotalEmployeeCount() {
        return totalEmployeeCount;
    }

    @Override
    public String toString() {
        return String.format("ID: %d, Name: %s, Company: %s", id, name, companyName);
    }
}