//
//  main.c
//  labsondanbastansilme
//
//  Created by Mustafa Seyyit DOĞAN on 3.10.2024.
//

// This program manages a linked list with functions to add nodes, delete nodes from
// the beginning or the end, delete a specified node, and display the list.

#include <stdio.h>
#include <stdlib.h>

struct node {
    int data;
    struct node *next;
};

struct node *deleteBeginning(struct node *head);
struct node *deleteLast(struct node *head);
struct node *deleteNode(struct node *head);
struct node *addToList(struct node *head);
void printList(struct node *head);

int main(void) {
    int choice;
    struct node *head = NULL; // Initialize head to NULL

    printf("1 - Delete from beginning\n");
    printf("2 - Delete from end\n");
    printf("3 - Delete specified node\n");
    printf("4 - Add to list\n");
    printf("5 - Display list\n");

    do {
        printf("\nEnter your choice: ");
        scanf("%d", &choice);
        printf("\n");
        switch (choice) {
            case 1:
                head = deleteBeginning(head);
                break;
            case 2:
                head = deleteLast(head);
                break;
            case 3:
                head = deleteNode(head);
                break;
            case 4:
                head = addToList(head);
                break;
            case 5:
                printList(head);
                break;
            default:
                break;
        }
    } while (choice < 6 && choice > 0);

    return 0;
}

void printList(struct node *head) {
    if (head == NULL) {
        printf("The list is empty.\n");
        return;
    }
    while (head != NULL) {
        printf("%d\n", head->data);
        head = head->next;
    }
}

struct node *addToList(struct node *head) {
    struct node *temp = (struct node*) malloc(sizeof(struct node));
    printf("Enter data: ");
    scanf("%d", &temp->data);
    temp->next = head;
    head = temp;
    return head;
}

struct node *deleteNode(struct node *head) {
    struct node *temp = head;
    if (head == NULL) {
        printf("The list is empty.\n");
        return head;
    }
    printf("Enter the element to delete: ");
    int value;
    scanf("%d", &value);

    if (head->data == value) {
        head = head->next;
        free(temp);
    } else {
        while (temp->next != NULL && temp->next->data != value) {
            temp = temp->next;
        }
        if (temp->next == NULL) {
            printf("The searched element is not in the list.\n");
        } else {
            struct node *nodeToDelete = temp->next;
            temp->next = nodeToDelete->next;
            free(nodeToDelete);
        }
    }
    return head;
}

struct node *deleteBeginning(struct node *head) {
    struct node *temp = head;
    if (head == NULL) {
        printf("The list is empty.\n");
        return head;
    }
    head = head->next;
    free(temp);
    return head;
}

struct node *deleteLast(struct node *head) {
    if (head == NULL) {
        printf("The list is empty.\n");
        return head;
    }
    
    struct node *temp = head;
    struct node *prev = NULL;

    while (temp->next != NULL) {
        prev = temp;
        temp = temp->next;
    }
    
    if (prev == NULL) { // List only has one node
        free(temp);
        return NULL;
    } else {
        free(temp);
        prev->next = NULL;
    }
    
    return head;
}

