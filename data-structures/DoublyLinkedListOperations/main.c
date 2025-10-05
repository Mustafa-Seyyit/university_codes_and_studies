//
//  main.c
//  cift_baglı_liste_calismalari
//
//  Created by Mustafa Seyyit DOĞAN on 1.10.2024.
//

#include <stdio.h>
#include <stdlib.h>

// Definition of a doubly linked list node
struct node {
    int data;
    struct node *next;
    struct node *prev;
};

struct node *addFront(struct node *head, int x);
struct node *addLast(struct node *head, int x);
void printReverse(struct node *head);
struct node *deleteNode(struct node *head, int x);
void printList(struct node *head);

int main(void) {
    struct node *head = NULL;
    printf("1 - Add element to front of the list\n");
    printf("2 - Add element to end of the list\n");
    printf("3 - Print the list in reverse\n");
    printf("4 - Print the list\n");
    printf("5 - Delete a specified element from the list\n");

    int selection;
    printf("\nSelect the operation you want to perform: ");
    scanf("%d", &selection);

    while (selection > 0 && selection < 6) {
        switch (selection) {
            case 1: {
                int number;
                printf("Enter the element to add: ");
                scanf("%d", &number);
                head = addFront(head, number);
            } break;
            case 2: {
                int number;
                printf("Enter the element to add: ");
                scanf("%d", &number);
                head = addLast(head, number);
            } break;
            case 3:
                printReverse(head);
                break;
            case 4:
                printList(head);
                break;
            case 5: {
                int number;
                printf("Enter the element to delete: ");
                scanf("%d", &number);
                head = deleteNode(head, number);
            } break;
            default:
                break;
        }
        printf("\nSelect the operation you want to perform: ");
        scanf("%d", &selection);
    }

    return 0;
}

void printList(struct node *head) {
    if (head == NULL) {
        printf("The list is empty.\n");
        return;
    }
    while (head != NULL) {
        printf("\n%d", head->data);
        head = head->next;
    }
}

struct node *deleteNode(struct node *head, int x) {
    struct node *temp = head;
    
    if (head != NULL) {
        if (head->data == x) {
            head = head->next;
            if (head != NULL) {
                head->prev = NULL;
            }
            free(temp);
        } else {
            while (temp != NULL && temp->data != x)
                temp = temp->next;
            if (temp == NULL) {
                printf("Element not found in the list.\n");
            } else {
                if (temp->prev != NULL) {
                    temp->prev->next = temp->next;
                }
                if (temp->next != NULL) {
                    temp->next->prev = temp->prev;
                }
                free(temp);
            }
        }
    }
    return head;
}

void printReverse(struct node *head) {
    struct node *temp = head;
    while (temp != NULL && temp->next != NULL) {
        temp = temp->next;
    }
    while (temp != NULL) {
        printf("\n%d", temp->data);
        temp = temp->prev;
    }
}

struct node *addLast(struct node *head, int x) {
    struct node *temp = (struct node*) malloc(sizeof(struct node));
    temp->data = x;
    temp->next = NULL;

    if (head == NULL) {
        head = temp;
        temp->prev = NULL;
    } else {
        struct node *last = head;
        while (last->next != NULL)
            last = last->next;
        last->next = temp;
        temp->prev = last;
    }
    return head;
}

struct node *addFront(struct node *head, int x) {
    struct node *temp = (struct node*) malloc(sizeof(struct node));
    temp->data = x;
    temp->prev = NULL;

    if (head == NULL) {
        head = temp;
        temp->next = head;
        head->prev = temp;
        head = temp;
    }
    return head;
}

