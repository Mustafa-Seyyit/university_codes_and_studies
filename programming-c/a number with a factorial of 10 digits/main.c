/*
 code subject in english language: this code calculates the smallest number with factorial 10 digits
 
 
 code subject in turkish language: bu kod faktöriyel 10 basamaklı en küçük sayıyı hesaplar
 */


#include <stdio.h>

int main()
{
    int number=1;
    long int fak=1;
    
    while (fak <= 999999999) {
        number++;
        fak*=number;
        
    }
    printf("%d ",number);
    printf("\n");
    return 0;
}
