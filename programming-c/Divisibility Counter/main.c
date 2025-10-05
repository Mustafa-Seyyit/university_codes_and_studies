#include <stdio.h>

// This program counts how many numbers entered by the user are divisible by 2, 5, and both.
int main()
{
    int number, divisibleBy2 = 0, divisibleBy5 = 0, divisibleBy10 = 0, counter = 0;
    printf("Enter a number (enter -1 to exit): ");
    scanf("%d", &number);
    
    while (number != -1) {
        counter++;
        if (number % 2 == 0) {
            divisibleBy2++;
            if (number % 5 == 0) {
                divisibleBy5++;
                divisibleBy10++;
            }
        } else if (number % 5 == 0) {
            divisibleBy5++;
        }
        
        printf("Enter a number (enter -1 to exit): ");
        scanf("%d", &number);
    }
    
    if (counter > 0) {
        printf("Out of the numbers you entered, %d are divisible by 2, %d are divisible by 5, and %d are divisible by both 2 and 5.\n", divisibleBy2, divisibleBy5, divisibleBy10);
    } else {
        printf("You exited without entering any numbers.\n");
    }
    
    return 0;
}

