public enum Branch {
    // Enum constants with associated informational data
    MATH("Core curriculum covering algebra, calculus, and geometry."),
    PHYSICS("Study of matter, motion, energy, and force."),
    CS("Introduction to computer science and programming fundamentals."),
    ENG("Advanced topics in literature and composition.");

    private final String information;

    /** Constructor for the enum, setting the descriptive information. */
    Branch(String information) {
        this.information = information;
    }

    /** Returns the descriptive information associated with the branch. */
    public String getInformation() {
        return information;
    }
}