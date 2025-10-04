public class Rectangle extends Shape2D {
    public Rectangle(double width, double height) {
        super(width, height);
    }

    @Override
    public double getArea() {
        // Use protected helper method from Shape2D
        return calculateRectArea(getWidth(), getHeight());
    }
}