//
//  main.c
//  klavyeden girilen 2 string dizi birleştirme pointer
//
//  Created by Mustafa Seyyit DOĞAN on 23.06.2024.
//

// This code reads two strings from the user, concatenates them with a space in between, and prints the result.

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void) {
    char *text1, *text2, *result, *p;
    int size1 = 2, size2 = 2;
    int length1, length2;

    text1 = (char*) malloc(size1 * sizeof(char));
    text2 = (char*) malloc(size2 * sizeof(char));

    if (text1 == NULL || text2 == NULL) {
        printf("Insufficient memory available\n");
        return 6;
    }

    printf("Enter the first text:\n");
    scanf("%c", &text1[0]);

    while (text1[size1 - 2] != '\n') {
        size1++;
        p = (char*) realloc(text1, size1 * sizeof(char));

        if (p == NULL) {
            printf("Memory allocation failed\n");
            free(text1);
            free(text2);
            return 7;
        }

        text1 = p;
        scanf("%c", &text1[size1 - 2]);
    }

    text1[size1 - 2] = '\0';

    printf("Enter the second text:\n");
    scanf("%c", &text2[0]);

    while (text2[size2 - 2] != '\n') {
        size2++;
        p = (char*) realloc(text2, size2 * sizeof(char));

        if (p == NULL) {
            printf("Memory allocation failed\n");
            free(text1);
            free(text2);
            return 7;
        }

        text2 = p;
        scanf("%c", &text2[size2 - 2]);
    }

    text2[size2 - 2] = '\0';

    length1 = strlen(text1);
    length2 = strlen(text2);

    result = (char*) malloc((length1 + 1) * sizeof(char));

    if (result == NULL) {
        printf("Insufficient memory available\n");
        return 1;
    }

    strcpy(result, text1);

    p = (char*) realloc(result, (length1 + length2 + 2) * sizeof(char));

    if (p == NULL) {
        printf("Memory allocation failed\n");
        return 2;
    }

    result = p;

    strcat(result, " ");
    strcat(result, text2);

    printf("%s\n", result);

    free(result);
    free(text1);
    free(text2);
    return 0;
}

