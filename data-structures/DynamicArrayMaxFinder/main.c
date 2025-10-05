//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 26.03.2024.
//

#include <stdio.h>
#include <stdlib.h>

/*
 * This program creates a dynamic array of integers based on user input,
 * allows the user to fill the array with values, and then finds and
 * displays the maximum value in that array.
 */

int main(void) {
    int size, *p, i, max;
    printf("What is the size of the array? ");
    scanf("%d", &size);
    
    p = (int *)malloc(size * sizeof(int));
    printf("Please fill the array:\n");
    
    for (i = 0; i < size; i++) {
        scanf("%d", &*(p + i));
    }
    
    max = *p;
    for (i = 0; i < size; i++) {
        if (max < *(p + i)) {
            max = *(p + i);
        }
    }
    
    printf("The maximum value is: %d\n", max);
    
    free(p); // Free allocated memory
    return 0;
}
