//
//  main.c
//  enumStructCalismalari
//
//  Created by Mustafa Seyyit DOĞAN on 17.10.2024.
//

#include <stdio.h>
#include <string.h>
#include <stdlib.h>

// This program collects student information, calculates averages, and allows searching for student details by name.
struct student {
    int number;
    char name[40];
    char surName[20];
    int midTermGrade;
    int finalGrade;
};

int main(void) {
    float average = 0;
    struct student *person[5];
    
    for (int i = 0; i < 5; i++) {
        person[i] = (struct student*) malloc(sizeof(struct student));
    }
    
    for (int i = 0; i < 5; i++) {
        printf("Enter the information for student %d.\n", i + 1);
        printf("Number: "); scanf("%d", &person[i]->number); getchar();
        printf("Name: "); gets(person[i]->name);
        printf("Surname: "); gets(person[i]->surName);
        printf("Mid term grade: "); scanf("%d", &person[i]->midTermGrade);
        printf("Final grade: "); scanf("%d", &person[i]->finalGrade);
        average += person[i]->finalGrade * 6 / 10 + person[i]->midTermGrade * 4 / 10;
    }
    
    average /= 5;
    
    for (int i = 0; i < 4; i++) {
        for (int j = i + 1; j < 5; j++) {
            if (strcmp(person[i]->name, person[j]->name) > 0) {
                char temp[40];
                strcpy(temp, person[j]->name);
                strcpy(person[j]->name, person[i]->name);
                strcpy(person[i]->name, temp);
            }
        }
    }
    
    printf("\nWhich student's information would you like to view?");
    char name[40]; getchar(); gets(name);
    int i = 0;
    
    while (i < 5 && strcmp(person[i]->name, name) != 0) {
        i++;
    }
    
    if (strcmp(person[i]->name, name) == 0) {
        printf("Number: %d\n", person[i]->number);
        printf("Name: %s\n", person[i]->name);
        printf("Surname: %s\n", person[i]->surName);
        printf("Mid term grade: %d\n", person[i]->midTermGrade);
        printf("Final grade: %d\n", person[i]->finalGrade);
        for (int i = 0; i < 5; i++) {
            free(person[i]);
        }
        return 0;
    }
    
    printf("The student you entered does not exist.\n");
    
    for (int i = 0; i < 5; i++) {
        free(person[i]);
    }
    
    return 0;
}
