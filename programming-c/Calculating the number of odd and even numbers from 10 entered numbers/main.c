/*
 
 Description in English : This program calculates the number of odd and even numbers entered by the user.
 
 Description in Turkish : Bu program kullanıcı tarafından girilen tek ve çift sayıların sayısını hesaplar.
 
 */

#include <stdio.h>

int main()
{
    int counter = 0, number, positiveCount = 0, negativeCount = 0;
    
    printf("Enter 10 numbers.\n");
    
    while (counter < 10) {
        counter++;
        scanf("%d", &number);
        
        if (number > 0) {
            positiveCount++;
        } else if (number < 0) {
            negativeCount++;
        }
    }
    
    printf("You entered %d positive numbers.\n", positiveCount);
    printf("You entered %d negative numbers.\n", negativeCount);
    
    return 0;
}

