//
//  main.c
//  singlyLinkedList
//
//  Created by Mustafa Seyyit DOĞAN on 27.10.2024.
//

#include <stdio.h>
#include <stdlib.h>

typedef struct node{
    int data;
    struct node *next;
}node;

node *addFront(node *head, int x);
node *addLast(node *head, int x);
void printList(node *head);
int nodeCount(node *head);
int nodeCountRecursive(node *head);
void printreverseList(node *head);
node *deleteNode(node *head, int x);



node *deleteNode(node *head, int x){
    if (head != NULL){
        node *temp = head;
        if(head->data == x){
            head = head->next;
            free(temp);
        }else{
            while (temp->next->data != x && temp->next != NULL)
                temp = temp->next;
            if (temp->next != NULL){
                node *delete = temp->next;
                temp->next = delete->next;
                free(delete);
            }else{
                printf("listede bu eleman bulunmamaktadır.\n");
            }
        }
    }
    return head;
}

void printreverseList(node *head){
    if (head == NULL)
        return;
    printreverseList(head->next);
    printf("%d -> ",head->data);
}

int nodeCountRecursive(node *head){
    if (head == NULL)
        return 0;
    return 1 + nodeCountRecursive(head->next);
}

int nodeCount(node *head){
    int count = 0;
    while (head != NULL){
        count++;
        head = head->next;
    }
    return count;
}

void printList(node *head){
    if (head == NULL)
        printf("liste bos.\n");
    else{
        while (head != NULL){
            printf("%d -> ",head->data);
            head = head->next;
        }
    }
}

node *addLast(node *head, int x){
    node *temp = (node*) malloc(sizeof(node));
    temp->data = x;
    temp->next = NULL;
    if (head == NULL)
        head = temp;
    else{
        node *last = head;
        while (last->next != NULL)
            last = last->next;
        last->next = temp;
    }
    return head;
}

node *addFront(node *head, int x){
    node * temp = (node*) malloc(sizeof(node));
    temp->data = x;
    temp->next = head;
    head = temp;
    return head;
}

