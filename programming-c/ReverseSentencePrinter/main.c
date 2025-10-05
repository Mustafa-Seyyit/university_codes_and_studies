//
//  main.c
//  cümleyi tersten yazma dinamik bellek
//
//  Created by Mustafa Seyyit DOĞAN on 8.10.2024.
//



#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// This program reads a sentence from the user and prints it in reverse order.
void recursivewritefromlast(char *cümle, int boyut);

int main(void) {
    printf("Enter a word: ");
    char *metin = (char*) malloc(2 * sizeof(char));
    if (metin == NULL) {
        printf("Memory allocation failed.");
        return -1;
    }
    
    char ch;
    int boyut = 0;
    
    do {
        ch = getchar();
        metin[boyut] = ch;
        char *temp = (char*) realloc(metin, (boyut + 2) * sizeof(char));
        if (temp == NULL) {
            printf("Not enough memory.");
            free(metin);
            return -2;
        }
        metin = temp;
        boyut++;
    } while (ch != '\n');
    
    metin[boyut - 1] = '\0';
    
    recursivewritefromlast(metin, strlen(metin) - 1);
    free(metin);
    return 0;
}

void recursivewritefromlast(char *cümle, int boyut) {
    if (boyut < 0)
        return;
    int end = boyut;
    while (cümle[end] != ' ' && end >= 0)
        end--;
    for (int i = end + 1; i <= boyut; i++)
        printf("%c", cümle[i]);
    if (end >= 0)
        printf(" ");
    recursivewritefromlast(cümle, end - 1);
}
