import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        SimpleTryCatch();

        Time time2 = new Time(25,60,60);
        Time time3 = new Time(15,59,60);


    }

    private static void SimpleTryCatch() {
        Scanner scanner = new Scanner(System.in);

        try{
            System.out.println("please enter a value");
            int valu1 = scanner.nextInt();

            System.out.println("please enter another value");
            int valu2 = scanner.nextInt();

            System.out.println(valu1/valu2);
        }catch (Exception exp){
            System.out.println(exp.getMessage());
        }


        System.out.println("Hello world!");
    }


}