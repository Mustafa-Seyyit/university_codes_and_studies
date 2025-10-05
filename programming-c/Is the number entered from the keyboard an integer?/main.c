//
//  main.c
//  klavyeden girilen sayı tam sayı mı?
//
//  Created by Mustafa Seyyit DOĞAN on 20.02.2024.
/* project subject:This project examines whether a number entered from the keyboard is an integer or not.
 */
#include <stdio.h>

int main(void) {
    float number;

    printf("Enter a number: ");
    scanf("%f", &number);
    
    if (number - (int)number == 0) {
        printf("The entered number is an integer.\n");
    } else {
        printf("The entered number is not an integer.\n");
    }
    
    return 0;
}
