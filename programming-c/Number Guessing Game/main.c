/*
 * This program implements a number guessing game where the user has
 * 10 attempts to guess a randomly generated number between 0 and 100.
 */

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int randomNumber, guess, attempt = 1;

    srand(time(NULL));

    randomNumber = rand() % 101;

    printf("Enter your guess (you have 10 attempts): ");
    scanf("%d", &guess);

    while (guess != randomNumber && attempt < 10) {
        attempt++;

        printf("Try again: ");
        scanf("%d", &guess);
    }
    
    if (randomNumber == guess) {
        printf("Congratulations! You found the number in %d attempts.\n", attempt);
    } else {
        printf("Sorry, you've used all your attempts. You couldn't find the number.\n");
    }

    return 0;
}
