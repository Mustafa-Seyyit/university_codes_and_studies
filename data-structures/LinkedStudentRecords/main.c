//
//  main.c
//  listeleme
//
//  Created by Mustafa Seyyit DOĞAN on 7.05.2024.
//
/*
 This code is designed to create and manage a linked list of student records. Each student has fields for name, surname, student number, midterm grade, final grade, and a pointer to the next student record. 
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct Student {
    char name[20];
    char surname[10];
    int number;
    float midtermGrade;
    float finalGrade;
    struct Student *next;
};

typedef struct Student Student;
Student *head = NULL;

// Function prototypes
Student* addRecord(Student* head);
void listRecords(Student* head);
void updateRecord(Student* head);
Student* deleteRecord(Student* head);
void calculateClassAverage(Student* head);
void findTopStudent(Student* head);

int main() {
    int studentCount, choice;
    printf("How many students are there? ");
    scanf("%d", &studentCount);

    for (int i = 0; i < studentCount; i++) {
        if (i == 0) {
            head = (Student*)malloc(sizeof(Student));
            head->next = NULL;
        } else {
            addRecord(head);
        }
    }

    do {
        printf("1- Add New Record\n2- List Records\n3- Update Record\n4- Delete Record\n");
        printf("5- Calculate Class Average\n6- Show Top Student\n7- Exit\n");
        printf("Select an operation: ");
        scanf("%d", &choice);

        switch (choice) {
            case 1:
                head = addRecord(head);
                break;
            case 2:
                listRecords(head);
                break;
            case 3:
                updateRecord(head);
                break;
            case 4:
                head = deleteRecord(head);
                break;
            case 5:
                calculateClassAverage(head);
                break;
            case 6:
                findTopStudent(head);
                break;
            case 7:
                printf("Exiting...\n");
                break;
            default:
                printf("Invalid choice!\n");
        }
    } while (choice != 7);

    // Free allocated memory
    Student *temp;
    while (head != NULL) {
        temp = head;
        head = head->next;
        free(temp);
    }

    return 0;
}

Student* addRecord(Student* head) {
    Student *newStudent = (Student*)malloc(sizeof(Student));
    if (newStudent == NULL) {
        printf("Memory allocation failed.\n");
        return head;
    }

    printf("Enter student's name: ");
    scanf("%s", newStudent->name);
    printf("Enter student's surname: ");
    scanf("%s", newStudent->surname);
    printf("Enter student's number: ");
    scanf("%d", &newStudent->number);
    printf("Enter midterm grade: ");
    scanf("%f", &newStudent->midtermGrade);
    printf("Enter final grade: ");
    scanf("%f", &newStudent->finalGrade);

    newStudent->next = head;
    head = newStudent;
    return head;
}

void listRecords(Student* head) {
    Student *temp = head;
    while (temp != NULL) {
        printf("Number: %d, Name: %s %s, Midterm: %.2f, Final: %.2f\n", temp->number, temp->name, temp->surname, temp->midtermGrade, temp->finalGrade);
        temp = temp->next;
    }
}

void updateRecord(Student* head) {
    int number;
    printf("Enter the student's number to update: ");
    scanf("%d", &number);

    Student *temp = head;
    while (temp != NULL) {
        if (temp->number == number) {
            printf("Enter new midterm grade: ");
            scanf("%f", &temp->midtermGrade);
            printf("Enter new final grade: ");
            scanf("%f", &temp->finalGrade);
            printf("Record updated successfully.\n");
            return;
        }
        temp = temp->next;
    }
    printf("Student with number %d not found.\n", number);
}

Student* deleteRecord(Student* head) {
    int number;
    printf("Enter the student's number to delete: ");
    scanf("%d", &number);

    Student *temp = head, *prev = NULL;
    while (temp != NULL && temp->number != number) {
        prev = temp;
        temp = temp->next;
    }

    if (temp == NULL) {
        printf("Student with number %d not found.\n", number);
        return head;
    }

    if (prev == NULL) {
        head = temp->next;
    } else {
        prev->next = temp->next;
    }

    free(temp);
    printf("Record deleted successfully.\n");
    return head;
}

void calculateClassAverage(Student* head) {
    float totalFinal = 0.0;
    int count = 0;
    Student *temp = head;
    while (temp != NULL) {
        totalFinal += temp->finalGrade;
        count++;
        temp = temp->next;
    }
    printf("Class average: %.2f\n", totalFinal / count);
}

void findTopStudent(Student* head) {
    if (head == NULL) {
        printf("No students in the list.\n");
        return;
    }

    Student *topStudent = head;
    Student *temp = head->next;
    while (temp != NULL) {
        if (temp->finalGrade > topStudent->finalGrade) {
            topStudent = temp;
        }
        temp = temp->next;
    }
    printf("Top student: %s %s, Final Grade: %.2f\n", topStudent->name, topStudent->surname, topStudent->finalGrade);
}

