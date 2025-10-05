//
//  main.c
//  pointer ile girilen bir dizinin tersini yazdırma
//
//  Created by Mustafa Seyyit DOĞAN on 3.06.2024.
//

// This program reads a string from the user and prints it in reverse order.

#include <stdio.h>

int main(void) {
    char dizi[100];
    char *p;
    int length;
    p = dizi;
    
    printf("Enter the string: ");
    scanf("%s", dizi);
    
    for (length = 0; dizi[length] != '\0'; length++) {
    }

    p += length - 1;
    
    printf("The reverse of the string is: ");
    
    for (; length != 0; length--) {
        printf("%c", *p--);
    }
    
    printf("\n");
    return 0;
}
