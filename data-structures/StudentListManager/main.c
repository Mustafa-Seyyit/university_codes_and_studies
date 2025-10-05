//
//  main.c
//  listeBasınaSonunaElemanEkleme
//
//  Created by Mustafa Seyyit DOĞAN on 26.09.2024.
//

// This program manages a linked list of students, allowing the user to create a new list,
// add elements to the beginning or end of the list, and count the total number of elements.

#include <stdio.h>
#include <stdlib.h>

struct student {
    int data;
    struct student *next;
};
typedef struct student student;

student *addHead(student *head);
student *addLast(student *head);
int count(student *head);

// Function to add a new element at the beginning of the list
student *addHead(student *head) {
    student *newElement = (student*) malloc(sizeof(student));
    
    printf("Enter new element data: ");
    scanf("%d", &newElement->data);
    
    newElement->next = head;
    return newElement;
}

student *addLast(student *head) {
    student *newElement = (student*) malloc(sizeof(student));
    newElement->next = NULL;
    
    printf("Enter new element data: ");
    scanf("%d", &newElement->data);
    
    if (head == NULL) {
        head = newElement;
        return head;
    }
    
    student *temp = head;
    while (temp->next != NULL) {
        temp = temp->next;
    }
    temp->next = newElement;
    return head;
}

int count(student *head) {
    int counter = 0;
    while (head != NULL) {
        counter++;
        head = head->next;
    }
    return counter;
}

int main(void) {
    int operation;
    student *head = NULL;
    
    printf("1 - Create a new list\n");
    printf("2 - Add an element to the beginning of the list\n");
    printf("3 - Add an element to the end of the list\n");
    printf("0 - Exit\n");
    
    do {
        printf("\nSelect the operation you want to perform: ");
        scanf("%d", &operation);
        
        if (operation == 1) {
            head = (student*) malloc(sizeof(student));
            head->next = NULL;
            printf("Enter data: ");
            scanf("%d", &head->data);
        } else if (operation == 2) {
            head = addHead(head);
        } else if (operation == 3) {
            head = addLast(head);
        }
        
    } while (operation != 0);
    
    printf("\nTotal number of elements entered: %d", count(head));
    printf("\nElements:");
    
    while (head != NULL) {
        printf("\n%d", head->data);
        student *temp = head;
        head = head->next;
        free(temp);          
    }
    
    printf("\n");
    return 0;
}

