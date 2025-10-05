//
//  main.c
//  belirlenen hipotenüs sınır değişkeni altındaki kenarlar tam sayı olan dik üçgen
//
//  Created by Mustafa Seyyit DOĞAN on 20.02.2024.
/*This project calculates the sides of right triangles with integer sides for values below the specified hypotenuse limit.
 */

#include <stdio.h>

int main(void) {
    int hipo, a, b, hipo1;
    // User enters hypotenuse length
    printf("hipotenüs sınırını giriniz.\n");
    scanf("%d",&hipo);
    
    //Calculating other sides of the triangle
    for (hipo1=1; hipo1<hipo; hipo1++) {
        for (a=1; a<hipo1; a++){
            for (b=hipo1; b>a; b--) {
                if (a*a+b*b==hipo1*hipo1) {
                    //Writing the values found on the screen
                    printf("%d-%d-%d \n",a ,b, hipo1);
                }
            }
        }
    }
    return 0;
}
