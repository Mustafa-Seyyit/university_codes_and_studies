public class Triangle {
    // Area is calculated using the standard formula (base * height) / 2.
    // No need for an incorrect static constant.
    private double baseLength;
    private double height;

    /** Constructor: Initializes the Triangle with a base length and height. */
    public Triangle(double baseLength, double height) {
        // Simple validation to ensure dimensions are positive
        if (baseLength <= 0 || height <= 0) {
            throw new IllegalArgumentException("Base and height must be positive values.");
        }
        this.baseLength = baseLength;
        this.height = height;
    }

    /** Calculates and returns the area of the triangle. */
    public double computeArea() {
        // FIX: Correct formula for the area of a triangle
        return (this.baseLength * this.height) / 2.0;
    }

    // --- Accessor (Getter) Methods ---

    public double getBaseLength() {
        return baseLength;
    }

    public double getHeight() {
        return height;
    }

    @Override
    public String toString() {
        return String.format("Triangle [Base: %.1f, Height: %.1f]", baseLength, height);
    }

    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("      Triangle Area Calculator Demo      ");
        System.out.println("=========================================");

        // 1. Create Triangle objects
        Triangle t1 = new Triangle(1.0, 4.0);
        Triangle t2 = new Triangle(2.0, 5.0);
        Triangle t3 = new Triangle(3.0, 6.0);

        // 2. Store them in an array (or use List<Triangle> for better practice)
        Triangle[] triangles = {t1, t2, t3};

        // 3. Iterate and compute/display the area
        System.out.println("\n--- Results ---");
        for (Triangle temp : triangles) {
            double area = temp.computeArea();
            System.out.printf("%s Area: %.2f\n", temp.toString(), area);
        }
    }
}