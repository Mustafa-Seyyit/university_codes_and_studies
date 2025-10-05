//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 4.06.2024.
//

#include <stdio.h>
#include <stdlib.h>

// This program dynamically allocates an array, allows the user to fill it,
// and then expands the array to accommodate more elements before printing all values.

int main(void) {
    
    int initialSize, additionalSize, *array, i;
    
    printf("Enter the size of the array:\n");
    scanf("%d", &initialSize);
    
    array = (int*) malloc(initialSize * sizeof(int));
    if (array == NULL) {
        printf("Insufficient memory available, terminating program...");
        return 1;
    }
    
    printf("Fill the array:\n");
    for (i = 0; i < initialSize; i++) {
        scanf("%d", &array[i]);
    }
    
    printf("How much do you want to increase the size of the array?\n");
    scanf("%d", &additionalSize);
    
    int *temp;
    
    temp = (int*) realloc(array, (initialSize + additionalSize) * sizeof(int));
    if (temp == NULL) {
        printf("Insufficient memory available, terminating program...");
        free(array);
        return 1;
    }
    array = temp;
    
    printf("Continue filling the array:\n");
    for (; i < initialSize + additionalSize; i++) {
        scanf("%d", &array[i]);
    }
    
    for (i = 0; i < initialSize + additionalSize; i++) {
        printf("%d ", array[i]);
    }
    
    free(array);
    return 0;
}


