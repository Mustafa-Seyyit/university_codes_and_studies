import java.util.ArrayList;
import java.util.List; // Preferred way to declare list variables

public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("      Teacher Branch Management Demo     ");
        System.out.println("=========================================");

        // 1. Create Teacher objects
        Teacher t1 = new Teacher(101, Branch.MATH);
        Teacher t2 = new Teacher(102, Branch.PHYSICS);
        Teacher t3 = new Teacher(103, Branch.ENG);

        // 2. Add teachers to a list (using List interface)
        List<Teacher> teachers = new ArrayList<>();
        teachers.add(t1);
        teachers.add(t2);
        teachers.add(t3);

        // 3. Iterate through the list and display the enum data
        for (Teacher t : teachers) {
            System.out.println("\n--- Teacher ID: " + t.getId() + " ---");

            // Getting the enum constant name (e.g., MATH)
            System.out.println("Branch: " + t.getBranch().name());

            // Getting the specific data associated with that enum constant
            System.out.println("Branch Information: " + t.getBranch().getInformation());
        }
    }
}