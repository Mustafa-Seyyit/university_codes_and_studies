//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 23.06.2024.
//

// This code takes a list of user-input words and sorts them alphabetically using the bubble sort algorithm.

#include <stdio.h>
#include <string.h>
#include <stdlib.h>

void bubbleSort(char **array, int length);

int main(void) {
    int wordCount;
    char **wordArray;

    printf("How many words will be entered?\n");
    scanf("%d", &wordCount);

    wordArray = (char**) malloc(wordCount * sizeof(char*));
    if (wordArray == NULL) {
        printf("Insufficient memory available\n");
        return 1;
    }

    for (int i = 0; i < wordCount; i++) {
        wordArray[i] = (char*) malloc(28 * sizeof(char));
        if (wordArray[i] == NULL) {
            printf("Insufficient memory available\n");
            return 2;
        }
        printf("Enter word %d: ", i + 1);
        scanf("%s", wordArray[i]);
    }

    bubbleSort(wordArray, wordCount);

    printf("Words in alphabetical order:\n");
    for (int i = 0; i < wordCount; i++) {
        printf("%s\n", wordArray[i]);
    }

    for (int i = 0; i < wordCount; i++) {
        free(wordArray[i]);
    }
    free(wordArray);

    return 0;
}

void bubbleSort(char **array, int length) {
    int i, j;
    char *temp;

    for (i = 0; i < length - 1; i++) {
        for (j = 0; j < length - i - 1; j++) {
            if (strcmp(array[j], array[j + 1]) > 0) {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

