//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 30.04.2024.
//

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/*
   This program stores information for five students, sorts them by their names,
   and allows searching for a student by name.
*/

struct Student {
    int id;
    char firstName[50];
    char lastName[50];
    float midtermGrade;
    float finalGrade;
};

int compareByName(const void *a, const void *b) {
    const struct Student *studentA = *(const struct Student **)a;
    const struct Student *studentB = *(const struct Student **)b;
    return strcmp(studentA->firstName, studentB->firstName);
}

int main() {
    struct Student *students[5];

    for (int i = 0; i < 5; i++) {
        students[i] = (struct Student *)malloc(sizeof(struct Student));
        if (students[i] == NULL) {
            printf("Memory allocation failed\n");
            return 1;
        }
        
        printf("Enter details for student %d:\n", i + 1);
        printf("ID: ");
        scanf("%d", &students[i]->id);
        printf("First Name: ");
        scanf("%s", students[i]->firstName);
        printf("Last Name: ");
        scanf("%s", students[i]->lastName);
        printf("Midterm Grade: ");
        scanf("%f", &students[i]->midtermGrade);
        printf("Final Grade: ");
        scanf("%f", &students[i]->finalGrade);
        printf("\n");
    }

    qsort(students, 5, sizeof(struct Student *), compareByName);

    char searchName[50];
    printf("Enter the first name of the student you want to search for: ");
    scanf("%s", searchName);

    int found = 0;
    for (int i = 0; i < 5; i++) {
        if (strcmp(students[i]->firstName, searchName) == 0) {
            printf("Student found:\n");
            printf("ID: %d\n", students[i]->id);
            printf("First Name: %s\n", students[i]->firstName);
            printf("Last Name: %s\n", students[i]->lastName);
            printf("Midterm Grade: %.2f\n", students[i]->midtermGrade);
            printf("Final Grade: %.2f\n", students[i]->finalGrade);
            found = 1;
            break;
        }
    }

    if (!found) {
        printf("Student with name '%s' not found.\n", searchName);
    }

    for (int i = 0; i < 5; i++) {
        free(students[i]);
    }

    return 0;
}
