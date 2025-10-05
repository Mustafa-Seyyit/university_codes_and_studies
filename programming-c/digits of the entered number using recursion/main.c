//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 26.03.2024.
//

#include <stdio.h>
#include <math.h>

// This program calculates a modified sum of the squares of the digits of an integer,
// adding squares of even digits and subtracting squares of odd digits.

int calculateResult(int number);

int main() {
    int number;
    
    printf("Please enter a number: ");
    scanf("%d", &number);
    
    printf("Result: %d\n", calculateResult(number));
    return 0;
}

int calculateResult(int a) {
    int digit = a % 10;
    
    if (a == 0) {
        return 0;
    }
    
    if (a % 2 == 0) {
        return (int)pow(digit, 2) + calculateResult(a / 10);
    } else {
        return -1 * (int)pow(digit, 2) + calculateResult(a / 10);
    }
}
