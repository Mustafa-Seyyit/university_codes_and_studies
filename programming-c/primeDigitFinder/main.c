/*
 * This program prints all two-digit numbers between 10 and 99
 * where both digits are prime numbers (2, 3, 5, or 7).
 */

#include <stdio.h>

int main() {
    int number = 10, unitDigit, tenDigit;

    while (number < 100) {
        unitDigit = number % 10;
        tenDigit = number / 10;

        if ((unitDigit == 2 || unitDigit == 3 || unitDigit == 5 || unitDigit == 7) &&
            (tenDigit == 2 || tenDigit == 3 || tenDigit == 5 || tenDigit == 7)) {
            printf("%d \n", number);
        }
        number++;
    }

    return 0;
}
