//
//  main.c
//  şifreleme matrisi ve şifre kelime bulma
//
//  Created by Mustafa Seyyit DOĞAN on 2.06.2024.
//

// This program decrypts a message using a 3x3 matrix based on user-provided codes.

#include <stdio.h>

int main(void) {
    char matrix[3][3]; // 3x3 character matrix
    int code[9], length; // Array for the codes and its length
    int row, col; // Row and column variables for decryption

    printf("Enter the encrypted matrix:\n");
    
    // Input the 3x3 matrix
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            printf("Enter element at row %d, column %d:\n", j + 1, i + 1);
            scanf(" %c", &matrix[j][i]);
        }
    }
    
    printf("How many elements in the code?\n");
    scanf("%d", &length);
    
    printf("Enter the codes:\n");
    for (int i = 0; i < length; i++) {
        scanf("%d", &code[i]);
    }
    
    printf("Decrypted message: ");
    // Decrypt the message using the provided codes
    for (int i = 0; i < length; i++) {
        row = (code[i] / 10) - 1; // Get the row index
        col = (code[i] % 10) - 1; // Get the column index
        printf("%c", matrix[row][col]); // Print the character from the matrix
    }
    printf("\n");

    return 0; // Return 0 to indicate successful execution
}


