/*
 * This program calculates the area of a triangle
 * given the base and height provided by the user.
 */

#include <stdio.h>

int main() {
    int base, height;
    float area;
    
    printf("Enter the base: ");
    scanf("%d", &base);
    
    printf("Enter the height: ");
    scanf("%d", &height);
    
    area = (base * height) / 2.0;
    
    printf("%.1f\n", area);
    
    return 0;
}

