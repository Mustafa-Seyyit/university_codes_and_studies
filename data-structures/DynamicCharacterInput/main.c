//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 3.06.2024.
//
// This code dynamically stores characters entered by the user until the Enter key is pressed, then displays the input.

#include <stdio.h>
#include <stdlib.h>

void main(void) {
        
    char *p;
    p = (char*) calloc(2, sizeof(char));
    if (p == NULL) {
        printf("Insufficient memory; program terminating...\n");
        return;
    }

    int i = 0;
    
    printf("Enter characters. Press Enter to finish input.\n");
    p[i] = getchar();
    
    while (p[i] != '\n') {
        printf("* ");
        char *temp = (char*) realloc(p, (2 + i) * sizeof(char));
        if (temp == NULL) {
            printf("Insufficient memory; program terminating...\n");
            free(p);
            return;
        }
        p = temp;
        i++;
        p[i] = getchar();
    }
    
    printf("Entered characters: ");
    for (int j = 0; j < i; j++) {
        printf("%c", p[j]);
    }
    printf("\n");
    
    free(p);
}
