//
//  main.c
//  kalan öğrenciler
//
//  Created by Mustafa Seyyit DOĞAN on 21.05.2024.
//

// This code calculates the average grade and the number of students who passed or failed based on a given passing grade.

#include <stdio.h>

#define MAXSTUDENTS 100

void calculate(int students, float passingGrade);

int main(void) {
    int students;
    float passingGrade;

    printf("Enter the number of students: ");
    scanf("%d", &students);
    if (students > MAXSTUDENTS) {
        printf("Too many students entered.\n");
        return 0;
    }
    printf("Enter the passing grade: ");
    scanf("%f", &passingGrade);

    calculate(students, passingGrade);
}

void calculate(int students, float passingGrade) {
    float studentGrades[100], average = 0.0;
    int failedCount = 0;

    for (int i = 0; i < students; i++) {
        printf("Enter grade for student %d: ", i + 1);
        scanf("%f", &studentGrades[i]);
        average += studentGrades[i];

        if (studentGrades[i] < passingGrade) {
            failedCount++;
        }
    }

    printf("%d students failed, %d students passed.\n", failedCount, students - failedCount);
    printf("The average grade is %.2f.\n", average / students);
}

