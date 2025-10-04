public abstract class Shape3D extends Shape2D {
    // Shape3D needs both a base shape dimension (radius/width/height) AND height/depth
    private double depth;
    private double shapeHeight; // Renamed to avoid confusion with Shape2D's height field

    // Constructor for Cone/Cylinder/Sphere (based on radius and height)
    public Shape3D(double radius, double height) {
        super(radius); // Initialize radius in Shape2D
        this.shapeHeight = height;
    }

    // Abstract method that MUST be implemented by all 3D subclasses
    public abstract double getVolume();

    // Getters for subclasses
    protected double getShapeHeight() { return shapeHeight; }
}