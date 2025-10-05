//
//  main.c
//  ilk n adet fibonacci reküsif
//
//  Created by Mustafa Seyyit DOĞAN on 21.05.2024.
//

// This code prints the Fibonacci sequence up to a specified number of terms.

#include <stdio.h>

void printFibonacci(int count);
int fibonacci(int number);

int main(void) {
    int x;

    printf("How many Fibonacci numbers to print? ");
    scanf("%d", &x);

    printFibonacci(x);
}

int fibonacci(int number) {
    if (number == 0) {
        printf("Invalid input.\n");
        return 0;
    } else if (number == 1) {
        return 1;
    } else if (number == 2) {
        return 1;
    }
    return fibonacci(number - 1) + fibonacci(number - 2);
}

void printFibonacci(int count) {
    if (count == 0) {
        return;
    } else {
        printFibonacci(count - 1);
        printf("%d\n", fibonacci(count));
    }
}

