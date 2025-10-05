//
//  main.c
//  pointerla dizi elemanlari toplami
//
//  Created by Mustafa Seyyit DOĞAN on 3.06.2024.
//

// This program calculates the sum of an array of integers input by the user.

#include <stdio.h>

int main(void) {
    int array[10], elementCount, sum = 0, *p;
    
    p = array;
    
    printf("Enter the number of elements (maximum 10):\n");
    scanf("%d", &elementCount);
    
    printf("Enter the elements:\n");
    for (int i = 0; i < elementCount; i++) {
        scanf("%d", &array[i]);
        sum += p[i];
    }
    
    printf("The sum of the array is: %d\n", sum);
    
    return 0;
}

