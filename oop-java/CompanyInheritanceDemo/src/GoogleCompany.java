public class GoogleCompany extends Company {

    public GoogleCompany() {
        // The superclass constructor is called implicitly or explicitly
    }

    /** Overrides the protected method from the superclass. */
    @Override
    protected String getAddress() {
        return "Google specific address";
    }

    /** Overrides the public method from the superclass. */
    @Override
    public void print() {
        System.out.println("GoogleCompany's custom print method.");
    }

    /** Unique method specific to GoogleCompany. */
    public void doSomething() {
        System.out.println("Hello, I am doing something specific to GoogleCompany.");
    }
}