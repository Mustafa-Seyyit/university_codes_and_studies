//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 13.05.2024.
//

#include <stdio.h>

#define PI 3.14

// This program calculates the area of a circle given its radius.
float calculateArea(const int radius);

int main(void){
    
    printf("Enter the radius of the circle: ");
    int radius;
    scanf("%d", &radius);
    
    printf("Area of the circle: %0.2f\n", calculateArea(radius));
    
    return 0;
}

float calculateArea(const int radius){
    return PI * radius * radius;
}
