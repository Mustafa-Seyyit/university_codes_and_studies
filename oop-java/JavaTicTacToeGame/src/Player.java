import java.util.InputMismatchException;
import java.util.Scanner;

class Player {
    private final String name;
    private final char symbol;

    public Player(String name, char symbol) {
        this.name = name;
        this.symbol = symbol;
    }

    public String getName() {
        return name;
    }

    public char getSymbol() {
        return symbol;
    }

    /** Handles player input and attempts to make a move on the board. */
    public void makeMove(Board board) {
        // Scanner should not be closed here, as it may be linked to System.in and needed later.
        // It is passed or reused globally in a larger application, but here we reuse the same input stream.
        Scanner scanner = new Scanner(System.in);
        int row = -1, col = -1;
        boolean validMove = false;

        System.out.println(name + "'s turn (" + symbol + ").");

        do {
            try {
                System.out.print("Enter move (row col, 1-3): ");
                row = scanner.nextInt() - 1; // Convert to 0-based index
                col = scanner.nextInt() - 1; // Convert to 0-based index

                validMove = board.makeMove(row, col, symbol);

                if (!validMove) {
                    System.out.println("Invalid move! That spot is either taken or out of bounds (1-3). Try again.");
                }
            } catch (InputMismatchException e) {
                System.out.println("Invalid input. Please enter two numbers (row and column).");
                scanner.nextLine(); // Clear the buffer
            }
        } while (!validMove);
    }
}