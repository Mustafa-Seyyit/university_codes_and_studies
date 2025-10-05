#include <stdio.h>

// This program takes three numbers as input and finds the maximum and minimum values among them.
int main() {
    int i, sayi[3];

    printf("Enter three numbers: ");

    for(i = 0; i < 3; i++) {
        scanf("%d", &sayi[i]);
    }

    int max = sayi[0], min = sayi[0];

    for(i = 0; i < 3; i++) {
        if(max < sayi[i]) {
            max = sayi[i];
        }
        if(min > sayi[i]) {
            min = sayi[i];
        }
    }

    printf("Maximum number: %d\nMinimum number: %d\n", max, min);
    
    return 0; }
