//
//  main.c
//  n elemanlı  dizinin elemanları toplamı rekürüsiv
//
//  Created by Mustafa Seyyit DOĞAN on 27.02.2024.
//

#include <stdio.h>

// This program calculates the sum of elements in an array using recursion.
int dizininToplaminiBul(int dizi[], int n) {
    if (n == 0)
        return 0;
    else
        return dizi[n - 1] + dizininToplaminiBul(dizi, n - 1);
}

int main() {
    int N;
    printf("Enter the size of the array: ");
    scanf("%d", &N);

    int dizi[N];
    printf("Enter the elements of the array:\n");
    for (int i = 0; i < N; i++) {
        printf("Element %d: ", i + 1);
        scanf("%d", &dizi[i]);
    }

    int toplam = dizininToplaminiBul(dizi, N);

    printf("The sum of the elements in the array: %d\n", toplam);

    return 0;
}
