//
//  main.c
//  strlen fonksiyonunu yazma
//
//  Created by Mustafa Seyyit DOĞAN on 3.06.2024.
//

// This program calculates the length of a given string.

#include <stdio.h>

int length(char *str);

void main(void) {
    char a[50];
    
    printf("Enter the string:\n");
    scanf("%s", a);
    
    printf("The length of the string is: %d\n", length(a));
}

int length(char *str) {
    int i;

    for (i = 0; str[i] != '\0'; i++) {}

    return i;
}

