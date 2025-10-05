//
//  main.c
//  0-10 arası sayıların faktoriyelleri reküsif
//
//  Created by Mustafa Seyyit DOĞAN on 21.05.2024.
//

#include <stdio.h>

// A program to calculate and display the factorial of numbers from 1 to a given number.

int factorial(int number);
void printFactorials(int number);

int main(void) {
    int i = 10;
    printFactorials(i);
    return 0;
}

void printFactorials(int number) {
    if (number == 0) {
        printf("0 factorial: 1\n");
    } else {
        printFactorials(number - 1);
        printf("%d factorial: %d\n", number, factorial(number));
    }
}

int factorial(int number) {
    if (number == 1 || number == 0) {
        return 1;
    } else {
        return number * factorial(number - 1);
    }
}

