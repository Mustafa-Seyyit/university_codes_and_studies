//
//  main.c
//  görüntü işleme örneği
//
//  Created by Mustafa Seyyit DOĞAN on 2.06.2024.
//



// This code checks for an exact match and the closest match of a submatrix within a larger matrix.

#include <stdio.h>

#define M 5
#define N 3

int searchPattern[3][3] = {
    {0, 1, 0},
    {0, 1, 0},
    {1, 1, 1}
};

int checkExactMatch(int matrix[M][M], int row, int column);
float checkSimilarity(int matrix[M][M], int row, int column);

void main(void) {
    int matrix[M][M] = {
        {0, 0, 0, 0, 0},
        {0, 1, 1, 0, 0},
        {0, 0, 1, 0, 0},
        {0, 0, 1, 1, 1},
        {0, 0, 0, 0, 0}
    };

    // Check for an exact match
    for (int i = 0; i <= M - N; i++) {
        for (int j = 0; j <= M - N; j++) {
            if (checkExactMatch(matrix, i, j) == 1) {
                printf("The searched pattern was found in the matrix at center coordinates row: %d column: %d\n", i + 1, j + 1);
                return;
            }
        }
    }

    // Check for the closest match
    int bestRow = 0, bestColumn = 0;
    float similarity = 0;

    for (int i = 0; i <= M - N; i++) {
        for (int j = 0; j <= M - N; j++) {
            float currentSimilarity = checkSimilarity(matrix, i, j);
            if (currentSimilarity > similarity) {
                similarity = currentSimilarity;
                bestRow = i;
                bestColumn = j;
            }
        }
    }

    similarity = similarity / (N * N); // N*N: number of elements in the searched matrix

    printf("The similarity ratio of the closest shape is %0.2f\nCenter coordinates:\nRow: %d\nColumn: %d\n", similarity, bestRow + 1, bestColumn + 1);
}

float checkSimilarity(int matrix[M][M], int row, int column) {
    int count = 0;
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            if (searchPattern[i][j] == matrix[row + i][column + j]) {
                count++;
            }
        }
    }
    return count;
}

int checkExactMatch(int matrix[M][M], int row, int column) {
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            if (searchPattern[i][j] != matrix[row + i][column + j]) {
                return 0;
            }
        }
    }
    return 1;
}


