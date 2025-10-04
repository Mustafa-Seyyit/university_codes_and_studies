import java.util.ArrayList;
import java.util.List; // Use List interface for better programming practice

public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("        Circle Area Calculator Demo      ");
        System.out.println("=========================================");

        // 1. Create Circle objects with double precision
        Circle c1 = new Circle(5.0);
        Circle c2 = new Circle(15.5);
        Circle c3 = new Circle(10.2);

        // 2. Add circles to a list
        List<Circle> circles = new ArrayList<>();
        circles.add(c1);
        circles.add(c2);
        circles.add(c3);

        // 3. Iterate and compute/display the area
        System.out.println("\n--- Results ---");
        for (Circle circle : circles) {
            // Call the computeArea method and store the result
            double area = circle.computeArea();

            // Print the result from the main class
            System.out.printf("%s has an Area of: %.4f\n", circle.toString(), area);
        }
    }
}