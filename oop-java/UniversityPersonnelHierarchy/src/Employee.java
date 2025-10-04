public class Employee {
    private String fullName;
    private String email;
    private String phone;
    // Static variable to track total employee check-ins
    private static int checkInCount = 0;

    public Employee(String fullName, String email, String phone) {
        this.fullName = fullName;
        this.email = email;
        this.phone = phone;
    }

    // --- Common Behaviors (Inherited by all) ---
    public void checkIn() {
        checkInCount++;
        System.out.println(this.fullName + " checked in. Total entries today: " + checkInCount);
    }

    public void checkOut() {
        System.out.println(this.fullName + " checked out.");
    }

    public void eatLunch() {
        System.out.println(this.fullName + " is eating lunch.");
    }

    // --- Getter for encapsulation demo (e.g., to get FullName) ---
    public String getFullName() {
        return fullName;
    }
}