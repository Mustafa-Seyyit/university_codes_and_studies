public class Student {
    // Renamed for clarity and improved encapsulation
    private int studentId;
    private float midtermScore;
    private float finalScore;

    public Student(int id, float midterm, float finalScore) {
        this.studentId = id;
        this.midtermScore = midterm;
        this.finalScore = finalScore;
    }

    // --- Accessor (Getter) Methods ---

    public int getStudentId() {
        return studentId;
    }

    public float getMidtermScore() {
        return midtermScore;
    }

    public float getFinalScore() {
        return finalScore;
    }

    // --- Calculation Methods ---

    /**
     * Computes the total score based on a weighted average.
     * Example: Midterm 40%, Final 60%
     */
    public float computeTotalScore() {
        final float MIDTERM_WEIGHT = 0.40f;
        final float FINAL_WEIGHT = 0.60f;

        return (this.midtermScore * MIDTERM_WEIGHT) + (this.finalScore * FINAL_WEIGHT);
    }

    /**
     * Computes the base score (simple average of the two scores).
     */
    public float computeBaseScore() {
        return (this.midtermScore + this.finalScore) / 2.0f;
    }
}