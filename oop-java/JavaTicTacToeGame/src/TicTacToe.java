class TicTacToeGame {
    private final Player player1;
    private final Player player2;
    private final Board board;

    public TicTacToeGame(Player player1, Player player2) {
        this.player1 = player1;
        this.player2 = player2;
        this.board = new Board();
    }

    /** Runs the main game loop until a win or draw condition is met. */
    public void startGame() {
        Player currentPlayer = player1;

        System.out.println("\n--- Starting Tic-Tac-Toe: " + player1.getName() + " vs. " + player2.getName() + " ---");

        while (true) {
            board.displayBoard();

            // 1. Current player makes a move
            currentPlayer.makeMove(board);

            // 2. Check for a winner after the move
            if (board.isWinner(currentPlayer.getSymbol())) {
                board.displayBoard();
                System.out.println("🎉 " + currentPlayer.getName() + " wins the game! 🎉");
                break;
            }

            // 3. Check for a draw
            if (board.isFull()) {
                board.displayBoard();
                System.out.println("It's a draw! The board is full.");
                break;
            }

            // 4. Switch player
            currentPlayer = (currentPlayer == player1) ? player2 : player1;
        }
    }
}