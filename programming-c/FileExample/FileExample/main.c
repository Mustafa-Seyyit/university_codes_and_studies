#include <stdio.h>
#include <stdlib.h>

typedef struct students{
    int number;
    char name[40];
    float grade;
} students;

void update(void){
    FILE *f = fopen("students.dat", "r+");
    if (f == NULL) {
        return;
    }
    students s = {0, " ", 0.0};
    fseek(f, 0*sizeof(students), SEEK_SET);
    while ((fread(&s, sizeof(students), 1, f)) == 1) {
        if (s.grade >79) {
            s.grade +=10;
            if (s.grade > 100) {
                s.grade = 100;
            }
        else
            s.grade +=5;
        fseek(f, (s.number-1)*sizeof(students), SEEK_SET);
            fwrite(&s, sizeof(students), 1, f);
        }
    }
    fclose(f);
}
