//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 18.06.2024.
//

// This code initializes an array, fills it with user-input values, and finds the maximum value among the elements.

#include <stdio.h>
#include <stdlib.h>

int main(void) {
    
    int *array, size, max;
    
    printf("Enter the number of elements for the array:\n");
    scanf("%d", &size);
    
    array = (int*) calloc(size, sizeof(int));
    
    for (int i = 0; i < size; i++) {
        printf("Enter element %d:\n", i + 1);
        scanf("%d", &array[i]);
    }
    
    max = array[0];
    
    for (int j = 0; j < size; j++) {
        if (max < array[j]) {
            max = array[j];
        }
    }
    
    printf("Maximum element: %d\n", max);
    
    free(array);
    return 0;
}

