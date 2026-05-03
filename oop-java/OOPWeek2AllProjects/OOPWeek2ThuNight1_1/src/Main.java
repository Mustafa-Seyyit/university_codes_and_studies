import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
       // System.out.printf("%s from %s  ---> %d", "Hello", "java", 1);
        //ifCond();

        //switchCase();
        //forLoop();
       // forEachLoop();
       // whileLoop();
       // doWhile();

        Student student1 = new Student();
        Scanner input = new Scanner(System.in);

        System.out.println("please enter your name");
        student1.name = input.next();

        System.out.println("please enter your midterm score:");
        student1.midScore = input.nextInt();

        System.out.println("please enter your final score:");
        student1.finScore =input.nextFloat();



        System.out.println("your score and info are:");
        System.out.println(student1.returnInfo());
        System.out.println(student1.computeScore());


//        Student student2 = new Student();
//        student2.midScore = 70;
//        student2.finScore =80;
//        student2.name = "jane";
//
//        System.out.println(student2.computeScore());
    }

    static void ifCond(){

        int number =45;


//        if(){}
//            else if(){}
//                else{}
        if(number % 2 == 0)
        {
            System.out.printf("the number %d is even", number);
            System.out.println("---");
        }
        else
            System.out.printf("the number %d is odd", number);
    }

     static void switchCase(){
        String season = "winter";

        switch (season)
        {
            case "winter":
                System.out.printf("%d season",1);
                break;
            case "spring":
                System.out.printf("%d season",2);
                break;
            case "autumn":
                System.out.printf("%d season",3);
                break;
            case "summer":
                System.out.printf("%d season",4);
                break;
            default:
                System.out.printf("%d season",-1);
                break;
        }
    }

    static void forLoop(){
        int counter = 0;
        for(int i= 0; i<= 10; i++)
        {
            counter+=i;
        }
        System.out.println(counter);
    }

    static void forEachLoop(){
        String[] names = {"Jane, Mike, Jerry, Tom, Slyvester"};

        for(String name : names)
            System.out.println(name);
    }


    static void whileLoop(){
        int counter= 0;
        int index = 0;
        while(index++ < 10){
            counter+=index;
        }
        System.out.println(counter);
    }
    static void doWhile(){
        int index = 0;
        int sum = 0;
        int upperLimit = 100;
        do{
            sum+=index;
            index++;

        }while (sum <upperLimit);
        System.out.println(sum);

    }



}