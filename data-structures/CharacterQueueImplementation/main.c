//
//  main.c
//  stackQueuePalindromLab
//
//  Created by Mustafa Seyyit DOĞAN on 18.10.2024.
//
#define QUEUE_SIZE 20 // This is where the error might be; usage

#include <stdio.h>
#include <stdlib.h>

// Node definition
typedef struct node {
    char character;
    struct node *next;
    struct node *prev;
} node;

// Queue definition
typedef struct {
    struct node *front;
    struct node *rear;
    int count;
} queue;

void initialize_q(queue *q); // Initialization
int isFull(queue *q); // Full check
int isEmpty(queue *q); // Empty check
void enqueue(queue *q, char x); // Adding an element to the queue
char dequeue(queue *q); // Removing an element from the queue

int main(void) {
    queue q;
    initialize_q(&q);
    
    // Example usage
    enqueue(&q, 'A');
    enqueue(&q, 'B');
    enqueue(&q, 'C');
    printf("Dequeued: %c\n", dequeue(&q)); // Dequeues 'A'
    printf("Dequeued: %c\n", dequeue(&q)); // Dequeues 'B'
    return 0;
}

char dequeue(queue *q) {
    if (isEmpty(q)) {
        printf("Queue is empty\n");
        return -1;
    } else {
        char x = q->front->character;
        node *temp = q->front;
        q->front = q->front->next;
        free(temp);
        q->count--;
        if (isEmpty(q))
            q->rear = NULL;
        return x;
    }
}

void initialize_q(queue *q) {
    q->count = 0;
    q->front = q->rear = NULL;
}

int isFull(queue *q) {
    return q->count == QUEUE_SIZE;
}

int isEmpty(queue *q) {
    return q->count == 0;
}

void enqueue(queue *q, char x) {
    if (isFull(q))
        printf("Queue is full\n");
    else {
        node *temp = (node*) malloc(sizeof(node));
        temp->character = x;
        temp->next = NULL;
        temp->prev = NULL;
        if (isEmpty(q)) {
            q->front = q->rear = temp;
        } else {
            q->rear->next = temp;
            temp->prev = q->rear;
            q->rear = temp;
        }
        q->count++;
    }
}
