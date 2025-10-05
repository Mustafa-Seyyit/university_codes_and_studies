/*
 * This program takes a name as input and sorts its characters
 * in descending order using the bubble sort algorithm.
 */

#include <stdio.h>

int main() {
    char name[100], temporary;
    int length, i, j;

    printf("Please enter your name: ");
    gets(name);

    for (length = 0; name[length] != '\0'; length++);

    for (i = 0; i < length - 1; i++) {
        for (j = 0; j < length - i - 1; j++) {
            if (name[j] < name[j + 1]) {
                temporary = name[j];
                name[j] = name[j + 1];
                name[j + 1] = temporary;
            }
        }
    }

    for (i = 0; i < length; i++) {
        printf("%c", name[i]);
    }
    printf("\n");

    return 0;
}
