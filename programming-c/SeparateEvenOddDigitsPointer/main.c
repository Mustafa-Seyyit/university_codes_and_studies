//
//  main.c
//  tek -> int  çift->char pointer
//
//  Created by Mustafa Seyyit DOĞAN on 23.06.2024.
//

// This program separates the digits of a number into even and odd arrays and prints them.

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void) {
    char *oddDigits; // Pointer for odd digits
    char *q;
    long long int number = 2310238018; // Input number
    int *evenDigits, evenCount = 0, oddCount = 1, *p; // Even digits and counters

    // Allocate memory for odd and even digits
    oddDigits = (char*) malloc(oddCount * sizeof(char));
    evenDigits = (int*) malloc(evenCount * sizeof(int));

    if (oddDigits == NULL || evenDigits == NULL) {
        printf("Not enough memory allocated.\n");
        return 1;
    }

    // Separate digits into odd and even
    while (number != 0) {
        if ((number % 10) % 2 == 0) { // Even digit
            evenDigits[evenCount - 1] = number % 10;
            evenCount++;
            
            p = (int*) realloc(evenDigits, evenCount * sizeof(int));
            if (p == NULL) {
                printf("Not enough memory allocated.\n");
                free(oddDigits);
                free(evenDigits);
                return 2;
            }
            evenDigits = p;
            number /= 10;

        } else { // Odd digit
            oddDigits[oddCount - 2] = number % 10 + '0';
            oddCount++;
            
            q = (char*) realloc(oddDigits, oddCount * sizeof(char));
            if (q == NULL) {
                printf("Not enough memory allocated.\n");
                free(evenDigits);
                free(oddDigits);
                return 2;
            }

            oddDigits = q;
            number /= 10;
        }
    }

    // Print even digits
    printf("Even digits:");
    for (int i = 0; i < evenCount - 1; i++) {
        printf(" %d ", evenDigits[i]);
    }
    
    // Null-terminate the string for odd digits and print
    oddDigits[oddCount - 2] = '\0';
    printf("\nOdd digits: %s\n", oddDigits);

    // Free allocated memory
    free(oddDigits);
    free(evenDigits);

    return 0;
}

