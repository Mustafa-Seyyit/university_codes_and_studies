/*
 * This program takes a positive integer input from the user and
 * prints its reverse.
 */

#include <stdio.h>

int main() {
    int number, reversed = 0;
    
    printf("Please enter a positive number: ");
    scanf("%d", &number);
    
    while (number > 0) {
        reversed = reversed * 10 + number % 10;
        number = number / 10;
    }
    
    printf("%d\n", reversed);
    
    return 0;
}
