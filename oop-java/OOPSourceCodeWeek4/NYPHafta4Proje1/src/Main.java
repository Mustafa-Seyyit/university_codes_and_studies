import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
     //   simpleTryCatchTest();

        Student s1 = new Student(12,"assdasd");
        Student s2 = new Student(15,"asdafdfd");

        System.out.println(Student.univName);
       // s1.univName = "SAFRANBOLU UNIV";

        System.out.println(Student.counter);
        System.out.println(s2.univName);


//        Time time1 = new Time(23,60,60);
//        System.out.println( time1.toShortString());
//
//        System.out.println("done");

    }

    private static void simpleTryCatchTest() {
        try{
            Scanner input = new Scanner(System.in);
            System.out.println("lutfen bir değer giriniz");
            int number1 =input.nextInt();

            System.out.println("lutfen baska bir değer giriniz");
            int number2 =input.nextInt();

            System.out.println(number1/number2);

        }catch (Exception exception){
            System.out.println(exception.getMessage());
        }


        System.out.println("done!");
    }



}