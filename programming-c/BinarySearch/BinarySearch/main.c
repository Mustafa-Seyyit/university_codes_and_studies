//
//  main.c
//  BinarySearch
//
//  Created by Mustafa Seyyit DOĞAN on 9.04.2025.
//

#include <stdio.h>
#include <stdlib.h>

typedef struct node {
    int data;
    struct node *left;
    struct node *right;
    struct node *parent;
}node;

node *binarySearch;
node *addNode(int data);
void insert(node *root, node *add);

struct node *AddbinarySearch(struct node *root, int data){
    if (root == NULL) {
        root = addNode(data);
    }else{
        node *temp = addNode(data);
        insert(root,temp);
    }
}


struct node *addNode(int data){
    node *temp = (node*) malloc(sizeof(node));
    if (temp == NULL) {
        return NULL;
    }
    temp->data = data;
    return temp;
}

void insert(node *root, node *add){
    node *temp;
    while (root != NULL){
        temp = root;
        if (add->data < root ->data)
            root = root->left;
        else
            root = root ->right;
    }
    add->parent = temp;
    if (y == NULL) {
        
    }
}
