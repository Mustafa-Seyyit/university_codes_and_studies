#include <stdio.h>

// A program to calculate the average height and weight of students.

int main() {
    int i, j, matrix[10][2], totalHeight = 0, totalWeight = 0;

    for (i = 0; i < 10; i++) {
        for (j = 0; j < 2; j++) {
            if (j == 0) {
                printf("Enter the height of student %d: ", i + 1);
                scanf("%d", &matrix[i][j]);
                totalHeight += matrix[i][j]; // Sum heights
            } else {
                printf("Enter the weight of student %d: ", i + 1);
                scanf("%d", &matrix[i][j]);
                totalWeight += matrix[i][j]; // Sum weights
            }
        }
    }

    // Calculate averages
    int averageHeight = totalHeight / 10;
    int averageWeight = totalWeight / 10;

    printf("Average height: %d, Average weight: %d\n", averageHeight, averageWeight);

    return 0;
}

