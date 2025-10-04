import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        // Use try-with-resources to ensure the Scanner is closed
        try (Scanner scanner = new Scanner(System.in)) {

            System.out.println("--- Tic-Tac-Toe Setup ---");

            // Player 1 Setup
            System.out.print("Enter name for Player 1: ");
            String name1 = scanner.nextLine();

            char symbol1;
            do {
                System.out.print("Choose symbol for Player 1 (X or O): ");
                String input = scanner.nextLine().trim().toUpperCase();
                symbol1 = input.isEmpty() ? ' ' : input.charAt(0);
            } while (symbol1 != 'X' && symbol1 != 'O');

            // Player 2 Setup
            System.out.print("Enter name for Player 2: ");
            String name2 = scanner.nextLine();

            // Automatically assign the opposite symbol to Player 2
            char symbol2 = (symbol1 == 'X') ? 'O' : 'X';

            // Create Player objects
            Player player1 = new Player(name1, symbol1);
            Player player2 = new Player(name2, symbol2);

            // Initialize and start the game
            TicTacToeGame game = new TicTacToeGame(player1, player2);
            game.startGame();

        } catch (Exception e) {
            System.err.println("An unexpected error occurred during game setup: " + e.getMessage());
        }
    }
}