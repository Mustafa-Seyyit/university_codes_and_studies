//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 4.06.2024.
//
#include <stdio.h>
#include <stdlib.h>

int main(void) {
    
    int size, *array, max;

    printf("How many elements will the array have?\n");
    scanf("%d", &size);

    array = (int*) malloc(size * sizeof(int));
    if (array == NULL) {
        printf("Not enough memory available...\n");
        free(array);
        return 1;
    }

    printf("Please fill the array:\n");
    for (int i = 0; i < size; i++) {
        scanf("%d", &array[i]);
    }
    
    max = array[0];
    
    for (int i = 0; i < size; i++) {
        if (array[i] > max) {
            max = array[i];
        }
    }
    
    printf("The largest element entered is: %d\n", max);

    free(array); // Free the allocated memory
    return 0;
}
