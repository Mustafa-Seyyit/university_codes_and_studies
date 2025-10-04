public class Square extends Shape2D {
    public Square(double side) {
        super(side, side); // A square is a rectangle with equal width and height
    }

    @Override
    public double getArea() {
        // Use protected helper method from Shape2D
        return calculateRectArea(getWidth(), getHeight());
    }
}