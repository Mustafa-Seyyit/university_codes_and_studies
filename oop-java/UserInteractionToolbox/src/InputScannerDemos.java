import java.util.Scanner;

public class InputScannerDemos {

    /** Demonstrates reading three integers sequentially. */
    public static void runBasicInputDemo(Scanner scanner) {
        System.out.println("--- 1. SEQUENTIAL INTEGER INPUT DEMO ---");
        System.out.println("Please enter three integers (separated by spaces or new lines):");

        // Ensure there is no stray newline from previous demos
        if (scanner.hasNextLine()) {
            // Check if the next token is a number to decide if we need to clear the buffer.
            // Simplified for this demo: we assume user follows instructions.
        }

        int number1 = scanner.nextInt();
        int number2 = scanner.nextInt();
        int number3 = scanner.nextInt();

        System.out.printf("You entered: %d, %d, %d\n", number1, number2, number3);
    }

    /** Demonstrates how scanner.next() reads tokens (words) one by one. */
    public static void runWordIterationDemo(Scanner scanner) {
        System.out.println("--- 2. WORD ITERATION DEMO (Scanner.next()) ---");
        System.out.println("Enter a sentence (max 5 words). Scanner will read them individually:");

        // Clean the buffer after nextInt calls
        scanner.nextLine();

        for (int i = 0; i < 5; i++) {
            System.out.printf("Word %d: ", i + 1);
            if (scanner.hasNext()) {
                String word = scanner.next();
                System.out.println("-> Read: " + word);
            } else {
                break;
            }
        }
        // Consume the rest of the line if the user entered more than 5 words/tokens
        scanner.nextLine();
    }

    /** Demonstrates a simple pass/fail conditional check based on input. */
    public static void runConditionalCheckDemo(Scanner scanner) {
        System.out.println("--- 3. CONDITIONAL CHECK DEMO (Pass/Fail) ---");
        System.out.print("Please enter your score (0-100): ");
        int score = scanner.nextInt();

        if (score >= 60) {
            System.out.println("Result: You passed!");
        } else {
            System.out.println("Result: You failed.");
        }
    }

    /** Calculates the sum of all integers between two user-provided numbers. */
    public static void runSumBetweenNumbersDemo(Scanner scanner) {
        System.out.println("--- 4. SUM BETWEEN TWO NUMBERS DEMO ---");
        System.out.print("Enter the first integer: ");
        int numberA = scanner.nextInt();
        System.out.print("Enter the second integer: ");
        int numberB = scanner.nextInt();

        // Ensure numberA is the smaller one for the loop
        int start = Math.min(numberA, numberB);
        int end = Math.max(numberA, numberB);

        int totalSum = 0;
        for (int i = start; i <= end; i++) {
            totalSum += i;
        }
        System.out.printf("The sum of integers between %d and %d is: %d\n", start, end, totalSum);
    }

    /** Calculates a running sum until the user enters a non-positive number. */
    public static void runRunningSumDemo(Scanner scanner) {
        System.out.println("--- 5. RUNNING SUM DEMO (Stop at <= 0) ---");
        System.out.println("Enter positive integers to sum. Enter 0 or a negative number to stop.");

        int totalSum = 0;
        int inputNumber;

        do {
            System.out.print("Enter number: ");
            inputNumber = scanner.nextInt();

            if (inputNumber > 0) {
                totalSum += inputNumber;
            }
        } while (inputNumber > 0);

        System.out.println("Final Sum: " + totalSum);
    }

    /** Fills and displays a 3x3 matrix using scanner input. */
    public static void runMatrixInputDemo(Scanner scanner) {
        System.out.println("--- 6. MATRIX INPUT/OUTPUT DEMO (3x3) ---");
        final int SIZE = 3;
        int[][] matrix = new int[SIZE][SIZE];

        System.out.println("Please fill the 3x3 matrix:");

        for (int i = 0; i < SIZE; i++) {
            for (int j = 0; j < SIZE; j++) {
                System.out.printf("Enter element for matrix[%d][%d]: ", i + 1, j + 1);
                matrix[i][j] = scanner.nextInt();
            }
        }

        System.out.println("\nEntered Matrix:");
        for (int i = 0; i < SIZE; i++) {
            for (int j = 0; j < SIZE; j++) {
                // Print with padding for clean alignment
                System.out.printf("%4d", matrix[i][j]);
            }
            System.out.println(); // Newline after each row
        }
    }
}