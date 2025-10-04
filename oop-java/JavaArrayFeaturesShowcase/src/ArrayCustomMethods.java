import java.util.Scanner;

public class ArrayCustomMethods {

    // Size is set as a constant for easy modification (3x3 matrix).
    private static final int MATRIX_SIZE = 3;

    public static void runMatrixAdditionDemo() {
        System.out.println("--- 6. CUSTOM METHOD DEMO (Matrix Addition) ---");

        // Using a try-with-resources block ensures the scanner is closed safely.
        try (Scanner scanner = new Scanner(System.in)) {
            int[][] matrix1 = new int[MATRIX_SIZE][MATRIX_SIZE];
            int[][] matrix2 = new int[MATRIX_SIZE][MATRIX_SIZE];
            int[][] resultMatrix;

            System.out.println("Please fill the first 3x3 matrix:");
            fillMatrix(matrix1, scanner);
            System.out.println("Please fill the second 3x3 matrix:");
            fillMatrix(matrix2, scanner);

            resultMatrix = addMatrices(matrix1, matrix2);

            System.out.println("\n--- Result Matrix (Sum) ---");
            displayMatrix(resultMatrix);
        } catch (Exception e) {
            System.err.println("An error occurred during input: " + e.getMessage());
        }
    }

    /** Fills a matrix with user input using the provided Scanner. */
    private static void fillMatrix(int[][] array, Scanner scanner) {
        for (int i = 0; i < MATRIX_SIZE; i++) {
            for (int j = 0; j < MATRIX_SIZE; j++) {
                System.out.printf("Enter element for matrix[%d][%d]: ", i + 1, j + 1);
                array[i][j] = scanner.nextInt();
            }
        }
    }

    /** Adds two matrices of the same size. */
    private static int[][] addMatrices(int[][] matrix1, int[][] matrix2) {
        int[][] sumMatrix = new int[MATRIX_SIZE][MATRIX_SIZE];

        for (int i = 0; i < MATRIX_SIZE; i++) {
            for (int j = 0; j < MATRIX_SIZE; j++) {
                sumMatrix[i][j] = matrix1[i][j] + matrix2[i][j];
            }
        }
        return sumMatrix;
    }

    /** Prints the content of a matrix to the console. */
    private static void displayMatrix(int[][] matrix) {
        for (int i = 0; i < MATRIX_SIZE; i++) {
            for (int j = 0; j < MATRIX_SIZE; j++) {
                System.out.printf("%4d", matrix[i][j]); // Padded for alignment
            }
            System.out.println();
        }
    }
}