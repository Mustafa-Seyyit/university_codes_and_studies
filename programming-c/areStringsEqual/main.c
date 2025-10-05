/*
 this project created by the Mustafa Seyyit Doğan
 
 project subject:it is examined whethever 2 text by the user are the same.
 
 */
#include <stdio.h>

int areStringsEqual(char str1[], char str2[]) {
    int length1 = 0, length2 = 0, i = 0;

    while (str1[i] != '\0') {
        length1++;
        i++;
    }

    i = 0;

    while (str2[i] != '\0') {
        length2++;
        i++;
    }

    if (length1 == length2) {
        for (i = 0; i < length1; i++) {
            if (str1[i] != str2[i]) {
                return 0;
            }
        }
        return 1;
    } else {
        return 0;
    }
}

int main(void) {
    char string1[200], string2[200];
    int comparisonResult;

    printf("Enter two strings:\n");
    gets(string1);
    gets(string2);

    comparisonResult = areStringsEqual(string1, string2);

    if (comparisonResult == 1) {
        printf("The two strings are the same.\n");
    } else {
        printf("The two strings are different.\n");
    }
    
    return 0;
}

