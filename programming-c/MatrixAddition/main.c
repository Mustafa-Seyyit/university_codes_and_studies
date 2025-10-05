#include <stdio.h>

// A program to fill two matrices and add them.

int main() {
    int i, j;
    int matrix1[2][3], matrix2[1][3], sum[2][3]; // Adjusted sizes for addition

    // Fill the first matrix (2x3)
    printf("Fill the first matrix (2x3):\n");
    for (i = 0; i < 2; i++) {
        for (j = 0; j < 3; j++) {
            scanf("%d", &matrix1[i][j]);
        }
    }

    // Fill the second matrix (1x3)
    printf("Fill the second matrix (1x3):\n");
    for (i = 0; i < 1; i++) {
        for (j = 0; j < 3; j++) {
            scanf("%d", &matrix2[i][j]);
        }
    }

    // Initialize the sum matrix
    for (i = 0; i < 2; i++) {
        for (j = 0; j < 3; j++) {
            sum[i][j] = matrix1[i][j]; // Copy values from the first matrix
            if (i == 0) {
                sum[i][j] += matrix2[0][j]; // Add the second matrix's first row
            }
            printf("%d ", sum[i][j]); // Print the sum matrix
        }
        printf("\n"); // New line after each row
    }

    return 0;
}

