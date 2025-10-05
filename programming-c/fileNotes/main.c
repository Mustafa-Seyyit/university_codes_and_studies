//
//  main.c
//  dosyaSlayt1Notlari
//
//  Created by Mustafa Seyyit DOĞAN on 22.10.2024.
//

#include <stdio.h>

// Writing to a file with accessible sorting

int main(void) {
    int accountNo;
    char name[30];
    double balance;
    FILE *mfPtr;  // Pointer to the customer.dat file
    if ((mfPtr = fopen("customer.dat", "w")) == NULL) {
        printf("File could not be opened\n");
    } else {
        printf("Enter account number, name, and balance\n");
        printf("To end data entry, enter EOF (Ctrl + Z)\n");
        printf("?");
        scanf("%d %s %lf", &accountNo, name, &balance);
        
        while (!feof(stdin)) {
            fprintf(mfPtr, "%d %s %.2f\n", accountNo, name, balance);
            printf("?");
            scanf("%d %s %lf", &accountNo, name, &balance);
        }
        fclose(mfPtr);
    }
    return 0;
}

// Reading from a file with accessible sorting
/*
int main(void) {
    int accountNo;
    char name[40];
    double balance;
    FILE *mfPtr; // Pointer to customer.dat file
    if ((mfPtr = fopen("customer.dat", "r")) == NULL)
        printf("File could not be opened\n");
    else {
        printf("%-10s%-13s%s\n", "AccountNo", "Name", "Balance");
        fscanf(mfPtr, "%d %s %lf", &accountNo, name, &balance);
        
        while (!feof(mfPtr)) {
            printf("%-10d%-13s%7.2f\n", accountNo, name, balance);
            fscanf(mfPtr, "%d %s %lf", &accountNo, name, &balance);
        }
        fclose(mfPtr);
    }
    return 0;
}

// Displaying accounts based on balance conditions
/*
int main(void) {
    int choice, accountNo;
    double balance;
    char name[40];
    FILE *mfPtr;
    if ((mfPtr = fopen("customer.dat", "r")) == NULL)
        printf("File could not be opened\n");
    else {
        printf("Please choose an option\n1- Accounts with zero balance\n2- Accounts with debt\n3- Accounts with positive balance\n4- Exit\n");
        scanf("%d", &choice);
        while (choice != 4) {
            fscanf(mfPtr, "%d %s %lf", &accountNo, name, &balance);
            switch (choice) {
                case 1:
                    printf("\nAccounts with zero balance:\n");
                    while (!feof(mfPtr)) {
                        if (balance == 0)
                            printf("%-10d%-13s%7.2f\n", accountNo, name, balance);
                        fscanf(mfPtr, "%d %s %lf", &accountNo, name, &balance);
                    }
                    break;
                case 2:
                    printf("\nAccounts with debt:\n");
                    while (!feof(mfPtr)) {
                        if (balance < 0)
                            printf("%-10d%-13s%7.2f\n", accountNo, name, balance);
                        fscanf(mfPtr, "%d %s %lf", &accountNo, name, &balance);
                    }
                    break;
                case 3:
                    printf("\nAccounts with positive balance:\n");
                    while (!feof(mfPtr)) {
                        if (balance > 0)
                            printf("%-10d%-13s%7.2f\n", accountNo, name, balance);
                        fscanf(mfPtr, "%d %s %lf", &accountNo, name, &balance);
                    }
                    break;
            }
            rewind(mfPtr);
            printf("\n?");
            scanf("%d", &choice);
        }
        printf("Program terminated\n");
        fclose(mfPtr);
    }
}
*/



