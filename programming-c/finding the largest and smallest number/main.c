/*
 
 Description in English : this program calculates the max number and min number entered by the user.
 
 Description in Turkish : bu program kullanıcın girdiği sayılardan en büyük ve en küçüğünü bulur.
 
 */

#include <stdio.h>

int main()
{
    int counter = 1, max, min, number;
    printf("Enter 10 numbers.\n");
    scanf("%d", &number);
    
    max = number;
    min = number;
    
    while (counter < 10) {
        counter++;
        scanf("%d", &number);
        
        if (number > max) {
            max = number;
        } else if (number < min) {
            min = number;
        }
    }

    printf("The largest number is %d and the smallest number is %d.\n", max, min);
    return 0;
}
