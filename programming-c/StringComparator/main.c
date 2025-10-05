//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 23.06.2024.
//

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// This program compares two strings entered by the user, checks if they are identical, and compares their lengths if they are different.
int main(void){
    
    char *word1, *word2;
    int result;
    
    word1 = (char*) malloc(28 * sizeof(char));
    word2 = (char*) malloc(28 * sizeof(char));
    
    if (word1 == NULL || word2 == NULL) {
        printf("Not enough memory available\n");
        return 1;
    }
    
    printf("Enter the first word: ");
    scanf("%s", word1);
    
    printf("Enter the second word: ");
    scanf("%s", word2);
    
    result = strcmp(word1, word2);
    
    if (result == 0) {
        printf("The words are identical.\n");
        return 3;
    }
    else if (result < 0) {
        if (strlen(word2) - strlen(word1) == 0) {
            printf("The words are different but have the same length.\n");
            return 4;
        }
        else {
            printf("The second word is longer.\n");
            return 4;
        }
    }
    else if (result > 0) {
        if (strlen(word2) - strlen(word1) == 0) {
            printf("The words are different but have the same length.\n");
            return 5;
        }
        else {
            printf("The first word is longer.\n");
            return 5;
        }
    }

    free(word1);
    free(word2);
    return 0;
}
