//
//  main.c
//  yapılar(struct)
//
//  Created by Mustafa Seyyit DOĞAN on 24.06.2024.
//

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// A program to manage student information, including sorting and searching by name.

struct student {
    int number;                 // Student number
    char name[40];             // Student name
    char surname[40];          // Student surname
    float midtermGrade;        // Midterm grade
    float finalGrade;          // Final grade
};

void sortStudents(struct student *students[]);
int compareStudents(struct student *a, struct student *b);
void showSearchedStudent(struct student *students[], char searchName[40]);

int main(void) {
    char searchName[40];
    struct student *students[5];
    
    float midtermSum = 0, finalSum = 0, finalYearAverage;

    for (int i = 0; i < 5; i++) {
        students[i] = (struct student*) malloc(sizeof(struct student));
        
        if (students[i] == NULL) {
            printf("Insufficient memory allocation\n");
            return 1;
        }
        
        printf("%d. student's information\n", i + 1);
        
        printf("Number: ");
        scanf("%d", &students[i]->number);
        
        printf("Name: ");
        scanf("%s", students[i]->name);
        
        printf("Surname: ");
        scanf("%s", students[i]->surname);
        
        printf("Midterm grade: ");
        scanf("%f", &students[i]->midtermGrade);
        midtermSum += students[i]->midtermGrade;
        
        printf("Final grade: ");
        scanf("%f", &students[i]->finalGrade);
        finalSum += students[i]->finalGrade;
    }
    
    finalYearAverage = ((midtermSum * 4 / 10) + (finalSum * 6 / 10)) / 5;
    
    printf("\nFinal year average: %0.1f\n", finalYearAverage);
    
    sortStudents(students);
    
    printf("The sorted order is:\n");
    
    for (int i = 0; i < 5; i++) {
        printf("%d. student's name: %s\n", i + 1, students[i]->name);
    }
    
    printf("Enter the name of the student you want to search: ");
    scanf("%s", searchName);
    
    showSearchedStudent(students, searchName);
    
    for (int i = 0; i < 5; i++) {
        free(students[i]);
    }
    
    return 0;
}

void sortStudents(struct student *students[]) {
    struct student temp;
    
    for (int i = 0; i < 5 - 1; i++) {
        for (int j = i + 1; j < 5; j++) {
            if (compareStudents(students[i], students[j]) > 0) {
                temp = *students[i];
                *students[i] = *students[j];
                *students[j] = temp;
            }
        }
    }
}

int compareStudents(struct student *a, struct student *b) {
    return strcmp(a->name, b->name);
}

void showSearchedStudent(struct student *students[], char searchName[40]) {
    for (int i = 0; i < 5; i++) {
        if (strcmp(students[i]->name, searchName) == 0) {
            printf("\nRequested student:\n");
            printf("Number: %d\n", students[i]->number);
            printf("Name: %s\n", students[i]->name);
            printf("Surname: %s\n", students[i]->surname);
            printf("Midterm grade: %0.1f\n", students[i]->midtermGrade);
            printf("Final grade: %0.1f\n", students[i]->finalGrade);
        }
    }
}

