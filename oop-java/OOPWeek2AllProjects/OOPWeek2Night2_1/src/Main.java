import java.util.Scanner;

public class Main {
    public static void main(String[] args) {


        Scanner input = new Scanner(System.in);

        Student student1 = new Student();
        System.out.println("please enter your name");
        student1.name =input.next();

        System.out.println("please enter your mid score");
        student1.midTerm = input.nextFloat();

        System.out.println("please enter your final score");
        student1.finScore = input.nextFloat();

        System.out.println("your score is:");
        System.out.println(student1.computeScore());

        Student student2 = new Student();
        student2.name ="ali";
        student2.midTerm = 70;
        student2.finScore = 100;
        System.out.println(student2.computeScore());


        //doSomething();
        //ifCond();
       // switchCase(3);
        //forLoop(10);

        //whileLoop();
        //forEachLoop();
        //doWhile(30);
    }

    static void doSomething(){
        System.out.printf("Hello %s!  %d %n", "from java", 1);
        // System.out.println("from jana!")
    }

    static void ifCond(){
        int score = 45;

        if (score< 35)System.out.println("you failed, work hard next time to pass");
        else if(score <50)  System.out.printf("you condinially passed");
        else System.out.println("you passed");
    }

    static void switchCase(int number){

        switch (number){
            case 1:
                System.out.println("ONE");
                break;
            case 2:
                System.out.println("TWO");
                break;
            case 3:
                System.out.println("THREE");
                break;
            default:
                System.out.println("not defined");
                break;
        }
    }


    static void forLoop(int limit){
        int sum = 0;
        for(int i=0; i<=limit;i++)
        {
            sum+=i;
        }
        System.out.println(sum);
    }

    static void forEachLoop(){
        String[] names = {"mike","tom","paul","jane"};

        for(String name : names)
        {
            System.out.println(name);
        }
    }





    static void whileLoop(){

        int currentNumber = 20;
        int sum = 0;
        while (currentNumber > 0)
        {
            sum+=currentNumber;
            currentNumber--;
        }
        System.out.println(sum);
    }

    static void doWhile(int upperBound){
        int value = 0;
        do{
            if (value % 2 == 0)
                System.out.printf("%d is even %n", value);
            else
                System.out.printf("%d is odd %n", value);

        }while (value++ < upperBound);
    }



}