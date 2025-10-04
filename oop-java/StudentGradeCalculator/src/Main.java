public class Main {
    public static void main(String[] args) {

        // Create a new Student instance
        Student student1 = new Student(1001, 75.0f, 85.0f);

        System.out.println("--- Student Grade Calculation ---");
        System.out.println("Student ID: " + student1.getStudentId());
        System.out.printf("Midterm Score: %.1f\n", student1.getMidtermScore());
        System.out.printf("Final Score: %.1f\n", student1.getFinalScore());
        System.out.println("---------------------------------");

        // Demonstrate the calculation methods
        float baseScore = student1.computeBaseScore();
        float totalWeightedScore = student1.computeTotalScore();

        System.out.printf("Simple Average (Base Score): %.2f\n", baseScore);
        System.out.printf("Weighted Total Score (40/60): %.2f\n", totalWeightedScore);
    }
}