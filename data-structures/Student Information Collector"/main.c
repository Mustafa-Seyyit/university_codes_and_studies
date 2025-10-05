//
//  main.c
//
//  Created by Mustafa Seyyit DOĞAN on 30.04.2024.
//

#include <stdio.h>

/*
 * This program collects and displays information about a person,
 * including their ID number, name, surname, midterm grade, and final grade.
 */

int main() {
    struct {
        long long int number;
        char name[40];
        char surname[20];
        int midtermgrade;
        int finalgrade;
    } person;

    printf("Enter your ID number:\n");
    scanf("%lld", &person.number);

    printf("Enter your name:\n");
    scanf("%39s", person.name);

    printf("Enter your surname:\n");
    scanf("%19s", person.surname);

    printf("Enter your midterm grade:\n");
    scanf("%d", &person.midtermgrade);

    printf("Enter your final grade:\n");
    scanf("%d", &person.finalgrade);

    printf("Press any key to continue...\n");
    getchar();

    printf("ID Number: %lld\nName: %s\nSurname: %s\nMidterm Grade: %d\nFinal Grade: %d\n",
           person.number, person.name, person.surname, person.midtermgrade, person.finalgrade);

    return 0;
}
