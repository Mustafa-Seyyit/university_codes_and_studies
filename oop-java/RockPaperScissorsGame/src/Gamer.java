import java.util.Scanner;

public class Gamer {
    private int winCount = 0;
    private final String name; // Name should be final
    private HandSign sign; // Current move sign

    public Gamer(String name) {
        this.name = name;
    }

    /** Prompts the player for their move and updates the sign. */
    public void move(Scanner scanner) { // Scanner passed as parameter
        boolean isValid = false;

        // Reset sign at the start of the move
        this.sign = null;

        System.out.println("\n--- " + this.name + "'s Turn ---");
        System.out.println("Please enter: P: Paper | S: Scissor | R: Rock | Q: Quit");

        do {
            String input = scanner.next().trim().toLowerCase();
            char inChar = input.length() > 0 ? input.charAt(0) : ' ';
            isValid = true;

            switch(inChar) {
                case 'q':
                    GameStats.setGameOver(true);
                    break;
                case 'p':
                    this.sign = HandSign.PAPER;
                    break;
                case 's':
                    this.sign = HandSign.SCISSOR;
                    break;
                case 'r':
                    this.sign = HandSign.ROCK;
                    break;
                default:
                    System.out.println("Invalid input. Please try again.");
                    isValid = false;
                    break;
            }
        } while (!isValid);
    }

    // --- Accessor/Mutator Methods ---

    public String getName() {
        return name;
    }

    public HandSign getSign() {
        return sign;
    }

    public int getWinCount() {
        return winCount;
    }

    public void incrementWinCount() {
        this.winCount++;
    }
}