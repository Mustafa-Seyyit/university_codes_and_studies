//
//  main.c
//  agacekle
//
//  Created by Mustafa Seyyit DOĞAN on 7.11.2024.
//

#include <stdio.h>
#include <stdlib.h>

typedef struct node{
    int data;
    struct node *right;
    struct node *left;
}*BTREE;


BTREE add_node(BTREE root, int x);

void main(void) {
    int sayi;
    BTREE root = NULL;
    printf("agaci doldurunuz.(cikmak icin -1)");
    scanf("%d",&sayi);
    while (sayi != -1) {
        add_node(root, sayi);
        printf("agaci doldurunuz.");
        scanf("%d",&sayi);
    }
    
}

BTREE add_node(BTREE root, int x){
    
    BTREE new = (BTREE) malloc(sizeof(struct node));
    new->data = x;
    if (root == NULL){
        new->left = NULL;
        new->right= NULL;
        root = new;
    }
    if (root->data < root) {
        root->right = add_node(root->right, x);
    }else{
        root->left = add_node(root->left, x);
    }
    return root;
}

