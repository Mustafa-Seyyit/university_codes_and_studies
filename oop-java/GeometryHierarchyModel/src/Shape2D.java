public abstract class Shape2D {
    // Use Math.PI for precision and remove the custom constant

    // Private fields for encapsulation, only one will be used per subclass instance
    private double height;
    private double width;
    private double radius;

    // Constructor for Rectangle/Square
    public Shape2D(double dimension1, double dimension2) {
        this.width = dimension1;
        this.height = dimension2;
    }

    // Constructor for Circle
    public Shape2D(double radius) {
        this.radius = radius;
    }

    // Abstract method that MUST be implemented by all 2D subclasses
    public abstract double getArea();

    // Helper method for Area (Circle)
    protected double calculateCircleArea(double radius) {
        // FIX: Correct formula for circle area
        return Math.PI * radius * radius;
    }

    // Helper method for Area (Rectangle/Square)
    protected double calculateRectArea(double width, double height) {
        return width * height;
    }

    // Getters for subclasses
    protected double getRadius() { return radius; }
    protected double getWidth() { return width; }
    protected double getHeight() { return height; }
}