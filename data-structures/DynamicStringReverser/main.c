//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 26.03.2024.
//

#include <stdio.h>
#include <stdlib.h>

/*
 * This program reads a word input by the user character by character,
 * dynamically allocates memory for the input, and then prints the
 * word in reverse order.
 */

int main(void) {
    char *p;
    int i = 0;
    
    printf("Enter a word:\n");
    
    p = (char*)malloc(1 * sizeof(char));
    
    if (p == NULL) {
        printf("Memory allocation failed.");
        return -1;
    }
    
    while (1) {
        *(p + i) = getchar();
        if (*(p + i) == '\n') {
            break;
        }
        
        p = (char*)realloc(p, (i + 2) * sizeof(char)); // Resize to accommodate the new character and null terminator
        if (p == NULL) {
            printf("Memory allocation failed.");
            return -1;
        }
        i++;
    }
    
    p[i] = '\0'; // Null-terminate the string
    
    for (i = i - 1; i >= 0; i--) {
        printf("%c", *(p + i));
    }
    
    free(p);
    return 0;
}
