import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        // Use try-with-resources to ensure the scanner is closed
        try (Scanner scanner = new Scanner(System.in)) {

            int rows, cols;

            System.out.println("=========================================");
            System.out.println("  Welcome to Java Minesweeper!           ");
            System.out.println("=========================================");

            // Get board dimensions with error handling
            try {
                System.out.println("Please enter the dimensions for the board.");
                System.out.print("Enter number of rows: ");
                rows = scanner.nextInt();
                System.out.print("Enter number of columns: ");
                cols = scanner.nextInt();

                if (rows < 2 || cols < 2) {
                    System.err.println("Board dimensions must be at least 2x2. Exiting.");
                    return;
                }

            } catch (InputMismatchException e) {
                System.err.println("Invalid input. Please enter integers for dimensions. Exiting.");
                return;
            }

            // Start the game
            Minesweeper game = new Minesweeper(rows, cols, scanner);
            game.run();

        } catch (Exception e) {
            // Catches any remaining unexpected errors
            System.err.println("An unexpected error occurred during the game.");
        }
    }
}