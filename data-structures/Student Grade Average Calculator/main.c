//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 30.04.2024.
//

#include <stdio.h>
#include <stdlib.h>

// This program collects information about five students and calculates the average of their final grades.
struct student {
    int number;
    char name[50];
    char surname[50];
    float midtermGrade;
    float finalGrade;
};

int main() {
    struct student *students[5];

    for (int i = 0; i < 5; i++) {
        students[i] = (struct student *)malloc(sizeof(struct student));
        if (students[i] == NULL) {
            printf("Memory allocation failed\n");
            return 1;
        }
        
        printf("bilgileri girin ogrenci %d:\n", i + 1);
        printf("Numara: ");
        scanf("%d", &students[i]->number);
        printf("isim: ");
        scanf("%s", students[i]->name);
        printf("soyad: ");
        scanf("%s", students[i]->surname);
        printf("vize notu: ");
        scanf("%f", &students[i]->midtermGrade);
        printf("final notu: ");
        scanf("%f", &students[i]->finalGrade);
        printf("\n");
    }

    float totalFinalGrade = 0.0;
    for (int i = 0; i < 5; i++) {
        totalFinalGrade += students[i]->finalGrade;
    }
    float averageFinalGrade = totalFinalGrade / 5;

    printf("ortalama: %.2f\n", averageFinalGrade);

    for (int i = 0; i < 5; i++) {
        free(students[i]);
    }

    return 0;
}

