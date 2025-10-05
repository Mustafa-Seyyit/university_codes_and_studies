//
//  main.c
//  lab9OgrenciTekBagliListe
//
//  Created by Mustafa Seyyit DOĞAN on 25.10.2024.
//

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct student {
    int number;
    char name[40];
    float midTermGrade;
    float finalGrade;
    struct student *next;
} student;

// Function declarations
student *addRecord(student *head);
void recordListing(student *head);
void updateRecord(student *head);
student *deleteRecord(student *head);
void printClassAverage(student *head);
void bestStudent(student *head);
student *sortList(student *head);

int main(void) {
    int choice;
    student *head = NULL;
    do {
        printf("1- Add New Record\n2- List Records\n3- Update Record\n4- Delete Record\n5- Calculate Class Average\n6- Show Best Student by Average\n7- Exit\n");
        scanf("%d", &choice);
        switch (choice) {
            case 1:
                head = addRecord(head);
                break;
            case 2:
                recordListing(head);
                break;
            case 3:
                updateRecord(head);
                head = sortList(head);
                break;
            case 4:
                head = deleteRecord(head);
                break;
            case 5:
                printClassAverage(head);
                break;
            case 6:
                bestStudent(head);
                break;
            case 7:
                break;
            default:
                printf("Invalid selection, please try again...\n");
                break;
        }
    } while (choice != 7);
}

// Sorts the list based on average grades
student *sortList(student *head) {
    if (head != NULL) {
        for (student *first = head; first != NULL; first = first->next) {
            for (student *after = first->next; after != NULL; after = after->next) {
                if (after->finalGrade * 3 / 5 + after->midTermGrade * 2 / 5 > first->finalGrade * 3 / 5 + first->midTermGrade * 2 / 5) {
                    // Swap data instead of pointers
                    student temp = *first;
                    *first = *after;
                    *after = temp;
                }
            }
        }
    }
    return head;
}

// Displays the best student
void bestStudent(student *head) {
    if (head == NULL) {
        printf("No students in the list.\n");
        return;
    }
    student *best = head;
    head = head->next;
    while (head != NULL) {
        if (head->finalGrade * 3 / 5 + head->midTermGrade * 2 / 5 > best->finalGrade * 3 / 5 + best->midTermGrade * 2 / 5) {
            best = head;
        }
        head = head->next;
    }
    printf("Best student:\n");
    printf("Number: %d\n", best->number);
    printf("Name: %s\n", best->name);
    printf("Mid Term Grade: %.2f\n", best->midTermGrade);
    printf("Final Grade: %.2f\n", best->finalGrade);
}

// Calculates and displays the class average
void printClassAverage(student *head) {
    float average = 0;
    int count = 0;
    while (head != NULL) {
        count++;
        average += head->finalGrade * 3 / 5 + head->midTermGrade * 2 / 5;
        head = head->next;
    }
    if (count > 0) {
        printf("Class average: %.2f\n", average / count);
    } else {
        printf("No records available to calculate the average.\n");
    }
}

// Deletes a student record
student *deleteRecord(student *head) {
    if (head == NULL) {
        printf("List is empty.\n");
        return head;
    }

    int number;
    printf("Which student's record do you want to delete? (Enter number): ");
    scanf("%d", &number);

    student *before = head, *current = head->next;

    if (before->number == number) {
        head = current;
        free(before);
    } else {
        while (current != NULL && current->number != number) {
            before = before->next;
            current = current->next;
        }
        if (current != NULL) {
            before->next = current->next;
            free(current);
        } else {
            printf("Record not found.\n");
        }
    }
    return head;
}

// Updates student records
void updateRecord(student *head) {
    int number;
    printf("Which student's number do you want to update? ");
    scanf("%d", &number);
    while (head != NULL) {
        if (head->number == number) {
            int option;
            printf("Which field do you want to update?\n1-Number\n2-Name\n3-Mid Term Grade\n4-Final Grade\n");
            scanf("%d", &option);
            switch (option) {
                case 1:
                    printf("Enter new number: ");
                    scanf("%d", &head->number);
                    break;
                case 2:
                    printf("Enter new name: ");
                    getchar(); // To consume newline
                    fgets(head->name, sizeof(head->name), stdin);
                    strtok(head->name, "\n"); // Remove newline character
                    break;
                case 3:
                    printf("Enter new mid term grade: ");
                    scanf("%f", &head->midTermGrade);
                    break;
                case 4:
                    printf("Enter new final grade: ");
                    scanf("%f", &head->finalGrade);
                    break;
                default:
                    printf("Invalid selection.\n");
                    break;
            }
            return;
        }
        head = head->next;
    }
    printf("Student not found.\n");
}

// Lists records based on search criteria
void recordListing(student *head) {
    int choice = 0;
    while (choice != 1 && choice != 2 && choice != 3) {
        printf("1- Search by Number\n2- Search by Name\n3- List Students with Average Grade >= 60\n");
        scanf("%d", &choice);
        switch (choice) {
            case 1: {
                int number;
                printf("Enter the number to search: ");
                scanf("%d", &number);
                printf("Students with number %d:\n", number);
                while (head != NULL) {
                    if (head->number == number) {
                        printf("Number: %d\n", head->number);
                        printf("Name: %s\n", head->name);
                        printf("Mid Term Grade: %.2f\n", head->midTermGrade);
                        printf("Final Grade: %.2f\n", head->finalGrade);
                    }
                    head = head->next;
                }
                break;
            }
            case 2: {
                char name[40];
                printf("Enter the name to search: ");
                getchar(); // To consume newline
                fgets(name, sizeof(name), stdin);
                strtok(name, "\n"); // Remove newline character
                printf("Students with name %s:\n", name);
                while (head != NULL) {
                    if (strcmp(head->name, name) == 0) {
                        printf("Number: %d\n", head->number);
                        printf("Name: %s\n", head->name);
                        printf("Mid Term Grade: %.2f\n", head->midTermGrade);
                        printf("Final Grade: %.2f\n", head->finalGrade);
                    }
                    head = head->next;
                }
                break;
            }
            case 3:
                printf("Students with average grade >= 60:\n");
                while (head != NULL) {
                    float average = head->midTermGrade * 2 / 5 + head->finalGrade * 3 / 5;
                    if (average >= 60) {
                        printf("Number: %d\n", head->number);
                        printf("Name: %s\n", head->name);
                        printf("Mid Term Grade: %.2f\n", head->midTermGrade);
                        printf("Final Grade: %.2f\n", head->finalGrade);
                    }
                    head = head->next;
                }
                break;
            default:
                printf("Invalid selection, please try again.\n");
                break;
        }
    }
}

// Adds a new student record
student *addRecord(student *head) {
    student *newRecord = (student *)malloc(sizeof(student));
    if (newRecord == NULL) {
        printf("Memory allocation failed.\n");
        return head;
    }

    printf("Number: ");
    scanf("%d", &newRecord->number);
    printf("Name: ");
    getchar(); // To consume newline
    fgets(newRecord->name, sizeof(newRecord->name), stdin);
    strtok(newRecord->name, "\n"); // Remove newline character
    printf("Mid Term Grade: ");
    scanf("%f", &newRecord->midTermGrade);
    printf("Final Grade: ");
    scanf("%f", &newRecord->finalGrade);
    newRecord->next = NULL;

    if (head == NULL) {
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
