import java.util.Scanner;

public class Arena {
    private Gamer gamer1;
    private Gamer gamer2;

    public void addGamers(Gamer g1, Gamer g2) {
        this.gamer1 = g1;
        this.gamer2 = g2;
    }

    public void startGame(Scanner scanner) {

        System.out.println("\n*** Game Starting! ***");

        // Initial score display
        GameStats.displayScores(gamer1, gamer2);

        while (!GameStats.isGameOver()) {

            // Player 1 move
            gamer1.move(scanner);
            if (GameStats.isGameOver()) break;

            // Player 2 move
            gamer2.move(scanner);
            if (GameStats.isGameOver()) break;

            // Process the result
            GameStats.processMoves(gamer1, gamer2);
            GameStats.displayScores(gamer1, gamer2);
        }

        System.out.println("\n*** Game Over. Final Results: ***");
        GameStats.displayScores(gamer1, gamer2);
    }
}