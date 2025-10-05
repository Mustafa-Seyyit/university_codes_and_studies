/*
 project subject in turkish language: kullanıcı tarafından yarıçapı girilen bir
 kürenin hacmini hesaplamak.
 
 project subject in english language:radius entered by the user
 Calculate the volume of the sphere.
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

