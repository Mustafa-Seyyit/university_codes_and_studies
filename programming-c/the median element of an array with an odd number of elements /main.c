//
//  main.c
// 
//
//  Created by Mustafa Seyyit DOĞAN on 5.03.2024.
//

#include <stdio.h>

// This program finds the median of an array using recursion.

int findMedian(int array[], int index, int position);

int main() {
    int array[50];
    int elementCount, medianIndex, i;
    
    printf("Enter the number of elements in the array: ");
    scanf("%d", &elementCount);
    
    for (i = 0; i < elementCount; i++) {
        printf("Enter element %d of the array: ", i + 1);
        scanf("%d", &array[i]);
    }
    
    medianIndex = elementCount / 2;
    if (elementCount % 2 != 0) {
        medianIndex++; // Adjust for odd-sized arrays
    }

    printf("The median element of the array is: %d\n", findMedian(array, elementCount - 1, medianIndex - 1));
    
    return 0;
}

int findMedian(int array[], int index, int position) {
    if (index == position) {
        return array[index];
    } else {
        return findMedian(array, index - 1, position);
    }
}
