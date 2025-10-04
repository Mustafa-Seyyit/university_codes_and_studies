public class AkinSoft extends Company {

    public AkinSoft() {
        // The superclass constructor is called implicitly or explicitly
    }

    /** Overrides the protected method from the superclass. */
    @Override
    protected String getAddress() {
        return "AkinSoft specific address";
    }

    // Note: This class inherits the default print() method.
}