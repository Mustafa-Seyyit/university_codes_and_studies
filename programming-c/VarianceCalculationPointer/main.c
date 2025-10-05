//
//  main.c
//  varyans bulma pointer
//
//  Created by Mustafa Seyyit DOĞAN on 2.06.2024.
//

#include <stdio.h>
#include <stdlib.h>

// This program calculates the variance of a set of integers input by the user.

int main(void) {
    int *array, elementCount;
    float variance = 0, average = 0, tempElement;

    array = (int*) malloc(28 * sizeof(int));

    if (array == NULL) {
        printf("Memory allocation failed\n");
        return 1;
    }

    printf("How many elements will you enter (up to 28)?\n");
    scanf("%d", &elementCount);

    if (elementCount > 28) {
        printf("Exceeded the limit of elements. Exiting the program...\n");
        free(array);
        return 1;
    }

    for (int i = 0; i < elementCount; i++) {
        printf("Enter element %d:\n", i + 1);
        scanf("%d", &array[i]);
        average += array[i];
    }

    average /= elementCount;

    for (int i = 0; i < elementCount; i++) {
        tempElement = average - array[i];
        if (tempElement < 0) {
            tempElement *= -1;
        }
        variance += tempElement * tempElement;
    }

    printf("Variance of the entered numbers: %f\n", variance / elementCount);

    free(array);
    return 0;
}

