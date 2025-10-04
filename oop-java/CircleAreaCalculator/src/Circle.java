public class Circle {
    // Radius should be double for better precision
    private double radius;

    /** Constructor: Initializes the Circle with a radius. */
    public Circle(double radius) {
        // Simple validation to ensure radius is positive
        if (radius <= 0) {
            throw new IllegalArgumentException("Radius must be a positive value.");
        }
        this.radius = radius;
    }

    /** Calculates the area of the circle (Area = PI * r^2). */
    public double computeArea() {
        // Using the high-precision Math.PI constant
        return Math.PI * this.radius * this.radius;
    }

    // --- Accessor (Getter) Method ---

    public double getRadius() {
        return radius;
    }

    @Override
    public String toString() {
        return "Circle [Radius: " + String.format("%.2f", radius) + "]";
    }
}