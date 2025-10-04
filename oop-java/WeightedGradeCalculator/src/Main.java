import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {

    // Constants for grading weights
    private static final double QUIZ_WEIGHT = 0.20;
    private static final double MIDTERM_WEIGHT = 0.35;
    private static final double FINAL_WEIGHT = 0.45;
    private static final double PASS_THRESHOLD = 50.0;

    public static void main(String[] args) {

        // Using try-with-resources for safe Scanner management
        try (Scanner scanner = new Scanner(System.in)) {

            float midterm, quiz, finalScore;
            double average;

            System.out.println("=========================================");
            System.out.println("  Weighted Grade Calculator              ");
            System.out.println("=========================================");

            System.out.printf("Enter Quiz Score (%.0f%% weight): ", QUIZ_WEIGHT * 100);
            quiz = scanner.nextFloat();

            System.out.printf("Enter Midterm Score (%.0f%% weight): ", MIDTERM_WEIGHT * 100);
            midterm = scanner.nextFloat();

            System.out.printf("Enter Final Score (%.0f%% weight): ", FINAL_WEIGHT * 100);
            finalScore = scanner.nextFloat();

            // Calculate the weighted average
            average = (quiz * QUIZ_WEIGHT) +
                    (midterm * MIDTERM_WEIGHT) +
                    (finalScore * FINAL_WEIGHT);

            // Display results
            System.out.println("\n-----------------------------------------");
            System.out.printf("Calculated Weighted Average: %.2f\n", average);

            // Use the conditional (ternary) operator for the pass/fail result
            String result = (average >= PASS_THRESHOLD) ? "PASSED" : "FAILED";
            System.out.printf("Result: %s (Passing score is %.0f)\n", result, PASS_THRESHOLD);

        } catch (InputMismatchException e) {
            System.err.println("Error: Please enter valid numerical scores.");
        }
    }
}