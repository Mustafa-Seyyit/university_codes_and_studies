/*
 * This program checks if a given number is a perfect number.
 * A perfect number is equal to the sum of its proper divisors.
 */

#include <stdio.h>

int main()
{
    int number, i = 1, divisorSum = 0;

    scanf("%d", &number);
    while (i < number) {
        if (number % i == 0) {
            divisorSum += i;
        }
        i++;
    }
    if (divisorSum == number) {
        printf("Your number is a perfect number.\n");
    } else {
        printf("Your number is not a perfect number.\n");
    }

    return 0;
}
