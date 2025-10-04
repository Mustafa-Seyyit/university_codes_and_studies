public class Teacher {
    private final int id; // ID is usually final after initialization
    private final Branch branch; // Teacher's branch is typically constant

    /** Constructor: Initializes a teacher with an ID and a teaching branch. */
    public Teacher(int id, Branch branch) {
        this.id = id;
        this.branch = branch;
    }

    // --- Accessor (Getter) Methods ---

    public int getId() {
        return id;
    }

    public Branch getBranch() {
        return branch;
    }
}