//
//  main.c
//  kitleIndeks
//
//  Created by Mustafa Seyyit DOĞAN on 21.05.2024.
//

// This code calculates the Body Mass Index (BMI) and classifies it based on the result.

#include <stdio.h>

void calculateBMI(float height, float weight);

int main(void) {
    float height, weight;

    printf("Enter your weight (kg): ");
    scanf("%f", &weight);

    printf("Enter your height (m): ");
    scanf("%f", &height);

    calculateBMI(height, weight);
}

void calculateBMI(float height, float weight) {
    float result;

    result = weight / (height * height);

    if (result <= 18 && result >= 0) {
        printf("Underweight\n");
    } else if (result >= 19 && result < 25) {
        printf("Normal weight\n");
    } else if (result >= 25 && result < 30) {
        printf("Overweight\n");
    } else if (result >= 30) {
        printf("Obese\n");
    } else {
        printf("Invalid values entered\n");
    }
}


