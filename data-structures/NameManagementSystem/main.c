//
//  main.c
//  tekBagliListeSlaytAlistirma1
//
//  Created by Mustafa Seyyit DOĞAN on 17.10.2024.
//

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct names {
    char name[40];
    struct names *next;
} node;

node *addnode(node *head);
node *sortTheList(node *head);
node *deleteNode(node *head);
node *longestWord(node *head);

int main(void) {
    int selection;
    node *head = NULL;
    do {
        printf("1 - Add/Create Node\n2 - Find the Longest Word\n3 - Delete Node\n4 - Exit\n");
        scanf("%d", &selection);
        switch (selection) {
            case 1: {
                head = addnode(head);
                head = sortTheList(head);
            } break;
            case 2: {
                printf("Longest word: %s", longestWord(head)->name);
            } break;
            case 3: {
                head = deleteNode(head);
            } break;
            case 4:
                printf("Exiting\n");
                break;
            default: {
                printf("Invalid selection, please choose again.\n");
            } break;
        }
    } while (selection != 4);
}

node *longestWord(node *head) {
    node *longest = head;
    if (head == NULL)
        printf("The list is empty\n");
    else if (head->next == NULL) {
    } else {
        node *p = head;
        while (p != NULL) {
            if (strlen(p->name) > strlen(longest->name))
                longest = p;
            p = p->next;
        }
    }
    return longest;
}

node *deleteNode(node *head) {
    if (head == NULL) {
        printf("The list is empty, deletion cannot be performed.\n");
    } else if (head->next == NULL) {
        node *p = head;
        free(p);
        head = NULL;
    } else {
        char deleted[40];
        printf("Enter the name you want to delete: ");
        getchar();
        gets(deleted);
        node *before = head;
        node *now = head->next;
        if (strcmp(before->name, deleted) == 0) {
            head = now;
            free(before);
        } else {
            int completed = 0;
            while (now != NULL && completed != 1) {
                if (strcmp(now->name, deleted) == 0) {
                    before->next = now->next;
                    node *temp = now;
                    now = now->next;
                    free(temp);
                    completed = 1;
                }
                before = now;
                now = now->next;
            }
        }
    }
    return head;
}

node *sortTheList(node *head) {
    if (head == NULL) {
        printf("The list is empty, sorting cannot be performed.\n");
    } else if (head->next == NULL) {
        printf("There is only one element in the list, sorting cannot be performed.\n");
    } else {
        node *now, *before;
        now = head->next;
        before = head;
        while (before->next != NULL) {
            while (now != NULL) {
                if (strcmp(before->name, now->name) < 0) {
                    char temp[40];
                    strcpy(temp, before->name);
                    strcpy(before->name, now->name);
                    strcpy(now->name, temp);
                }
                now = now->next;
            }
            before = before->next;
        }
    }
    return head;
}

node *addnode(node *head) {
    node *p;
    p = (node*) malloc(sizeof(node));
    if (p == NULL) {
        printf("Insufficient memory allocation\n");
    } else {
        printf("Name: ");
        getchar();
        gets(p->name);
        p->next = NULL;
        
        if (head == NULL)
            head = p;
        else {
            node *q = head;
            while (q->next != NULL)
                q = q->next;
            q->next = p;
        }
    }
    
    return head;
}

