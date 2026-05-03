import java.util.Scanner;

public class Main {
    static String name ="mike mikey";

    public static void main(String[] args) {
       // computeStudentScore("tom",60,90);

            //testStudent();
        Student student1 = new Student();

        Scanner input = new Scanner(System.in);
        System.out.println("please enter midterm score:");
        student1.mid = input.nextFloat();

        System.out.println("please enter final score:");
        student1.fin = input.nextFloat();

        System.out.println(student1.computeStudentScore());
    }

     static void testStudent(){
         Student s1 = new Student();
         s1.name ="tom";
         s1.mid = 70;
         s1.fin = 90;
         System.out.println(s1.computeStudentScore() + " " +s1.name);

         Student s2 = new Student();
         s2.name ="tom";
         s2.mid = 70;
         s2.fin = 90;
         System.out.println(s2.computeStudentScore() + " " +s2.name);
         Student s3 = null;

     }

    static String computeStudentScore(String name, float mid, float fin){
        float aver = mid*0.4f +fin*0.6f;
        String info = name + " "+aver;
        return info;
    }

    static  void ifCond(){
        int score = 9;
        if (score < 5){
            System.out.println("you failed");
        }

        else if(score< 8)
        {
            System.out.println("boarderline");
        }
        else{
            System.out.println("passed");
        }

    }
    static  void switchCase(){

        String day ="WINTER";
        switch (day){
            case "WINTER":
                System.out.println("this is winter");
                break;
            case "SUMMER":
                System.out.println("this is SUMMER");
                break;
            case "AUTUMN":
                System.out.println("this is AUTUMN");
                break;
            case "SPRING":
                System.out.println("this is SPRING");
                break;
            default:
                break;
        }
    }
    static  void forLoop(){
            String[] days = {"WINTER","AUTUMN", "SUMMER", "SPRING"};
            for(int i = 0; i<days.length;i++){
                System.out.println(days[i]);
            }
    }
    static  void forEach(){
        String[] days = {"WINTER","AUTUMN", "SUMMER", "SPRING"};
         for(String day : days){
             System.out.println(day);
         }
    }
    static  void whileLoop(){
        int counter = 0;
        while (counter++< 10)
        {
        System.out.println(counter);
        }
    }
    static void doWhile(){
        int trials = 0;
        do {
            System.out.printf("trial %d -> %s %n ",trials, "take money");
            trials++;
        }while (trials <10);
    }
}