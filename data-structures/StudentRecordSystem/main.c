//
//  main.c
//  lab10
//
//  Created by Mustafa Seyyit DOĞAN on 14.05.2024.
//
// This program manages student records, allowing the user to create a file with student data,
// read and display data from the file, filter students based on grades, and save the results
// to different files based on their pass or fail status.

#include <stdio.h>
#include <stdlib.h>

#define MAX_SIZE 100 // Maximum number of students

// Student structure
typedef struct {
    int number;
    char name[50];
    float midterm;
    float final;
} Student;

// Function prototypes
void createFileAndEnterData(void);
void readFromFileAndList(void);
void listAbovePassingGrade(void);
void writePassingStudentsToFile(void);
void writeFailingStudentsToFile(void);
void writeFileSize(void);

int main(void) {
    int choice;

    do {
        // Show menu
        printf("\n--- MENU ---\n");
        printf("1- Create file and enter data\n");
        printf("2- Read from file\n");
        printf("3- List students with a passing grade above 60\n");
        printf("4- Write passing students to 'passing.txt' and failing students to 'failing.txt'\n");
        printf("5- Display file size\n");
        printf("6- Exit\n");
        printf("Your choice: ");
        scanf("%d", &choice);

        switch (choice) {
            case 1:
                createFileAndEnterData();
                break;
            case 2:
                readFromFileAndList();
                break;
            case 3:
                listAbovePassingGrade();
                break;
            case 4:
                writePassingStudentsToFile();
                writeFailingStudentsToFile();
                break;
            case 5:
                writeFileSize();
                break;
            case 6:
                printf("Exiting the program...\n");
                break;
            default:
                printf("Invalid choice. Please try again.\n");
                break;
        }
    } while (choice != 6);

    return 0;
}

void createFileAndEnterData(void) {
    FILE *file;
    Student students[MAX_SIZE];
    int i, n;

    printf("How many students will be recorded: ");
    scanf("%d", &n);

    file = fopen("grades.txt", "w");
    if (file == NULL) {
        printf("File could not be created.\n");
        return;
    }

    for (i = 0; i < n; i++) {
        printf("Student #%d number: ", i + 1);
        scanf("%d", &students[i].number);
        printf("Student #%d name: ", i + 1);
        scanf("%s", students[i].name);
        printf("Student #%d midterm: ", i + 1);
        scanf("%f", &students[i].midterm);
        printf("Student #%d final: ", i + 1);
        scanf("%f", &students[i].final);

        fprintf(file, "%d %s %.2f %.2f\n", students[i].number, students[i].name, students[i].midterm, students[i].final);
    }

    fclose(file);
}

void readFromFileAndList(void) {
    FILE *file;
    Student student;
    file = fopen("grades.txt", "r");

    if (file == NULL) {
        printf("File not found.\n");
        return;
    }

    printf("Number\tName\tMidterm\tFinal\n");
    while (fscanf(file, "%d %s %f %f", &student.number, student.name, &student.midterm, &student.final) != EOF) {
        printf("%d\t%s\t%.2f\t%.2f\n", student.number, student.name, student.midterm, student.final);
    }

    fclose(file);
}

void listAbovePassingGrade(void) {
    FILE *file;
    Student student;
    file = fopen("grades.txt", "r");

    if (file == NULL) {
        printf("File not found.\n");
        return;
    }

    printf("Number\tName\tMidterm\tFinal\n");
    while (fscanf(file, "%d %s %f %f", &student.number, student.name, &student.midterm, &student.final) != EOF) {
        if ((student.midterm * 0.4 + student.final * 0.6) >= 60) {
            printf("%d\t%s\t%.2f\t%.2f\n", student.number, student.name, student.midterm, student.final);
        }
    }

    fclose(file);
}

void writePassingStudentsToFile(void) {
    FILE *file, *passingFile;
    Student student;
    file = fopen("grades.txt", "r");
    passingFile = fopen("passing.txt", "w");

    if (file == NULL || passingFile == NULL) {
        printf("File not found.\n");
        return;
    }

    while (fscanf(file, "%d %s %f %f", &student.number, student.name, &student.midterm, &student.final) != EOF) {
        if ((student.midterm * 0.4 + student.final * 0.6) >= 60) {
            fprintf(passingFile, "%d %s %.2f %.2f\n", student.number, student.name, student.midterm, student.final);
        }
    }

    fclose(file);
    fclose(passingFile);
}

void writeFailingStudentsToFile(void) {
    FILE *file, *failingFile;
    Student student;
    file = fopen("grades.txt", "r");
    failingFile = fopen("failing.txt", "w");

    if (file == NULL || failingFile == NULL) {
        printf("File not found.\n");
        return;
    }

    while (fscanf(file, "%d %s %f %f", &student.number, student.name, &student.midterm, &student.final) != EOF) {
        if ((student.midterm * 0.4 + student.final * 0.6) < 60) {
            fprintf(failingFile, "%d %s %.2f %.2f\n", student.number, student.name, student.midterm, student.final);
        }
    }

    fclose(file);
    fclose(failingFile);
}

void writeFileSize(void) {
    FILE *file;
    long size;

    file = fopen("grades.txt", "r");

    if (file == NULL) {
        printf("File not found.\n");
        return;
    }

    fseek(file, 0L, SEEK_END);
    size = ftell(file);

    printf("File size: %ld bytes\n", size);

    fclose(file);
}
