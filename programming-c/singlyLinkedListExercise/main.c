//
//  main.c
//  TekBagliListeSlaytAlistirma2
//
//  Created by Mustafa Seyyit DOĞAN on 18.10.2024.
//

#include <stdio.h>
#include <stdlib.h>

// This program manages a list of students, allowing for adding, deleting, sorting, and displaying student records.

typedef struct student {
    int number;
    char name[40];
    int midTermGrade;
    int finalGrade;
    struct student *next;
    float basari; // success
} student;

// Function prototypes
student *addStudent(student *head);
student *deleteStudent(student *head, int id);
student *sortList(student *head);
float classAverage(student *head);
void bestStudent(student *head);
void showList(student *head);

int main(void) {
    int choice;
    student *head = NULL;
    do {
        printf("1-Create list/add element\n2-Delete element from list\n3-Sort and display list\n4-Display class average\n5-Display best student\n6-Exit\n");
        scanf("%d", &choice);
        switch (choice) {
            case 1:
                head = addStudent(head);
                break;
            case 2: {
                int id;
                printf("Which student's number do you want to delete? ");
                scanf("%d", &id);
                head = deleteStudent(head, id);
                break;
            }
            case 3:
                head = sortList(head);
                showList(head);
                break;
            case 4:
                printf("Class average: %.2f\n", classAverage(head));
                break;
            case 5:
                bestStudent(head);
                break;
            case 6:
                printf("Exiting...\n");
                break;
            default:
                printf("Invalid selection, please try again.\n");
                break;
        }
    } while (choice != 6);
    
    // Free allocated memory
    while (head != NULL) {
        student *temp = head;
        head = head->next;
        free(temp);
    }
    return 0;
}

void showList(student *head) {
    if (head == NULL) {
        printf("List is empty.\n");
    } else {
        student *p = head;
        while (p != NULL) {
            printf("Number: %d\n", p->number);
            printf("Name: %s\n", p->name);
            printf("Mid Term Grade: %d\n", p->midTermGrade);
            printf("Final Grade: %d\n", p->finalGrade);
            printf("Success: %.2f\n", p->basari);
            p = p->next;
        }
    }
}

void bestStudent(student *head) {
    if (head == NULL) {
        printf("No students in the list.\n");
    } else {
        student *p = head;
        student *best = head;
        while (p != NULL) {
            if (p->basari > best->basari) {
                best = p;
            }
            p = p->next;
        }
        printf("\nBest student:\n");
        printf("Number: %d\n", best->number);
        printf("Name: %s\n", best->name);
        printf("Mid Term Grade: %d\n", best->midTermGrade);
        printf("Final Grade: %d\n", best->finalGrade);
        printf("Success: %.2f\n", best->basari);
    }
}

float classAverage(student *head) {
    float average = 0;
    int count = 0;
    if (head != NULL) {
        student *p = head;
        while (p != NULL) {
            average += p->basari;
            count++;
            p = p->next;
        }
    }
    return count > 0 ? average / count : 0;
}

student *sortList(student *head) {
    if (head == NULL) {
        return NULL; // No need to sort if the list is empty
    }
    
    // Bubble sort implementation
    int swapped;
    do {
        swapped = 0;
        student *p = head;
        while (p->next != NULL) {
            if (p->basari < p->next->basari) {
                // Swap data instead of nodes
                student temp = *p;
                *p = *(p->next);
                *(p->next) = temp;
                swapped = 1;
            }
            p = p->next;
        }
    } while (swapped);
    
    return head;
}

student *deleteStudent(student *head, int id) {
    if (head == NULL) {
        printf("No element to delete from the list.\n");
        return head;
    }
    
    student *p = head;
    if (p->number == id) {
        head = p->next; // Update head if the first element is to be deleted
        free(p);
    } else {
        student *before = head;
        student *now = head->next;
        while (now != NULL && now->number != id) {
            now = now->next;
            before = before->next;
        }
        if (now != NULL) {
            before->next = now->next; // Link previous node to the next of the deleted node
            free(now);
        } else {
            printf("The ID to be deleted is not in the list.\n");
        }
    }
    return head;
}

student *addStudent(student *head) {
    student *newRecord = (student *)malloc(sizeof(student));
    if (newRecord == NULL) {
        printf("Insufficient memory allocated.\n");
        return head;
    }
    printf("\nEnter the information of the student to be registered:\n");
    printf("Number: "); scanf("%d", &newRecord->number);
    printf("Name: "); getchar(); gets(newRecord->name);
    printf("Mid Term Grade: "); scanf("%d", &newRecord->midTermGrade);
    printf("Final Grade: "); scanf("%d", &newRecord->finalGrade);
    newRecord->basari = newRecord->midTermGrade * 0.4 + newRecord->finalGrade * 0.6; // Calculating success
    newRecord->next = NULL;

    if (head == NULL) {
        printf("\nThis record is the first element of the list.\n");
        head = newRecord;
    } else {
        student *p = head;
        while (p->next != NULL) {
            p = p->next;
        }
        p->next = newRecord;
    }
    return head;
}
