public class Cylinder extends Shape3D {
    public Cylinder(double height, double radius) {
        super(radius, height);
    }

    @Override
    public double getVolume() {
        // Volume = Base Area (Circle) * Height
        double baseArea = calculateCircleArea(getRadius());
        return baseArea * getShapeHeight();
    }

    @Override
    public double getArea() {
        // Surface Area = 2 * PI * r * (r + h)
        return 2 * Math.PI * getRadius() * (getRadius() + getShapeHeight());
    }
}