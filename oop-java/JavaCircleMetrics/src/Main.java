import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        // Using double for better precision, matching Math.PI
        double radius;

        Scanner scanner = new Scanner(System.in);

        System.out.println("Please enter the radius:");

        // Using nextDouble() to match the precision of Math.PI
        radius = scanner.nextDouble();

        // Calculate Area and Circumference
        double area = Math.PI * radius * radius;
        double circumference = 2 * Math.PI * radius;

        System.out.println("--- Results ---");
        System.out.println("Area of the Circle: " + area);
        System.out.println("Circumference of the Circle: " + circumference);

        // Close the scanner to release resources
        scanner.close();
    }
}