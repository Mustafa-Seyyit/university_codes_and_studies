import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

//        Time time1 = new Time(25,60,60);
//        System.out.println(time1.toShortString());
//        System.out.println(time1.toUniversalString());

        Student s1 = new Student(21313,"dsadas");
        System.out.println(Student.univName);

       // Student.univName = "SU";

        Student s2= new Student(313,"dsasasdasdsadas");
        System.out.println(s2.univName);
        System.out.println(s1.univName);
        System.out.println(Student.getCounter());
    }

    private static void simpleTryCatch() {
        Scanner input = new Scanner(System.in);

        try{
            System.out.println("please enter a value");
            int val1 = input.nextInt();

            System.out.println("please enter another value");
            int val2 = input.nextInt();

            System.out.println(val1/val2);

        }catch (Exception exception){
            System.out.println("the problem: "+exception.getMessage());
        }


        System.out.println("done!");
    }



}