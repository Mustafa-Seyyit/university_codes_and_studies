//
//  main.c
//  DosyaLabSorusu
//
//  Created by Mustafa Seyyit DOĞAN on 22.10.2024.
//

#include <stdio.h>

// This program manages student grades, allowing for file creation, data entry, and grade reporting.

FILE *createFileOrEnterData(FILE *mfPtr);
void readFromFile(FILE *mfPtr);
void printTopStudent(FILE *mfPtr);
void saveToPassingFailing(FILE *mfPtr);
void printSizeOfFile(FILE *mfPtr);

int main(void) {
    int choice;
    FILE *mfPtr = NULL;

    do {
        printf("1 - Create file / Enter data\n");
        printf("2 - Read from file and list\n");
        printf("3 - List students with average grades above 60\n");
        printf("4 - Save students with grades 60 and above to 'passing.txt', others to 'failing.txt'\n");
        printf("5 - Print the size of the file\n");
        printf("6 - Exit\n");
        scanf("%d", &choice);

        switch (choice) {
            case 1:
                mfPtr = createFileOrEnterData(mfPtr);
                break;
            case 2:
                readFromFile(mfPtr);
                break;
            case 3:
                printTopStudent(mfPtr);
                break;
            case 4:
                saveToPassingFailing(mfPtr);
                break;
            case 5:
                printSizeOfFile(mfPtr);
                break;
            case 6:
                printf("Exiting...\n");
                break;
            default:
                printf("Invalid choice, please try again.\n");
        }
    } while (choice != 6);

    return 0;
}

void printSizeOfFile(FILE *mfPtr) {
    if (mfPtr == NULL) {
        printf("File has not been created.\n");
    } else {
        fseek(mfPtr, 0, SEEK_END);  // Move to the end of the file
        long size = ftell(mfPtr);   // Get the current position (file size)
        if (size == -1L) {
            printf("Could not retrieve file size.\n");
        } else {
            printf("File size: %ld bytes\n", size);
        }
        rewind(mfPtr);  // Reset file pointer to the beginning
    }
}

void saveToPassingFailing(FILE *mfPtr) {
    if (mfPtr == NULL) {
        printf("File does not exist or is empty.\n");
    } else {
        if ((mfPtr = fopen("notlar.txt", "r")) == NULL) {
            printf("Could not open file.\n");
        } else {
            int number;
            char name[40];
            float midTermGrade, finalGrade;
            FILE *passingPtr = fopen("passing.txt", "w");
            FILE *failingPtr = fopen("failing.txt", "w");

            if (passingPtr == NULL || failingPtr == NULL) {
                printf("Could not open output files.\n");
            } else {
                while (fscanf(mfPtr, "%d%s%f%f", &number, name, &midTermGrade, &finalGrade) == 4) {
                    if (midTermGrade * 2 / 5 + finalGrade * 3 / 5 >= 60) {
                        fprintf(passingPtr, "%d\t%s\t%8.2f\t%8.2f\n", number, name, midTermGrade, finalGrade);
                    } else {
                        fprintf(failingPtr, "%d\t%s\t%8.2f\t%8.2f\n", number, name, midTermGrade, finalGrade);
                    }
                }
            }
            fclose(passingPtr);
            fclose(failingPtr);
            fclose(mfPtr);
        }
    }
}

void printTopStudent(FILE *mfPtr) {
    if (mfPtr == NULL) {
        printf("File has not been created or is empty.\n");
    } else {
        if ((mfPtr = fopen("notlar.txt", "r")) == NULL) {
            printf("Could not open file.\n");
        } else {
            int number;
            char name[40];
            float midTermGrade, finalGrade;
            printf("Students with average grades above 60:\n");
            while (fscanf(mfPtr, "%d%s%f%f", &number, name, &midTermGrade, &finalGrade) == 4) {
                if (midTermGrade * 2 / 5 + finalGrade * 3 / 5 >= 60) {
                    printf("%-10d%-13s%8.2f%8.2f\n", number, name, midTermGrade, finalGrade);
                }
            }
            fclose(mfPtr);
        }
    }
}

void readFromFile(FILE *mfPtr) {
    if (mfPtr == NULL) {
        printf("File has not been created.\n");
    } else {
        if ((mfPtr = fopen("notlar.txt", "r")) == NULL) {
            printf("Could not open file.\n");
        } else {
            int number;
            char name[40];
            float midTermGrade;
            float finalGrade;
            printf("Number\t\tName\t\tMidterm Grade\tFinal Grade\n");
            fscanf(mfPtr, "%d%s%f%f", &number, name, &midTermGrade, &finalGrade);
            while (!feof(mfPtr)) {
                printf("%-10d%-10s%8.2f%8.2f\n", number, name, midTermGrade, finalGrade);
                fscanf(mfPtr, "%d%s%f%f", &number, name, &midTermGrade, &finalGrade);
            }
            fclose(mfPtr);
        }
    }
}

FILE *createFileOrEnterData(FILE *mfPtr) {
    int number;
    char name[40];
    float midTermGrade;
    float finalGrade;

    if (mfPtr == NULL) {
        printf("Creating file...\n");
        if ((mfPtr = fopen("notlar.txt", "w")) == NULL) {
            printf("Could not open file.\n");
        } else {
            printf("Enter number, name, midterm grade, and final grade.\n");
            printf("To finish, enter END OF FILE (Ctrl+D or Ctrl+Z)\n");
            while (scanf("%d%s%f%f", &number, name, &midTermGrade, &finalGrade) != EOF) {
                fprintf(mfPtr, "%d\t%s\t%8.2f\t%8.2f\n", number, name, midTermGrade, finalGrade);
                printf("?");
            }
            fclose(mfPtr);
        }
    } else {
        if ((mfPtr = fopen("notlar.txt", "a")) == NULL) {
            printf("Could not open file.\n");
        } else {
            printf("Enter number, name, midterm grade, and final grade.\n");
            printf("To finish, enter END OF FILE (Ctrl+D or Ctrl+Z)\n");
            while (scanf("%d%s%f%f", &number, name, &midTermGrade, &finalGrade) != EOF) {
                fprintf(mfPtr, "%d\t%s\t%8.2f\t%8.2f\n", number, name, midTermGrade, finalGrade);
                printf("?");
            }
            fclose(mfPtr);
        }
    }
    return mfPtr;
}
