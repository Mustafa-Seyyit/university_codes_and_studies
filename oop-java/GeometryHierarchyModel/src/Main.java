public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("        Geometric Shapes Calculator      ");
        System.out.println("=========================================");

        // 2D Shapes
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(5.0, 6.0);
        Square square = new Square(5.0);

        System.out.println("\n--- 2D Shapes ---");
        System.out.printf("Circle (r=5.0) Area: %.4f\n", circle.getArea());
        System.out.printf("Rectangle (w=5, h=6) Area: %.4f\n", rectangle.getArea());
        System.out.printf("Square (side=5) Area: %.4f\n", square.getArea());

        // 3D Shapes (Using r=5, h=5 for comparison)
        Cone cone = new Cone(5.0, 5.0);
        Cylinder cylinder = new Cylinder(5.0, 5.0);
        Sphere sphere = new Sphere(5.0);

        System.out.println("\n--- 3D Shapes (r=5, h=5) ---");

        System.out.printf("Cone Area: %.4f\n", cone.getArea());
        System.out.printf("Cone Volume: %.4f\n", cone.getVolume());

        System.out.printf("\nCylinder Area: %.4f\n", cylinder.getArea());
        System.out.printf("Cylinder Volume: %.4f\n", cylinder.getVolume());

        System.out.printf("\nSphere Area (r=5): %.4f\n", sphere.getArea());
        System.out.printf("Sphere Volume (r=5): %.4f\n", sphere.getVolume());
    }
}