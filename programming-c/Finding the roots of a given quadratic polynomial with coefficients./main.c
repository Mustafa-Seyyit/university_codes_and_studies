/*
 project subject in turkish language:Bu kod, kullanıcıdan ikinci dereceden bir denklemin katsayılarını girmesini ister ve ardından diskriminant temelinde kökleri hesaplayıp yazdırır.
 
 project subject in english language:This code prompts the user to enter the coefficients of a quadratic equation and then calculates and prints the roots based on the discriminant.
 
 */
#include <stdio.h>
#include <math.h>

int main() {
    int a, b, c;
    float delta, x1, x2;
    printf("Enter the coefficients of the equation whose roots you want to find (press enter after each coefficient): ");
    scanf("%d %d %d", &a, &b, &c);
    
    delta = (b * b) - 4 * a * c;
    
    if (delta > 0) {
        x1 = (-b - sqrt(delta)) / (2 * a);
        x2 = (-b + sqrt(delta)) / (2 * a);
        printf("The roots of the equation are: %f and %0.1f\n", x1, x2);
    } else if (delta == 0) {
        x1 = -b / (2 * a);
        printf("Double root: %0.1f\n", x1);
    } else {
        printf("No real roots\n");
    }
    
    return 0;
}

