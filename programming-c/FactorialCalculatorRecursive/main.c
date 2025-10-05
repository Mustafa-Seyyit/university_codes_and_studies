//
//  main.c
//  struct ile rekürsif fakröriyel
//
//  Created by Mustafa Seyyit DOĞAN on 19.09.2024.
//

// This program calculates the factorial of a given number using a struct.

#include <stdio.h>

typedef struct Factorial {
    int number;
    int result;
} Factor;

int calculate(Factor x);

void main(void) {
    Factor num;
    
    num.number = 1;
    num.result = 1;

    printf("Please enter the number for which you want to calculate the factorial:\n");
    scanf("%d", &num.number);
    
    printf("Result: %d\n", calculate(num));
}

int calculate(Factor x) {
    if (x.number == 0) {
        return 1;
    }

    x.result *= x.number;
    x.number -= 1;
    return calculate(x); 

