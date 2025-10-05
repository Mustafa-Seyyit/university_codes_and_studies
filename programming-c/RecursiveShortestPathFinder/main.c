//
//  main.c
//  
//
//  Created by Mustafa Seyyit DOĞAN on 5.03.2024.
//



#include <stdio.h>

#define ROW 6
#define COLUMN 12

// Define movement directions for rows and columns: right, up, down, left
int rowMovement[] = {0, -1, 1, 0}; // Change in row
int columnMovement[] = {1, 0, 0, -1}; // Change in column

// Function declarations
void findShortestPath(int matrix[ROW][COLUMN], int visited[ROW][COLUMN], int row, int column, int *minDistance, int distance);
int isValid(int matrix[ROW][COLUMN], int visited[ROW][COLUMN], int row, int column);

/*
 * This program finds the shortest path in a matrix from the top-left corner
 * to the bottom-right corner. It uses a recursive approach to explore possible paths
 * while tracking the distance traveled and checking for valid movements.
 */
int main(void) {
    int matrix[ROW][COLUMN] = {
        {1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0},
        {1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0},
        {1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0},
        {0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1},
        {0, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1},
        {1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1}
    };
    
    int startRow = 0, startColumn = 0; // Initialize starting position
    int minDistance = (ROW * COLUMN) + 1; // Set an initial minimum distance
    int visited[ROW][COLUMN]; // Array to track visited cells
    
    // Initialize the visited array to all zeros (not visited)
    for (int i = 0; i < ROW; i++) {
        for (int j = 0; j < COLUMN; j++) {
            visited[i][j] = 0;
        }
    }
    
    // Start finding the shortest path from the top-left corner
    findShortestPath(matrix, visited, startRow, startColumn, &minDistance, 0);
    
    // Check if a valid path was found and print the result
    if (minDistance != (ROW * COLUMN) + 1) {
        printf("The shortest path is %d.\n", minDistance);
    } else {
        printf("No valid path found.\n");
    }
    
    return 0; // Exit the program
}

void findShortestPath(int matrix[ROW][COLUMN], int visited[ROW][COLUMN], int row, int column, int *minDistance, int distance) {
    // Check if we have reached the bottom-right corner
    if (row == ROW - 1 && column == COLUMN - 1) {
        // If the current distance is less than the minimum distance found so far
        if (distance < *minDistance) {
            *minDistance = distance; // Update the minimum distance
        }
        return; // Exit the function
    }
    
    visited[row][column] = 1; // Mark the current cell as visited
    
    // Explore all four possible movements (right, up, down, left)
    for (int i = 0; i < 4; i++) {
        int newRow = row + rowMovement[i]; // Calculate new row position
        int newColumn = column + columnMovement[i]; // Calculate new column position
        
        // Check if the new position is valid for movement
        if (isValid(matrix, visited, newRow, newColumn)) {
            findShortestPath(matrix, visited, newRow, newColumn, minDistance, distance + 1); // Recur for the new position
        }
    }
    visited[row][column] = 0; // Backtrack by marking the current cell as unvisited
}

int isValid(int matrix[ROW][COLUMN], int visited[ROW][COLUMN], int row, int column) {
    // Check if the new position is within the bounds of the matrix, is open (1),
    // and has not been visited yet
    return (row >= 0) && (row < ROW) && (column >= 0) && (column < COLUMN) &&
           (matrix[row][column] == 1) && !visited[row][column];
}


 
