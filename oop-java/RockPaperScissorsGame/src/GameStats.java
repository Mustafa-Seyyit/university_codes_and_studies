public class GameStats {
    // Statics are kept private and accessed via methods
    private static int numOfDraws = 0;
    private static int numOfTrials = 0;
    private static boolean isGameOver = false;

    // --- Accessor/Mutator Methods ---

    public static boolean isGameOver() {
        return isGameOver;
    }

    public static void setGameOver(boolean gameOver) {
        isGameOver = gameOver;
    }

    public static void incrementDraws() {
        numOfDraws++;
    }

    public static void incrementTrials() {
        numOfTrials++;
    }

    // --- Core Game Logic ---

    public static void processMoves(Gamer g1, Gamer g2) {
        if (isGameOver || g1.getSign() == null || g2.getSign() == null) {
            return;
        }

        incrementTrials();

        // Check for a draw
        if (g1.getSign() == g2.getSign()) {
            incrementDraws();
            System.out.println("It's a draw!");
        } else {
            // Check win conditions for Gamer 1 (g1)
            boolean g1Wins = (g1.getSign() == HandSign.PAPER && g2.getSign() == HandSign.ROCK) ||
                    (g1.getSign() == HandSign.SCISSOR && g2.getSign() == HandSign.PAPER) ||
                    (g1.getSign() == HandSign.ROCK && g2.getSign() == HandSign.SCISSOR);

            if (g1Wins) {
                g1.incrementWinCount();
                System.out.println(g1.getName() + " wins the round!");
            } else {
                g2.incrementWinCount();
                System.out.println(g2.getName() + " wins the round!");
            }
        }
    }

    // --- Display Method ---

    public static void displayScores(Gamer g1, Gamer g2) {
        System.out.println("\n--- Current Scoreboard (Rounds: " + numOfTrials + ") ---");

        // Use a helper lambda for calculating win percentage
        float calcWinPct = (numOfWin) -> (numOfTrials == 0) ? 0.0f : ((float) numOfWin / numOfTrials) * 100.0f;

        System.out.printf("%s: %d Wins (%.2f%% Win Rate)\n",
                g1.getName(), g1.getWinCount(), calcWinPct.apply(g1.getWinCount()));
        System.out.printf("%s: %d Wins (%.2f%% Win Rate)\n",
                g2.getName(), g2.getWinCount(), calcWinPct.apply(g2.getWinCount()));
        System.out.println("Total Draws: " + numOfDraws);
        System.out.println("------------------------------------------");
    }
}