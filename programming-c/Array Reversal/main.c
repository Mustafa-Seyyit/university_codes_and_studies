#include <stdio.h>

// A program to reverse the elements of an array.

int main() {
    int a[10], b[10], i, elementCount;

    printf("Enter the number of elements for array a (maximum 10): ");
    scanf("%d", &elementCount);

    // Input validation for the number of elements
    if (elementCount > 10) {
        printf("Element count exceeds the maximum size of 10.\n");
        return 1;
    }

    for (i = 0; i < elementCount; i++) {
        printf("Enter element %d of array a: ", i + 1);
        scanf("%d", &a[i]);
        b[elementCount - i - 1] = a[i]; // Reverse the elements
    }

    for (i = 0; i < elementCount; i++) {
        printf("The %dth element of array b is %d.\n", i + 1, b[i]);
    }

    return 0;
}

