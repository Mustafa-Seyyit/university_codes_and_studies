class Board {
    private final char[][] grid; // Grid made final as its reference shouldn't change
    private final int size;      // Size made final

    public Board() {
        this.size = 3;
        this.grid = new char[size][size];
        // Initialize the grid with empty spaces
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                grid[i][j] = ' ';
            }
        }
    }

    /** Displays the current state of the board in a user-friendly format. */
    public void displayBoard() {
        System.out.println("\n--- Current Board ---");
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                System.out.print(" " + grid[i][j]);
                if (j < size - 1) System.out.print(" |");
            }
            System.out.println();
            // Draw separator lines
            if (i < size - 1) System.out.println("---+---+---");
        }
        System.out.println("---------------------\n");
    }

    /** Checks if all cells on the board are occupied. */
    public boolean isFull() {
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                if (grid[i][j] == ' ') return false;
            }
        }
        return true;
    }

    /** Checks if the given symbol has won by forming a line of three. */
    public boolean isWinner(char symbol) {
        // Check rows and columns
        for (int i = 0; i < size; i++) {
            // Check row i
            if (grid[i][0] == symbol && grid[i][1] == symbol && grid[i][2] == symbol) return true;
            // Check column i
            if (grid[0][i] == symbol && grid[1][i] == symbol && grid[2][i] == symbol) return true;
        }
        // Check main diagonal (top-left to bottom-right)
        if (grid[0][0] == symbol && grid[1][1] == symbol && grid[2][2] == symbol) return true;
        // Check anti-diagonal (top-right to bottom-left)
        if (grid[0][2] == symbol && grid[1][1] == symbol && grid[2][0] == symbol) return true;

        return false;
    }

    /** Attempts to place the symbol at the given 1-based coordinates. */
    public boolean makeMove(int row, int col, char symbol) {
        // Check if coordinates are within bounds (0-based) and the cell is empty
        if (row >= 0 && row < size && col >= 0 && col < size && grid[row][col] == ' ') {
            grid[row][col] = symbol;
            return true;
        }
        return false;
    }
}