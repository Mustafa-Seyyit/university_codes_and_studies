public class Company {
    // Encapsulation added
    private String name = "Default Company";

    public Company() {
        // Default constructor
    }

    // Protected method: Accessible within the same package and by subclasses.
    protected String getAddress() {
        return "Default address for " + name;
    }

    // Public method: Can be overridden.
    public void print() {
        System.out.println("Default print method from Company class.");
    }

    // Getter for the private field
    public String getName() {
        return name;
    }
}