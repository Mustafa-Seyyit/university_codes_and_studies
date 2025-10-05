//
//  main.c
//  girilen sayiya kadar toplam rekürsif
//
//  Created by Mustafa Seyyit DOĞAN on 29.05.2024.
//
// This code calculates the sum of all integers from 1 to the user-entered number using recursion.

#include <stdio.h>

int sum(int x);

int main(void) {
    int number;

    printf("Enter a number:\n");
    scanf("%d", &number);

    printf("Sum up to the entered number: %d\n", sum(number));
}

int sum(int x) {
    if (x == 0) {
        return 0;
    } else {
        return x + sum(x - 1);
    }
}

