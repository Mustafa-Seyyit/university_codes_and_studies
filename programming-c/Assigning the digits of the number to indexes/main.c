/*
 
 Description in English : This program keeps the digits of the number entered by the user in the indexes of the an array.
 
 Description in Turkish : bu program kullanıcı tarafından girilen sayını basamaklarını dizinin indekslerinde tutar.
 */

#include <stdio.h>

int main()
{
    int i, array[5], number;
    printf("Enter a number with up to 5 digits: ");
    scanf("%d", &number);
    
    if (number / 10000.0 <= 10) {
        for (i = 0; i < 5; i++) {
            array[i] = number % 10;
            printf("%d", array[i]);
            number = (number - (number % 10)) / 10;
        }
    } else {
        printf("The number exceeds 5 digits.\n");
    }

    return 0;
}
