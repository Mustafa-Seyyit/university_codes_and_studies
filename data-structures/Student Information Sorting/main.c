//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 30.04.2024.
//

/*
 * This program collects and displays details of five students,
 * including their number, name, surname, midterm grade, and final grade,
 * and sorts the students by their names.
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct Student {
    int number;
    char name[50];
    char surname[50];
    float midtermGrade;
    float finalGrade;
};

int compareStudentsByName(const void *a, const void *b) {
    const struct Student *studentA = *(const struct Student **)a;
    const struct Student *studentB = *(const struct Student **)b;
    return strcmp(studentA->name, studentB->name);
}

int main() {
    struct Student *students[5];

    for (int i = 0; i < 5; i++) {
        students[i] = (struct Student *)malloc(sizeof(struct Student));
        if (students[i] == NULL) {
            printf("Memory allocation failed\n");
            return 1;
        }

        printf("Enter details for Student %d:\n", i + 1);
        printf("Number: ");
        scanf("%d", &students[i]->number);
        printf("Name: ");
        scanf("%s", students[i]->name);
        printf("Surname: ");
        scanf("%s", students[i]->surname);
        printf("Midterm Grade: ");
        scanf("%f", &students[i]->midtermGrade);
        printf("Final Grade: ");
        scanf("%f", &students[i]->finalGrade);
        printf("\n");
    }

    qsort(students, 5, sizeof(struct Student *), compareStudentsByName);

    printf("Students sorted by name:\n");
    for (int i = 0; i < 5; i++) {
        printf("Student %d\n", i + 1);
        printf("Number: %d\n", students[i]->number);
        printf("Name: %s\n", students[i]->name);
        printf("Surname: %s\n", students[i]->surname);
        printf("Midterm Grade: %.2f\n", students[i]->midtermGrade);
        printf("Final Grade: %.2f\n", students[i]->finalGrade);
        printf("\n");
    }

    for (int i = 0; i < 5; i++) {
        free(students[i]);
    }

    return 0;
}
