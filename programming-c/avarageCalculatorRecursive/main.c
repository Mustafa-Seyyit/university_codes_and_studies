//
//  main.c
//  sayı dizisindeki ortalama rekürsif
//
//  Created by Mustafa Seyyit DOĞAN on 29.05.2024.
//

// This program calculates the average of a given number of integers using recursion.

#include <stdio.h>

float average(int count, int sum);

void main() {
    int numberOfEntries;
    float avg;
    
    printf("How many numbers will be entered?\n");
    scanf("%d", &numberOfEntries);
    
    avg = average(numberOfEntries, 0) / numberOfEntries;
    printf("The average of the entered numbers is: %.2f\n", avg);
}

float average(int count, int sum) {
    int number;
    
    if (count == 0) {
        return sum;
    } else {
        printf("Enter a number:\n");
        scanf("%d", &number);
        sum += number;
    }
    
    return average(count - 1, sum); 
}

