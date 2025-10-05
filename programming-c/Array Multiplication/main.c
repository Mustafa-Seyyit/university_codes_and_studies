#include <stdio.h>

// This program multiplies each element of an array by a given number and stores the results in a second array.
int main()
{
    int i, a[100], multiplier, b[100], elementCount;
    
    printf("Enter the number of elements in array a: ");
    scanf("%d", &elementCount);
    
    printf("What number would you like to multiply each element of array a by? ");
    scanf("%d", &multiplier);
    
    for (i = 0; i < elementCount; i++) {
        printf("Enter element %d of array a: ", i + 1);
        scanf("%d", &a[i]);
        
        b[i] = a[i] * multiplier;
    }
    
    for (i = 0; i < elementCount; i++) {
        printf("The %dth element of array b is %d.\n", i + 1, b[i]);
    }
    
    return 0;
}

