//
//  main.c
//  rekürsif fonksiyon ile polindrom kontrolu
//
//  Created by Mustafa Seyyit DOĞAN on 29.05.2024.
//

// This program checks if the input string is a palindrome using recursion.

#include <stdio.h>
#include <string.h>

int checkPalindrome(char str[40], int strLength, int start, int end);

int main(void) {
    char word[40];
    
    printf("Enter a word: ");
    scanf("%s", word);
    int wordLength = strlen(word);
    
    if (checkPalindrome(word, wordLength - 1, 0, wordLength - 1) == 1) {
        printf("The entered word is a palindrome.\n");
    } else {
        printf("The entered word is not a palindrome.\n");
    }
    
    return 0;
}

int checkPalindrome(char str[40], int strLength, int start, int end) {
    if (start >= end) {
        return 1;
    }
    
    if (str[start] == str[end] && end >= strLength / 2) {
        return checkPalindrome(str, strLength, start + 1, end - 1);
    } else {
        return 0; 
    }
}


