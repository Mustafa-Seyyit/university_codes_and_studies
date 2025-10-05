/*
 * This program calculates the average of numbers entered by the user
 * until two identical numbers are entered consecutively.
 */

#include <stdio.h>

int main() {
    int number1, number2, sum = 0;
    float average, count = 2;

    printf("Enter a number: ");
    scanf("%d", &number1);
    sum += number1;

    printf("Enter a number: ");
    scanf("%d", &number2);
    sum += number2;

    while (number1 != number2) {
        if (number2 != number1) {
            printf("Enter a number: ");
            scanf("%d", &number1);
            sum += number1;
            count++;
        }

        if (number1 != number2) {
            printf("Enter a number: ");
            scanf("%d", &number2);
            sum += number2;
            count++;
        }
    }

    average = sum / count;

    printf("The average of the entered numbers is %.1f\n", average);

    return 0;
}
