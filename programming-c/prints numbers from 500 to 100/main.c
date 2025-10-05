/*
 
 Disciription in English : This program prints numbers from 500 to 100 on the screen.
 
 Discription in Turkish : bu program 500 den 100 e kadar olan sayıları ekrana bastırır.
 */

#include <stdio.h>

int main()
{
    int number;
    
    for (number=500; number>99; number--) {
        
        printf("%d ",number);
    }
    return 0;
}
