#include <stdio.h>

// This program calculates the average of the digits of a three-digit number.
int main()
{
    int number, digit1 = 0, digit2 = 0, digit3 = 0;
    
    printf("Please enter a three-digit number: \n");
    scanf("%d", &number);
    
    while (number / 100 < 1 || number / 1000 >= 1) {
        printf("The entered number is not a three-digit number. Please try again:\n");
        scanf("%d", &number);
    }

    digit1 = number % 10;                      // Last digit
    digit2 = (number / 10) % 10;              // Middle digit
    digit3 = number / 100;                    // First digit
    
    printf("The average of the digits is: %d\n", (digit1 + digit2 + digit3) / 3);
    
    return 0;
}
