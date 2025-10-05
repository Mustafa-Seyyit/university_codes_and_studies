//
//  main.c
//  dizideki en büyük eleman rekürsif
//
//  Created by Mustafa Seyyit DOĞAN on 27.02.2024.
//

#include <stdio.h>

// This program finds the largest element in an array using recursion.

int findLargest(int array[], int size) {
    if (size == 1)
        return array[0];
    else {
        int largestOfSubArray = findLargest(array, size - 1);
        return (array[size - 1] > largestOfSubArray) ? array[size - 1] : largestOfSubArray;
    }
}

int main() {
    int N;
    printf("Enter the size of the array: ");
    scanf("%d", &N);

    int array[N];
    printf("Enter the elements of the array:\n");
    for (int i = 0; i < N; i++) {
        printf("Element %d: ", i + 1);
        scanf("%d", &array[i]);
    }

    int largest = findLargest(array, N);

    printf("The largest element in the array: %d\n", largest);

    return 0;
}

