//
//  main.c
//  tek_bagli_liste_calisma
//
//  Created by Mustafa Seyyit DOĞAN on 1.10.2024.
//

#include <stdio.h>
#include <stdlib.h>

// Struct for linked list node
struct node {
    int data;
    struct node *next;
};

// Function declarations
struct node *delete(struct node *head, int x);
void print_reverse(struct node *head);
int count_nodes(struct node *head);
int count_nodes_recursive(struct node *head);
void print_list(struct node *head);
struct node *add_last(struct node *head, int x);
struct node *add_front(struct node *head, int x);

// Main function
int main(void) {
    printf("1 - Add element to front\n");
    printf("2 - Add element to end\n");
    printf("3 - Display list\n");
    printf("4 - Count nodes recursively\n");
    printf("5 - Count nodes\n");
    printf("6 - Print list in reverse\n");
    printf("7 - Delete specified node from list\n");

    int process;
    struct node *head = NULL;
    printf("Select the operation you want to perform: ");
    while (1) {
        scanf("%d", &process);
        if (process < 1 || process > 7) {
            break;
        }
        switch (process) {
            case 1: {
                int number;
                printf("Element to add: ");
                scanf("%d", &number);
                head = add_front(head, number);
                break;
            }
            case 2: {
                int number;
                printf("Element to add: ");
                scanf("%d", &number);
                head = add_last(head, number);
                break;
            }
            case 3:
                print_list(head);
                break;
            case 4:
                printf("%d", count_nodes_recursive(head));
                break;
            case 5:
                printf("%d", count_nodes(head));
                break;
            case 6:
                print_reverse(head);
                break;
            case 7: {
                int del;
                printf("Node to delete: ");
                scanf("%d", &del);
                head = delete(head, del);
                break;
            }
            default:
                break;
        }
    }
    return 0;
}

// Delete a node with value x from the list
struct node *delete(struct node *head, int x) {
    if (head != NULL) {
        struct node *temp = head;
        if (head->data == x) {
            head = head->next;
            free(temp);
        } else {
            while (temp->next != NULL && temp->next->data != x)
                temp = temp->next;
            if (temp->next == NULL) {
                printf("Element not found in the list\n");
                return head;
            } else {
                struct node *deleted = temp->next;
                temp->next = deleted->next;
                free(deleted);
            }
        }
    }
    return head;
}

// Print the list in reverse order
void print_reverse(struct node *head) {
    if (head == NULL) {
        return;
    } else {
        print_reverse(head->next);
        printf("\n%d", head->data);
    }
}

// Count nodes in the list iteratively
int count_nodes(struct node *head) {
    int counter = 0;
    while (head != NULL) {
        counter++;
        head = head->next;
    }
    return counter;
}

// Count nodes in the list recursively
int count_nodes_recursive(struct node *head) {
    if (head == NULL)
        return 0;
    else
        return 1 + count_nodes_recursive(head->next);
}

// Print the list
void print_list(struct node *head) {
    if (head == NULL)
        printf("The list is empty\n");
    else {
        while (head != NULL) {
            printf("\n%d", head->data);
            head = head->next;
        }
    }
}

// Add a node at the end of the list
struct node *add_last(struct node *head, int x) {
    struct node *temp = (struct node*) malloc(sizeof(struct node));
    temp->data = x;
    temp->next = NULL;
    if (head == NULL)
        head = temp;
    else {
        struct node *last = head;
        while (last->next != NULL)
            last = last->next;
        last->next = temp;
    }
    return head;
}

// Add a node at the front of the list
struct node *add_front(struct node *head, int x) {
    struct node *temp = (struct node*) malloc(sizeof(struct node));
    temp->data = x;
    temp->next = head;
    head = temp;
    return head;
}

