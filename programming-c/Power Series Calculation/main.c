//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 26.03.2024.
//

/*
 * This program calculates a mathematical result based on the formula involving powers and factorials
 * for two input integers x and y.
 */

#include <stdio.h>
#include <math.h>

double result(int base, int exponent);
int factorial(int n);

int main() {
    int x, y;

    printf("Enter two numbers: ");
    scanf("%d %d", &x, &y);

    printf("Result: %f\n", result(x, y));

    return 0;
}

double result(int base, int exponent) {
    if (exponent == 0) {
        return 1;
    } else {
        return pow(-1, exponent) * (pow(base, 2 * exponent + 1) / factorial(2 * exponent + 1)) + result(base, exponent - 1);
    }
}

int factorial(int n) {
    if (n == 0) {
        return 1;
    } else {
        return n * factorial(n - 1);
    }
}
