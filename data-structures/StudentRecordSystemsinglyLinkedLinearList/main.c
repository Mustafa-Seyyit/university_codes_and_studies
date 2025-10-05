//
//  main.c
//  tek bagli dogrusal liste
//
//  Created by Mustafa Seyyit DOĞAN on 25.06.2024.
//

// This program manages a student record system where students can be added, updated, deleted, and queried.

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct node {
    int number;
    char name[40];
    float midtermGrade;
    float finalGrade;
    struct node *next;
};

typedef struct node Node;

// Function declarations
Node *createList(Node *head);
Node *addRecord(Node *head);
void listRecords(Node *head);
Node *updateRecord(Node *head);
Node *deleteRecord(Node *head);
float calculateAverage(Node *head);
void displayTopStudent(Node *head);

int main(void) {
    int choice;
    Node *head = NULL;
    
    printf("First, create a student list:\n");
    head = createList(head);
   
    while (1) {
        printf("1 - Add new record\n");
        printf("2 - List records\n");
        printf("3 - Update record\n");
        printf("4 - Delete record\n");
        printf("5 - Calculate class average\n");
        printf("6 - Show top student information\n");
        printf("8 - Exit the program\n");
        
        printf("What operation do you want to perform? ");
        scanf("%d", &choice);
        
        switch (choice) {
            case 1:
                head = addRecord(head);
                break;
            case 2:
                listRecords(head);
                break;
            case 3:
                head = updateRecord(head);
                break;
            case 4:
                head = deleteRecord(head);
                break;
            case 5:
                printf("Average: %.1f\n", calculateAverage(head));
                break;
            case 6:
                displayTopStudent(head);
                break;
            case 8:
                return 0;
        }
    }
}

Node *createList(Node *head) {
    printf("How many elements will the list have? ");
    int elementCount;
    scanf("%d", &elementCount);
    
    Node *p;
    for (int i = 0; i < elementCount; i++) {
        Node *newNode = (Node *) malloc(sizeof(Node));
        
        printf("%d. Enter student number: ", i + 1);
        scanf("%d", &newNode->number);
        
        printf("%d. Enter student name: ", i + 1);
        scanf("%s", newNode->name);
        
        printf("%d. Enter midterm grade: ", i + 1);
        scanf("%f", &newNode->midtermGrade);
        
        printf("%d. Enter final grade: ", i + 1);
        scanf("%f", &newNode->finalGrade);
        
        newNode->next = head; // Insert at the beginning
        head = newNode;
    }
    return head;
}

Node *addRecord(Node *head) {
    Node *newNode = (Node *) malloc(sizeof(Node));
  
    printf("Enter student number: ");
    scanf("%d", &newNode->number);
    
    printf("Enter student name: ");
    scanf("%s", newNode->name);
    
    printf("Enter midterm grade: ");
    scanf("%f", &newNode->midtermGrade);
    
    printf("Enter final grade: ");
    scanf("%f", &newNode->finalGrade);
    
    newNode->next = head; // Insert at the beginning
    head = newNode;

    return head;
}

void listRecords(Node *head) {
    printf("1 - Search by number\n");
    printf("2 - Search by name\n");
    printf("3 - List students with passing grades (>= 60)\n");

    int choice, stdNo;
    char stdName[40];
    Node *p = head;
    printf("Choose operation: ");
    scanf("%d", &choice);
    
    switch (choice) {
        case 1:
            printf("Enter student number: ");
            scanf("%d", &stdNo);
            while (p != NULL) {
                if (p->number == stdNo) {
                    printf("Student found:\n");
                    printf("Number: %d\n", p->number);
                    printf("Name: %s\n", p->name);
                    printf("Midterm grade: %.2f\n", p->midtermGrade);
                    printf("Final grade: %.2f\n", p->finalGrade);
                    return;
                }
                p = p->next;
            }
            printf("Student not found.\n");
            return;

        case 2:
            printf("Enter student name: ");
            scanf("%s", stdName);
            while (p != NULL) {
                if (strcmp(p->name, stdName) == 0) {
                    printf("Student found:\n");
                    printf("Number: %d\n", p->number);
                    printf("Name: %s\n", p->name);
                    printf("Midterm grade: %.2f\n", p->midtermGrade);
                    printf("Final grade: %.2f\n", p->finalGrade);
                    return;
                }
                p = p->next;
            }
            printf("Student not found.\n");
            return;

        case 3:
            printf("Students with passing grades (60 and above):\n");
            while (p != NULL) {
                float average = (p->midtermGrade * 0.4) + (p->finalGrade * 0.6);
                if (average >= 60) {
                    printf("%s\n", p->name);
                }
                p = p->next;
            }
            return;

        default:
            break;
    }
}

Node *updateRecord(Node *head) {
    int stdNo;
    printf("Enter the student number for updating: ");
    scanf("%d", &stdNo);
    
    Node *p = head;
    while (p != NULL) {
        if (p->number == stdNo) {
            printf("Enter updated name: ");
            scanf("%s", p->name);
            printf("Enter updated midterm grade: ");
            scanf("%f", &p->midtermGrade);
            printf("Enter updated final grade: ");
            scanf("%f", &p->finalGrade);
            return head;
        }
        p = p->next;
    }
    printf("Student not found.\n");
    return head;
}

Node *deleteRecord(Node *head) {
    int stdNo;
    printf("Enter the student number to delete: ");
    scanf("%d", &stdNo);
    
    Node *p = head, *prev = NULL;

    while (p != NULL) {
        if (p->number == stdNo) {
            if (prev == NULL) { // Deleting the head node
                head = p->next;
            } else {
                prev->next = p->next;
            }
            free(p);
            printf("Student deleted successfully.\n");
            return head;
        }
        prev = p;
        p = p->next;
    }
    printf("Student not found.\n");
    return head;
}

float calculateAverage(Node *head) {
    Node *p = head;
    float total = 0;
    int count = 0;

    while (p != NULL) {
        total += (p->midtermGrade * 0.4) + (p->finalGrade * 0.6);
        count++;
        p = p->next;
    }

    return count == 0 ? 0 : total / count; // Return 0 if no students
}

void displayTopStudent(Node *head) {
    Node *p = head;
    Node *topStudent = p;

    while (p != NULL) {
        float currentAverage = (p->midtermGrade * 0.4) + (p->finalGrade * 0.6);
        float topAverage = (topStudent->midtermGrade * 0.4) + (topStudent->finalGrade * 0.6);

        if (currentAverage > topAverage) {
            topStudent = p;
        }
        p = p->next;
    }

    p = head;
    printf("Top student(s): ");
    while (p != NULL) {
        float currentAverage = (p->midtermGrade * 0.4) + (p->finalGrade * 0.6);
        float topAverage = (topStudent->midtermGrade * 0.4) + (topStudent->finalGrade * 0.6);

        if (currentAverage == topAverage) {
            printf("%s ", p->name);
        }
        p = p->next;
    }
    printf("\n");
}

