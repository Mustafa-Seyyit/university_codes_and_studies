import java.awt.*;
import java.util.Scanner;

public class Main {
    public static void main(String[] adsas) {
        //System.out.printf("%f ve %s %n",  5.2f, "hello");
        //ifCond();
        //switchCase();
        //forLoop();
        //forEachLoop();
        //int[] numbers = {45, 56, 19, 78, 75};
       // whileLoop(numbers);
        //doWhile();
       // showScoreAndName(50,90,"jerry");

        Scanner scanner = new Scanner(System.in);

        Student student1 = new Student();
        System.out.println("please enter your name");
        student1.name =scanner.next();

        System.out.println("please enter your midterm score");
        student1.mid = scanner.nextInt();

        System.out.println("please enter your final score");
        student1.fin = scanner.nextInt();
        student1.showScoreAndName();

        //student1.mid = 85;
        //student1.showScoreAndName();


        Student student2 = new Student();
        student2.name ="tom";
        student2.mid = 78;
        student2.fin = 74;
        student2.showScoreAndName();
    }


//    static void showScoreAndName(float mid, float fin, String name){
//        float score =  mid*0.4f + fin *0.6f;
//        System.out.printf("name: %s  score: %f ", name, score);
//    }

    static void ifCond(){
        int score = 60;

        if (score < 35)
        {
            System.out.println("tekrar ediniz");
            System.out.println("başarısız");
        }
        else if(score< 60)
            System.out.println("CC");
        else{
            System.out.println("BB");
        }
    }

    static void switchCase(){
        int season=1;

        switch (season){
            case 1:
                System.out.println("WINTER");
                break;
            case 2:
                System.out.println("SUMMER");
                break;
            case 3:
                System.out.println("AUTUMN");
                break;
            case 4:
                System.out.println("SPRING");
                break;
            default:
                System.out.println("WRONG SEASON");
                break;
        }
    }

    static void forLoop(){
        int result =0;
        for(int i = 0; i<=10; i++){
            result+=i;
        }
        System.out.println(result);
    }

    static void forEachLoop(){
        int[] numbers= {2,5,6,7,34,67,54};
        for(int number : numbers){
            System.out.printf("%d ",number);
        }
    }

    static void whileLoop(int[] numbers){
        int index = 0;
        while (index++ <numbers.length){
            if (numbers[index-1] % 2 == 0)
            System.out.println("even");
            else
                System.out.println("odd");
        }
    }

    static void doWhile(){
        int number = 5;
        int counter = 0;
        do{
            System.out.println(counter++);
        }while (counter !=number);
    }
}