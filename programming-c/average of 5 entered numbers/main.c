/*
 project subject in turkish language: kullanıcı tarafından girilen 5 sayının
 ortalamasını hesaplayan program.
 
 project subject in english language: the code calculates the average of 5 numbers entered by the user .
 
 
 */

#include <stdio.h>

int main()
{
    int number1, number2, number3, number4, number5;
    float average;
    
    printf("Enter 5 numbers to find their average: ");
    scanf("%d %d %d %d %d", &number1, &number2, &number3, &number4, &number5);
    
    average = (number1 + number2 + number3 + number4 + number5) / 5.0;
    printf("The average of the 5 numbers you entered is: %f\n", average);
    
    return 0;
}

