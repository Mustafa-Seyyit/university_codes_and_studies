/*
 * This program calculates the salary of a worker based on the number of parts produced.
 * It considers different bonus rates depending on the quantity produced.
 */

#include <stdio.h>

int main() {
    int salary, minimumWage = 11400, bonus, partsProduced;

    printf("Enter the number of parts produced by the worker: ");
    scanf("%d", &partsProduced);

    while (partsProduced < 0) {
        printf("The number of parts cannot be negative. Please enter again.\n");
        printf("Enter the number of parts produced by the worker: ");
        scanf("%d", &partsProduced);
    }

    if (partsProduced == 0) {
        bonus = 0;
    } else if (partsProduced < 10) {
        bonus = partsProduced * 5000;
    } else if (partsProduced < 30) {
        bonus = partsProduced * 8000;
    } else {  // Changed condition to `else` since we already know partsProduced > 30
        bonus = partsProduced * 12000;
    }

    salary = minimumWage + bonus;
    printf("The worker's salary is %d ₺.\n", salary);
    return 0;
}
