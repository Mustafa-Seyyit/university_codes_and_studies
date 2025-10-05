//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 22.04.2024.
//

/*
 * This program simulates a dice game where two dice are rolled.
 * The player can win or lose based on the sum of the dice according
 * to specific rules. The game continues until a win or loss condition is met.
 */

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(void) {
    srand(time(NULL));

    printf("Two dice will be rolled, and it will display whether you win or lose. Good luck!\n");

    int die1, die2;
    int initialRoll = 1, gameContinues = 1;

    die1 = 1 + rand() % 6;
    die2 = 1 + rand() % 6;

    if (die1 + die2 == 2 || die1 + die2 == 3 || die1 + die2 == 12) {
        printf("Sorry, the sum of the dice is: %d. You lost.\n", die1 + die2);
        initialRoll = 0;
    } else if (die1 + die2 == 7 || die1 + die2 == 11) {
        printf("Congratulations, the sum of the dice is: %d. You won!\n", die1 + die2);
        gameContinues = 0;
    }

    if (initialRoll == 1 && gameContinues == 1) {
        printf("The sum of the dice is: %d. This is your score.\n", die1 + die2);
    }

    int score = die1 + die2;
    while (initialRoll == 1 && gameContinues == 1) {
        die1 = 1 + rand() % 6;
        die2 = 1 + rand() % 6;
        if (die1 + die2 == 7) {
            printf("Sorry, you rolled a 7 and lost.\n");
            break;
        } else if (die1 + die2 == score) {
            printf("Congratulations, you matched your score and won!\n");
            break;
        }
    }

    return 0;
}
