//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 29.05.2024.
//

// This code calculates the sum of the digits of a user-entered number using recursion.

#include <stdio.h>

int digitSum(int x);

int main(void) {
    printf("Enter a number:\n");
    int number;
    scanf("%d", &number);

    printf("The sum of the digits of the entered number: %d\n", digitSum(number));
}

int digitSum(int x) {
    if (x == 0) {
        return 0;
    } else {
        return (x % 10) + digitSum(x / 10);
    }
}

