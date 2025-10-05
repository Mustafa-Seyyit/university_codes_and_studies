#include <stdio.h>

// This program finds the two largest distinct numbers from a list of 10 numbers.

int main() {
    int numbers[10], largest1, largest2, i;
    
    printf("Please enter 10 numbers:\n");
    for (i = 0; i < 10; i++) {
        scanf("%d", &numbers[i]);
    }
    
    largest1 = largest2 = numbers[0];

    for (i = 1; i < 10; i++) {
        if (numbers[i] > largest1) {
            largest2 = largest1;
            largest1 = numbers[i];
        } else if (numbers[i] > largest2 && numbers[i] != largest1) {
            largest2 = numbers[i];
        }
    }

    printf("The two largest distinct numbers are: %d and %d\n", largest1, largest2);
    
    return 0;
}

