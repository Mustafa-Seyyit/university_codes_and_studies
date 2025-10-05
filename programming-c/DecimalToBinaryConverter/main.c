//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 29.05.2024.
//

#include <stdio.h>

// This program converts a given decimal number to its binary representation and prints it.
void translateToBinary(int number);

void main() {
    int number;
    
    printf("Enter a number: ");
    scanf("%d", &number);
    
    if (number < 0) {
        number = -number;
        printf("-");
    }
    printf("The binary equivalent of %d is: ", number);
    translateToBinary(number);
}

void translateToBinary(int x) {
    if (x > 1) {
        translateToBinary(x / 2);
    }
    printf("%d", x % 2);
}
