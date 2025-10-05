//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 2.06.2024.
//
#include <stdio.h>
#include <stdlib.h>

// This program converts a given integer to a specified base and displays the result.
void calculateBase(int number, int base, int *result);

int main(void) {
    int *solution, inputNumber, targetBase, length = 0;

    solution = (int*) malloc(28 * sizeof(int));

    for (int i = 0; i < 28; i++) {
        solution[i] = -1;
    }

    if (solution == NULL) {
        printf("Not enough memory allocated\n");
        return 0;
    }

    printf("Which base do you want to convert to?\n");
    scanf("%d", &targetBase);

    printf("Which number do you want to convert?\n");
    scanf("%d", &inputNumber);

    calculateBase(inputNumber, targetBase, solution);

    printf("Result: ");

    for (int i = 0; solution[i] != -1; i++) {
        length++;
    }

    for (int i = length - 1; i >= 0; i--) {
        printf("%d", solution[i]);
    }
    free(solution);
}

void calculateBase(int number, int base, int *result) {
    if (number == 0) {
        return;
    } else {
        *result = number % base;
        calculateBase(number / base, base, result + 1);
    }
}
