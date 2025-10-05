//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 4.06.2024.
//

// This code takes a string input from the user and displays the reversed string. It dynamically resizes memory to store the entered characters.

#include <stdio.h>
#include <stdlib.h>

void main(void) {
    
    char *text;
    char ch;
    
    text = (char*) malloc(2 * sizeof(char));
    
    if (text == NULL) {
        printf("Insufficient memory available");
        return;
    }
    int i = 0;

    printf("Enter a word: ");
    ch = getchar();
    if (ch != '\n') {
        i = 1;
    }
    text[0] = ch;
    while (ch != '\n') {
        char *temp;
        temp = (char*) realloc(text, (2 + i) * sizeof(char));
        if (temp == NULL) {
            printf("Insufficient memory available");
            free(text);
            return;
        }
        text = temp;
        ch = getchar();
        text[i] = ch;
        i++;
    }
    printf("Reversed text: ");
    for (int j = i - 1; j >= 0; j--) {
        printf("%c", text[j]);
    }
    printf("\n");

    free(text);
}

