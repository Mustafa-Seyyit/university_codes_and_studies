//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 3.06.2024.
//

// This code checks the length of a user-input string, ensuring it does not exceed 99 characters.

#include <stdio.h>

int lengthCheck(char *ptr);

int main(void) {
    char text[100];
    int length;

    while (1) {
        printf("Enter text:\n");
        scanf("%99s", text);

        length = lengthCheck(text);

        if (length < 100) {
            break;
        } else {
            printf("Please enter no more than 99 characters. Try again.\n");
        }
    }

    printf("The length of the entered string is: %d\n", length);
}

int lengthCheck(char *ptr) {
    char *p = ptr;

    while (*p) {
        p++;
    }

    return p - ptr;
}

