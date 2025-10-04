public class Sphere extends Shape3D {
    public Sphere(double radius) {
        super(radius, 0); // Height is irrelevant for Sphere, set to 0
    }

    @Override
    public double getVolume() {
        // Volume = (4/3) * PI * r^3
        return 4.0 / 3.0 * Math.PI * Math.pow(getRadius(), 3);
    }

    @Override
    public double getArea() {
        // Surface Area = 4 * PI * r^2
        return 4 * calculateCircleArea(getRadius());
    }
}