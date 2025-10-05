//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 18.06.2024.
//

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// This program concatenates a first name and a last name, allocating memory dynamically.
int main(void) {
    char *firstName = "mustafa seyyit", *lastName = "dogan", *fullName, *tempPointer;
    
    int firstNameLength, lastNameLength;
    
    firstNameLength = strlen(firstName);
    lastNameLength = strlen(lastName);
    
    fullName = (char*) malloc((firstNameLength + 1) * sizeof(char));
    
    if (fullName == NULL) {
        printf("Not enough memory available\n");
        return 1;
    }
    
    strcpy(fullName, firstName);
    
    tempPointer = (char*) realloc(fullName, (firstNameLength + lastNameLength + 2) * sizeof(char));
    
    if (tempPointer == NULL) {
        printf("Not enough memory available\n");
        free(fullName);
        return 1; // Ensure we exit here after freeing memory
    }
    fullName = tempPointer;
    
    strcat(fullName, " ");
    strcat(fullName, lastName);
    
    printf("%s\n", fullName);
    
    free(fullName);
    return 0;
}
