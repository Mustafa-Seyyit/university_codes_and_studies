//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 27.03.2024.
//

#include <stdio.h>
#include <stdlib.h>

/*
 * This program dynamically allocates memory to read a string from the user character by character
 * until the user presses Enter. It resizes the allocated memory as needed to accommodate the input.
 */

int main() {
    char *p;
    int i = 0;

    printf("Enter a text (press Enter to finish):\n");

    p = (char*)malloc(1 * sizeof(char));

    if (p == NULL) {
        printf("Memory allocation failed.\n");
        return -1;
    }

    while (1) {
        *(p + i) = getchar();  // Read a character
        if (*(p + i) == '\n') { // Check for the newline character (Enter key)
            break;              // Exit the loop if Enter is pressed
        }
        p = (char*)realloc(p, (i + 2) * sizeof(char)); // Resize for the next character plus the null terminator
        if (p == NULL) {
            printf("Memory allocation failed.\n");
            return -1;
        }
        i++;
    }

    *(p + i) = '\0'; // Null-terminate the string

    printf("You entered: %s\n", p); // Print the entered text

    free(p); // Free the allocated memory
    return 0;
}

