//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 14.06.2024.
//

#include <stdio.h>
#include <stdlib.h>

// This program reads a sentence from the user, stores it in memory, and then prints the words in reverse order.
int main(void) {
    char *text;
    char **wordAddresses;
    int length = 1, wordCount = 1;
    int index = 0;

    text = (char*) malloc(length * sizeof(char));
    wordAddresses = (char**) malloc(wordCount * sizeof(char*));

    if (text == NULL || wordAddresses == NULL) {
        printf("Not enough memory available...\n");
        return 1;
    }

    printf("Enter a sentence: ");
    int c;
    wordAddresses[0] = text; // Address of the first word

    while ((c = getchar()) != '\n') {
        if (index >= length - 1) {
            length++;
            char *p = (char*) realloc(text, length * sizeof(char));
            if (p == NULL) {
                printf("Not enough memory available...\n");
                free(text);
                free(wordAddresses);
                return 2;
            }
            text = p;
        }
        text[index++] = c;

        if (c == ' ') {
            wordCount++;
            char **q = (char**) realloc(wordAddresses, wordCount * sizeof(char*));
            if (q == NULL) {
                printf("Not enough memory available...\n");
                free(text);
                free(wordAddresses);
                return 3;
            }
            wordAddresses = q;
            wordAddresses[wordCount - 1] = &text[index]; // Address of the next word
        }
    }
    text[index] = '\0';

    // Print words in reverse order
    for (int i = wordCount - 1; i >= 0; i--) {
        if (i < wordCount - 1) {
            printf(" ");
        }
        char *start = wordAddresses[i];
        while (*start != ' ' && *start != '\0') {
            putchar(*start);
            start++;
        }
    }

    free(text);
    free(wordAddresses);

    return 0;
}
