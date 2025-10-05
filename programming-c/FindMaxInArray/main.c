//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 29.05.2024.
//

// This code takes an array of numbers entered by the user and recursively finds the maximum value.

#include <stdio.h>

int findMax(int array[10], int maxElement, int length);

void main(void) {
    int numCount, numbers[10];
    
    printf("How many numbers will you enter: ");
    scanf("%d", &numCount);
    
    for (int i = 0; i < numCount; i++) {
        printf("Enter number %d: ", i + 1);
        scanf("%d", &numbers[i]);
    }
    
    printf("The largest of the entered numbers is: %d\n", findMax(numbers, numbers[0], numCount - 1));
}

int findMax(int array[10], int maxElement, int length) {
    if (length == 0) {
        return maxElement;
    } else {
        if (array[length] > maxElement) {
            maxElement = array[length];
        }
        return findMax(array, maxElement, length - 1);
    }
}
