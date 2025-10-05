//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 2.06.2024.
//

#include <stdio.h>

// This program counts the number of even elements in an integer array.

int fonk(int *dizi, int elemansayisi);

void main(void) {
    
    int sayilar[9] = {8, 3, 5, 6, 2, 7, 1, 3, 276}, *p;
    p = sayilar;
    
    printf("dizideki tek eleman sayisi: %d", fonk(p, 9));
}

int fonk(int *dizi, int elemansayisi) {
    if (elemansayisi == -1) {
        return 0;
    } else {
        if (*dizi % 2 == 0) {
            return 1 + fonk(dizi + 1, elemansayisi - 1);
        } else {
            return fonk(dizi + 1, elemansayisi - 1);
        }
    }
}


