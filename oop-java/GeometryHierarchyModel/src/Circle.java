public class Circle extends Shape2D {
    public Circle(double radius) {
        super(radius);
    }

    @Override
    public double getArea() {
        // Use protected helper method from Shape2D
        return calculateCircleArea(getRadius());
    }
}