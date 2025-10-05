//
//  main.c
//  0-10 arası sayılar faktöriyel reküsif
//
//  Created by Mustafa Seyyit DOĞAN on 25.04.2024.
//

#include <stdio.h>

// This program calculates the factorial of numbers from 0 to 9 recursively.
int fak(int a);
void fo1r(int c);

void main(void) {
    fo1r(9);
}

void fo1r(int c) {
    if (c == 0) {
    } else {
        fo1r(c - 1);
        printf("%d factorial: %d\n", c, fak(c));
    }
}

int fak(int a) {
    if (a == 0) {
        return 1;
    } else if (a == 1) {
        return 1;
    } else {
        return a * fak(a - 1);
    }
}
