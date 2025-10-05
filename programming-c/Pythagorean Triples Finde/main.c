//
//  main.c
//  pisagor üçlüleri
//
//  Created by Mustafa Seyyit DOĞAN on 20.02.2024.

/* Project subject: This project finds all Pythagorean triples with integer sides between 1 and 33. */

#include <stdio.h>
#include <math.h>

int main(void) {
    int sideA, sideB;
    float sideC;

    for (sideA = 1; sideA <= 33; sideA++) {
        for (sideB = 33; sideB >= sideA; sideB--) {
            sideC = sqrtf(sideA * sideA + sideB * sideB);
            if (sideC <= 33 && sideC - (int)sideC == 0) {
                printf("%d-%d-%0.0f\n", sideA, sideB, sideC);
            }
        }
    }
    return 0;
}
