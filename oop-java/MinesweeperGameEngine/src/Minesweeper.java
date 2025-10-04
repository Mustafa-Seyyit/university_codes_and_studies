import java.util.Random;
import java.util.Scanner;

public class Minesweeper {
    // Encapsulation: All fields are private
    private int rows;
    private int cols;
    private int size;
    private int[][] mineMap;  // The map containing mines (-1) and numbers
    private int[][] gameBoard; // The board visible to the player
    private boolean isGameOver = false;

    // Constants for board representation
    private static final int MINE = -1;
    private static final int UNREVEALED = -2;
    private static final int ALREADY_CHECKED = -3; // To mark cells that have been revealed/checked by user

    private final Random random = new Random();
    private final Scanner scanner; // Scanner passed from Main class

    public Minesweeper(int rows, int cols, Scanner scanner) {
        this.rows = rows;
        this.cols = cols;
        this.scanner = scanner;
        this.size = rows * cols;
        this.mineMap = new int[rows][cols];
        this.gameBoard = new int[rows][cols];
        // Initialize gameBoard with UNREVEALED marker
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                gameBoard[i][j] = UNREVEALED;
            }
        }
    }

    public void run() {
        int rowChoice, colChoice, successCount = 0;
        prepareGame();

        System.out.println("\n--- MINESWEEPER GAME STARTED ---");

        // The number of safe cells needed to win
        int requiredSuccess = size - size / 4;

        while (!isGameOver) {
            printBoard(gameBoard);

            // Get valid input
            do {
                System.out.print("Enter row index (1 to " + rows + "): ");
                rowChoice = scanner.nextInt();
                System.out.print("Enter column index (1 to " + cols + "): ");
                colChoice = scanner.nextInt();
            } while (!isValidInput(rowChoice, colChoice));

            int r = rowChoice - 1; // Convert to 0-based index
            int c = colChoice - 1;

            if (mineMap[r][c] == MINE) {
                isGameOver = true;
                System.out.println("\n--- BOOM! GAME OVER! ---");
                printBoard(mineMap); // Show the map with mines
            } else if (gameBoard[r][c] != UNREVEALED) {
                System.out.println("This cell has already been revealed. Choose again.");
            } else {
                // Check surrounding mines and update the board
                if (checkCell(r, c)) {
                    successCount++;
                }

                if (successCount == requiredSuccess) {
                    System.out.println("\n--- CONGRATULATIONS! YOU WON! ---");
                    printBoard(mineMap);
                    isGameOver = true;
                }
            }
        }
    }

    /** Randomly places mines on the map (1/4 of the total cells). */
    private void prepareGame() {
        int mineCount = size / 4;
        int placedMines = 0;

        while (placedMines < mineCount) {
            int randRow = random.nextInt(rows);
            int randCol = random.nextInt(cols);

            if (mineMap[randRow][randCol] != MINE) {
                mineMap[randRow][randCol] = MINE;
                placedMines++;
            }
        }
        // Note: Numbering the safe cells (a common Minesweeper feature) is typically done later 
        // but for this project, we'll keep the numbering logic only in checkCell for simplicity.
    }

    /** Checks if the user input is within board bounds. */
    private boolean isValidInput(int r, int c) {
        if (r < 1 || r > rows || c < 1 || c > cols) {
            System.err.println("Invalid input. Row must be 1-" + rows + " and column must be 1-" + cols + ".");
            return false;
        }
        return true;
    }

    /** Checks surrounding cells for mines and updates the game board. */
    private boolean checkCell(int r, int c) {
        int mineCount = 0;

        // Define all 8 directions (Up, Down, Left, Right, and Diagonals)
        int[] rowOffsets = {-1, -1, -1, 0, 0, 1, 1, 1};
        int[] colOffsets = {-1, 0, 1, -1, 1, -1, 0, 1};

        for (int i = 0; i < 8; i++) {
            int newR = r + rowOffsets[i];
            int newC = c + colOffsets[i];

            // Check boundaries
            if (newR >= 0 && newR < rows && newC >= 0 && newC < cols) {
                if (mineMap[newR][newC] == MINE) {
                    mineCount++;
                }
            }
        }

        // Update the visible board with the mine count
        gameBoard[r][c] = mineCount;
        return true; // Indicates a successful, non-mine check
    }

    /** Prints the specified 2D array (map or game board). */
    private void printBoard(int[][] boardToPrint) {
        System.out.print("  "); // Spacer for column headers
        for (int j = 0; j < cols; j++) {
            System.out.printf(" %d", j + 1); // Column headers
        }
        System.out.println();

        for (int i = 0; i < rows; i++) {
            System.out.printf("%d ", i + 1); // Row headers
            for (int cell : boardToPrint[i]) {
                if (cell == MINE) {
                    System.out.print(" *"); // Display mine as *
                } else if (cell == UNREVEALED) {
                    System.out.print(" -"); // Display unrevealed as -
                } else if (cell == 0) {
                    System.out.print("  "); // Display 0 count as space
                } else {
                    System.out.printf(" %d", cell);
                }
            }
            System.out.println();
        }
    }
}