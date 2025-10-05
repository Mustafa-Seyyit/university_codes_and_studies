#include <stdio.h>

// This program divides a number by a divisor using repeated subtraction and calculates the quotient and remainder.

int main() {
    int number, divisor, quotient = 0;

    printf("Please enter the number you want to divide:\n");
    scanf("%d", &number);
    
    printf("What do you want to divide by?\n");
    scanf("%d", &divisor);
    
    while (number >= divisor) {
        number -= divisor;
        quotient++;
    }
    
    printf("The division of the entered number by %d gives a quotient of %d and a remainder of %d.\n", divisor, quotient, number);
    
    return 0;
}

