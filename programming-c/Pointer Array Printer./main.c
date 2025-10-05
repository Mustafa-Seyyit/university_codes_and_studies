//
//  main.c
//  Created by Mustafa Seyyit DOĞAN on 19.03.2024.
//

/*
 * This program prints the elements of an integer array using a pointer.
 */

#include <stdio.h>

int main(void) {
    int i, array[3] = {1, 2, 3}, *pointer;
    pointer = array;
    
    for (i = 0; i < 3; i++) {
        printf("%d\n", *(pointer + i));
    }
    
    return 0;
}
