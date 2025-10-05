//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 26.03.2024.
//

#include <stdio.h>
#include <stdlib.h>

/*
 * This program allocates memory for an integer array of a specified size,
 * allows the user to fill the array, then reallocates the memory to increase
 * the size of the array, allowing the user to fill the additional elements.
 */

int main(void) {
    int size, *p, i, additionalSize;
    
    printf("Enter the size of the array:\n");
    scanf("%d", &size);
    
    p = (int*)malloc(size * sizeof(int));
    
    if (p == NULL) {
        printf("Memory allocation failed.");
        return 0;
    }
    
    printf("Please fill the array:\n");
    
    for (i = 0; i < size; i++) {
        scanf("%d", (p + i));
    }
    
    printf("How much do you want to increase the size of the array?\n");
    scanf("%d", &additionalSize);
    
    p = (int*)realloc(p, (size + additionalSize) * sizeof(int));
    if (p == NULL) {
        printf("Memory allocation failed.");
        return 0;
    }
    
    printf("Please fill the newly expanded array:\n");
    
    for (; i < size + additionalSize; i++) {
        scanf("%d", (p + i));
    }
    
    // Optionally, you can print the array here to verify the input
    printf("The filled array is:\n");
    for (int j = 0; j < size + additionalSize; j++) {
        printf("%d ", *(p + j));
    }
    printf("\n");

    free(p);
    return 0;
}
