//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 25.04.2024.
//
#include <stdio.h>

// This program prints the Fibonacci sequence up to the specified number of terms.
int fibo(int c);
void printFibonacci(int x);

int main(void) {
    printf("How many Fibonacci numbers would you like to display? ");
    int a;
    scanf("%d", &a);
    printFibonacci(a);
    return 0;
}

void printFibonacci(int x) {
    if (x == 0) {
        return;
    } else {
        printFibonacci(x - 1);
        printf("%d. Fibonacci number: %d\n", x, fibo(x));
    }
}

int fibo(int c) {
    if (c == 1) {
        return 0;
    } else if (c == 2 || c == 3) {
        return 1;
    } else if (c < 1) {
        return 0;
    } else {
        return (fibo(c - 2) + fibo(c - 1));
    }
}
