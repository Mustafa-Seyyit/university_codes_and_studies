//
//  main.c
//  pointerla ters siralama
//
//  Created by Mustafa Seyyit DOĞAN on 3.06.2024.
//

// This program reverses the values of three integers using pointers.

#include <stdio.h>

void reverseValues(int *p1, int *p2, int *p3);

int main(void) {
    int a1 = 5, a2 = 6, a3 = 7;
    
    printf("Values before change:\n a1: %d a2: %d a3: %d\n", a1, a2, a3);
    
    reverseValues(&a1, &a2, &a3);
    
    printf("Values after change:\n a1: %d a2: %d a3: %d\n", a1, a2, a3);
    
    return 0;
}

void reverseValues(int *p1, int *p2, int *p3) {
    int temp;
    
    temp = *p1;
    *p1 = *p3;
    *p3 = temp; 
}

