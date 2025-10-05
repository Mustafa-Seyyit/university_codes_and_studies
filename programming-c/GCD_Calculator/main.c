//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 29.05.2024.
//


// This code calculates the Greatest Common Divisor (GCD) of two user-entered numbers using a recursive approach.

#include <stdio.h>

int gcd(int largerNum, int smallerNum, int divisor, int count);

void main(void) {
    
    int larger, smaller;
    
    printf("Enter two numbers: ");
    scanf("%d", &larger);
    scanf("%d", &smaller);
    
    if (smaller > larger) {
        int temp = smaller;
        smaller = larger;
        larger = temp;
    }
    
    printf("The GCD of the entered numbers is: %d", gcd(larger, smaller, 1, 1));
}

int gcd(int largerNum, int smallerNum, int divisor, int count) {
    
    if (count == smallerNum) {
        if (largerNum % smallerNum == 0) {
            return smallerNum;
        }
        return divisor;
    }
    if (smallerNum % count == 0 && largerNum % count == 0) {
        divisor = count;
    }
    return gcd(largerNum, smallerNum, divisor, count + 1);
}

