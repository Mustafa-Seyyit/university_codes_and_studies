//
//  main.c
//  girlen dizinin referans değerinde ve en çok tekrar eden elemanları
//
//  Created by Mustafa Seyyit DOĞAN on 2.06.2024.
//

// This code counts the numbers in an array that occur at least a specified number of times and identifies the most frequently occurring number.

#include <stdio.h>
#include <stdlib.h>

int main(void) {
    int arrayLength, minCount, maxCount, control, repeatCheck, maxRepeatLength = 1;
    int *array;

    printf("Enter the number of elements in the array:\n");
    scanf("%d", &arrayLength);

    array = (int*) malloc(arrayLength * sizeof(int));

    printf("Fill the array:\n");
    for (int i = 0; i < arrayLength; i++) {
        printf("Enter element %d:\n", i + 1);
        scanf("%d", &*(array + i));
    }

    printf("How many repetitions should be considered:\n");
    scanf("%d", &minCount);

    maxCount = *(array);
    
    for (int i = 0; i < arrayLength; i++) {
        int repeatCount = 1;
        for (int j = i + 1; j < arrayLength; j++) {
            if (*(array + i) == *(array + j)) {
                repeatCount++;
            }
        }
        if (repeatCount > maxRepeatLength) {
            maxRepeatLength = repeatCount;
            maxCount = *(array + i);
        }
    }

    printf("Numbers that repeat more than %d times:", minCount);
    
    int *checked = (int*) calloc(arrayLength, sizeof(int));
    
    for (int i = 0; i < arrayLength; i++) {
        if (checked[i] == 1) {
            continue;
        }

        control = *(array + i);
        repeatCheck = 1;
        for (int j = i + 1; j < arrayLength; j++) {
            if (control == array[j]) {
                repeatCheck++;
                checked[j] = 1;
            }
        }
        if (repeatCheck >= minCount) {
            printf(" %d", control);
        }
    }

    printf("\nThe number that occurred the most is %d times: %d\n", maxRepeatLength, maxCount);
    
    free(array);
    free(checked);

    return 0;
}

