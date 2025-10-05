//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 25.04.2024.
//


/*
 * This program calculates the power of a given number
 * raised to a specified exponent using recursion.
 */

#include <stdio.h>

int power(int base, int exponent);

int main(void) {
    int number, exponent;
    printf("Enter the number: ");
    scanf("%d", &number);
    printf("Enter the exponent: ");
    scanf("%d", &exponent);
    
    printf("Result: %d\n", power(number, exponent));
    return 0;
}

int power(int base, int exponent) {
    if (exponent == 0) {
        return 1;
    } else {
        return (power(base, exponent - 1) * base);
    }
}
