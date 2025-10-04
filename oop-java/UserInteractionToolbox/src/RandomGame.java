import java.util.Scanner;
import java.util.Random;

public class RandomGame {

    /** A simple guessing game using the Random class and a loop. */
    public static void runGuessingGame(Scanner scanner) {
        System.out.println("--- 7. RANDOM NUMBER GUESSING GAME (0-10) ---");

        // Using a fixed seed for demonstration is optional, using new Random() is standard
        Random random = new Random();

        // Generates a random number between 0 (inclusive) and 11 (exclusive), so 0-10.
        int targetNumber = random.nextInt(11);
        int guessCount = 0;

        System.out.println("I have a number in mind (0-10). Try to guess it!");

        while (true) {
            System.out.print("Your guess: ");
            int guess = scanner.nextInt();
            guessCount++;

            if (guess == targetNumber) {
                System.out.printf("Congratulations! The number was %d. You guessed it in %d attempts.\n",
                        targetNumber, guessCount);
                break;
            } else if (guess < targetNumber) {
                System.out.println("Too low. Try again.");
            } else {
                System.out.println("Too high. Try again.");
            }
        }
    }
}