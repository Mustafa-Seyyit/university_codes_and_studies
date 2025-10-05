//
//  main.c
//  kullancıKelimeleriniAlfabetikSiralama
//
//  Created by Mustafa Seyyit DOĞAN on 9.10.2024.
//

#include <stdio.h>
#include <string.h>
#include <stdlib.h>

char *newWord(void);

int main(void) {
    int wordCount = 0;
    int choice;
    char **wordsArray = (char **)malloc(2 * sizeof(char *));
    if (wordsArray == NULL)
        return -2;
    
    do {
        printf("1 - Enter a new word\n2 - Stop entering words\n");
        scanf("%d", &choice);
        getchar(); // To avoid issues with the next scanf or getchar
        
        switch (choice) {
            case 1:
                wordsArray[wordCount] = newWord();
                wordCount++;
                char **temp = (char **)realloc(wordsArray, (wordCount + 2) * sizeof(char *));
                if (temp == NULL) {
                    for (int i = 0; i < wordCount; i++) {
                        free(wordsArray[i]);
                    }
                    free(wordsArray); // Also free the array
                    return -3;
                }
                wordsArray = temp;
                break;
            
            case 2:
                break;
        }
    } while (choice != 2);
    
    // Alphabetical sorting
    int value;
    for (int i = 0; i < wordCount - 1; i++) {
        for (int j = i + 1; j < wordCount; j++) {
            value = strcmp(wordsArray[i], wordsArray[j]);
            if (value > 0) {
                // Swap the two words
                char *temp = wordsArray[i];
                wordsArray[i] = wordsArray[j];
                wordsArray[j] = temp;
            }
        }
    }
    
    // Print the words
    printf("\nThe alphabetical order of your words:\n");
    for (int i = 0; i < wordCount; i++) {
        printf("%s\n", wordsArray[i]);  // Add a new line after each word
        free(wordsArray[i]);  // Free memory for each word
    }
    
    free(wordsArray);  // Free memory allocated for the array
    return 0;
}

char *newWord(void) {
    char ch;
    int size = 0;
    printf("Enter the word: ");
    char *new = (char *)malloc(sizeof(char));
    if (new == NULL) {
        printf("Insufficient memory allocated");
        exit(1);
    }
    
    do {
        ch = getchar();
        new[size++] = ch;
        char *temp = (char *)realloc(new, (size + 1) * sizeof(char));
        if (temp == NULL) {
            printf("Insufficient memory allocated");
            free(new);
            exit(2);
        }
        new = temp;
    } while (ch != '\n' && ch != EOF);
    
    new[size - 1] = '\0'; // Make the last character the null terminator
    
    return new;
}
