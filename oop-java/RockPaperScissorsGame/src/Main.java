import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("      Rock, Paper, Scissors Console Game ");
        System.out.println("=========================================");

        // Use try-with-resources to ensure the single Scanner instance is closed
        try (Scanner scanner = new Scanner(System.in)) {

            // 1. Initialize Gamers
            Gamer g1 = new Gamer("Mustafa");
            Gamer g2 = new Gamer("Fatmanur");

            // 2. Initialize Arena and add players
            Arena arena = new Arena();
            arena.addGamers(g1, g2);

            // 3. Start the game loop, passing the Scanner
            arena.startGame(scanner);

        } catch (Exception e) {
            System.err.println("\nAn unexpected error occurred during the game.");
        }
    }
}