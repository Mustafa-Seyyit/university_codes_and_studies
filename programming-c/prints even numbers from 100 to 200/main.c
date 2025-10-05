/*
 
 Description in English : This program prints even numbers from 100 to 200 on the screen.
 
 Description in Turkish : Bu program 100'den 200'e kadar olan çift sayıları ekrana bastırır.
 
 */

#include<stdio.h>

int main()
{
    int number;
    
    for (number=100; number<201; number+=2){
        
        printf("%d ",number);
    }
    return 0;
}
