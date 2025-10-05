#include <stdio.h>

// This program takes two arrays as input and calculates the sum of their corresponding elements, storing the result in a third array.

int main()
{
    int i, arrayB[100], arrayA[100], sumArray[100], elementCount;

    printf("Enter the number of elements for arrays A and B (maximum 100): ");
    scanf("%d", &elementCount);

    for (i = 0; i < elementCount; i++) {
        printf("Enter the %dth element of array A: ", i + 1);
        scanf("%d", &arrayA[i]);

        printf("Enter the %dth element of array B: ", i + 1);
        scanf("%d", &arrayB[i]);

        sumArray[i] = arrayB[i] + arrayA[i];
    }
    
    printf("Sum of corresponding elements:\n");
    for (i = 0; i < elementCount; i++) {
        printf("%d\n", sumArray[i]);
    }
    
    return 0;
}

