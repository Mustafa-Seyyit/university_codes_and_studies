#include <stdio.h>

// This program calculates the greatest common divisor (GCD) of two numbers using recursion.

int gcd(int a, int b, int j);

int main(void) {
    int x, y;
    scanf("%d %d", &x, &y);
    
    if (x == 0 || y == 0) {
        printf("The GCD of the entered numbers does not exist.\n");
    } else if (x > y) {
        printf("The GCD of the two numbers is: %d\n", gcd(x, y, y));
    } else {
        printf("The GCD of the two numbers is: %d\n", gcd(y, x, x));
    }
    
    return 0;
}

int gcd(int m, int n, int j) {
    if (m % n == 0 && j % n == 0) {
        return n;
    } else {
        return gcd(m, n - 1, j);
    }
}

