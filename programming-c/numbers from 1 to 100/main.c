/*
 Description in turkish: bu program 1'den 100'e kadar sayıları yazdırır.
 
 Description in English:this program prints the numbers from 1 to 100.
 */


#include <stdio.h>

int main() {
    int number;
    
    for (number = 1; number <= 100; number++) {
        printf("%d ", number);
    }
    
    return 0;
}
