/*
 Description in english : This program asks the user to enter up to 10 numbers and calculates the square of the entered number.
 
 Description in Turkish : Bu program kullanıcıdan en fazla 10 adet sayı girmesini ister ve bu sayıların karesini hesaplar.
 
 */



#include <stdio.h>

int main()
{
    int control = 0, counter = 1;
    float number;
    
    printf("Enter the 1st number (enter -1 to finish): ");
    scanf("%f", &number);
    control = (int)number;
    if (control != -1) {
        printf("Result: %f\n", number * number);
    }
    
    while (control != -1 && counter < 10) {
        printf("Enter the %dth number (enter -1 to finish): ", counter + 1);
        scanf("%f", &number);
        control = (int)number;
        if (control == -1) {
            break;
        }
        printf("Result: %f\n", number * number);
        counter++;
    }
    
    return 0;
}
