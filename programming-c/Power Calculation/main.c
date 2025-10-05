//
//  main.c
//  verilen bir sayının verilen bir kuvveti
//
//  Created by Mustafa Seyyit DOĞAN on 21.05.2024.
//

#include <stdio.h>

// This program calculates the power of a number.
int powerCalculation(int number, int exponent);

int main(void){
    
    int number, exponent;
    
    printf("Which number?\n");
    scanf("%d", &number);
    
    printf("Which exponent?\n");
    scanf("%d", &exponent);
    
    printf("%d to the power of %d: %d\n", number, exponent, powerCalculation(number, exponent));
    
}

int powerCalculation(int number, int exponent){
    
    if (exponent == 1) {
        return number;
    } else if (number > 0) {
        return number * powerCalculation(number, exponent - 1);
    }
    return 0;
}

