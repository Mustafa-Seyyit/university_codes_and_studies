/*
 project subject in turkish language: kullanıcı tarafından yarıçapı girilen bir
 kürenin hacmini hesaplar.
 
 project subject in english language:calculates the volume of a sphere with the radius entered by the user.
 */
 


#include <stdio.h>
#define PI 3.14

int main() {
    int radius;
    float volume;
    
    printf("Enter the radius of the sphere: ");
    scanf("%d", &radius);
    
    volume = (4 / 3.0) * PI * (radius * radius * radius);
    printf("The volume of the sphere is %.2f.\n", volume);
    
    return 0;
}

