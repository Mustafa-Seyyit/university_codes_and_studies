public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("         Time Model Demonstration        ");
        System.out.println("=========================================");

        // 1. Create a Time object
        Time t1 = new Time(14, 30, 45); // 2:30:45 PM
        System.out.println("\n--- Time 1 (14:30:45) ---");
        System.out.println("Universal Format (HH:MM:SS): " + t1.toUniversalString());
        System.out.println("Standard Format (H:MM:SS AM/PM): " + t1.toString());

        // 2. Demonstration of setters
        System.out.println("\n--- Setters Demo ---");
        t1.setHour(23); // Set to 11 PM
        t1.setMinute(59);
        t1.setSecond(59);

        System.out.println("New Universal Time (23:59:59): " + t1.toUniversalString());
        System.out.println("New Standard Time: " + t1.toString());

        // 3. Invalid value test
        System.out.println("\n--- Invalid Value Test ---");
        try {
            t1.setTime(25, 0, 0); // Invalid hour
        } catch (IllegalArgumentException e) {
            System.err.println("Error caught: " + e.getMessage());
        }
    }
}