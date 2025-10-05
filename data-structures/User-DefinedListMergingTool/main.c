//
//  main.c
//  lab2listeyiBirlestir
//
//  Created by Mustafa Seyyit DOĞAN on 24.10.2024.
//

#include <stdio.h>
#include <stdlib.h>

// This program creates two linked lists from user input and merges them into a single sorted linked list.

typedef struct node {
    int data;
    struct node *next;
} node;

node *connectList(node *head1, node *head2);
node *addLast(node *head, int data);
void printList(node *head);

int main(void) {
    node *list1 = NULL;
    node *list2 = NULL;
    int number;

    // Creating the first linked list
    do {
        printf("Enter a number for list1 (-1 to exit): ");
        scanf("%d", &number);
        if (number == -1) {
            break;
        }
        list1 = addLast(list1, number);
    } while (number != -1);

    // Creating the second linked list
    do {
        printf("Enter a number for list2 (-1 to exit): ");
        scanf("%d", &number);
        if (number == -1) {
            break;
        }
        list2 = addLast(list2, number);
    } while (number != -1);

    // Merging the two lists
    node *mergedList = connectList(list1, list2);

    // Printing the lists
    printf("List 1: ");
    printList(list1);
    printf("List 2: ");
    printList(list2);
    printf("Merged list: ");
    printList(mergedList);

    return 0;
}

void printList(node *head) {
    while (head != NULL) {
        printf("%d -> ", head->data);
        head = head->next;
    }
    printf("NULL\n");
}

node *addLast(node *head, int data) {
    node *temp = (node *)malloc(sizeof(node));
    temp->data = data;
    temp->next = NULL;
    
    if (head == NULL) {
        head = temp;
    } else {
        node *p = head;
        while (p->next != NULL)
            p = p->next;
        p->next = temp;
    }
    return head;
}

node *connectList(node *head1, node *head2) {
    node *head = NULL;
    
    while (head1 != NULL && head2 != NULL) {
        if (head1->data > head2->data) {
            head = addLast(head, head1->data);
            head1 = head1->next;
        } else {
            head = addLast(head, head2->data);
            head2 = head2->next;
        }
    }

    while (head1 != NULL) {
        head = addLast(head, head1->data);
        head1 = head1->next;
    }

    while (head2 != NULL) {
        head = addLast(head, head2->data);
        head2 = head2->next;
    }

    return head;
}

