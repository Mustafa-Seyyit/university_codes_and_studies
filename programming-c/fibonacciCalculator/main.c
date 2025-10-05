//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 23.04.2024.
//

/*
 * This program calculates the nth Fibonacci number recursively.
 * The Fibonacci sequence starts with 0 and 1, and each subsequent
 * number is the sum of the two preceding ones.
 */

#include <stdio.h>

int fibonacci(int n);

int main(void) {
    printf("Which Fibonacci value do you want to calculate? ");
    int n;
    scanf("%d", &n);
    printf("%dth value: %d\n", n, fibonacci(n));
    return 0;
}

int fibonacci(int n) {
    if (n == 1) {
        return 0;
    } else if (n == 2) {
        return 1;
    } else {
        return fibonacci(n - 1) + fibonacci(n - 2);
    }
}


