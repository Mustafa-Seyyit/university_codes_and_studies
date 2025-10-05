#include <stdio.h>

// A program to calculate the scalar product of two arrays of integers.

int main() {
    int i, a[5], b[5], elementCount;
    
    printf("Enter the number of elements for arrays a and b (maximum 5): ");
    scanf("%d", &elementCount);
    
    if (elementCount > 5) {
        printf("Element count exceeds the maximum size of 5.\n");
        return 1;
    }

    for (i = 0; i < elementCount; i++) {
        printf("Enter element %d of array a: ", i + 1);
        scanf("%d", &a[i]);
        
        printf("Enter element %d of array b: ", i + 1);
        scanf("%d", &b[i]);
    }

    for (i = 0; i < elementCount; i++) {
        printf("The scalar product of elements %d from arrays a and b is %d.\n", i + 1, a[i] * b[i]);
    }

    return 0;
}

