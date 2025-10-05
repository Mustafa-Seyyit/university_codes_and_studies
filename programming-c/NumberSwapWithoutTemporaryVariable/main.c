#include <stdio.h>
#include <stdlib.h>

// This program swaps two numbers without using a temporary variable.
int main()
{
    int number1, number2;
    
    printf("Please enter two numbers: ");
    scanf("%d %d", &number1, &number2);
    
    number1 = number1 + number2;
    number2 = number1 - number2;
    number1 = number1 - number2;
    
    printf("Swapped numbers: %d %d\n", number1, number2);
    
    return 0;
}

