public class Cone extends Shape3D {

    public Cone(double height, double radius) {
        super(radius, height);
    }

    @Override
    public double getVolume() {
        // Volume = (1/3) * Base Area * Height
        double baseArea = calculateCircleArea(getRadius());
        return baseArea * getShapeHeight() / 3.0;
    }

    @Override
    public double getArea() {
        // Surface Area = PI * r * (r + sqrt(r^2 + h^2))
        double radius = getRadius();
        double height = getShapeHeight();
        double slantHeight = Math.sqrt(radius * radius + height * height);
        return Math.PI * radius * (radius + slantHeight);
    }
}