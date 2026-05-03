import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        //simpleTryCatchTest();

        //TryCatchExampleTime();


        Car car1 = new Car(2022,500);

        Car car2 = new Car(2025,300);


        System.out.println(Car.brand);

        car1.brand ="mercedes";

        System.out.println(car2.brand);
        System.out.println(Car.counter);

    }

    private static void TryCatchExampleTime() {
        try {
            Time time1 = new Time(26,65,60);
            System.out.println(time1.toUniversalString());
            System.out.println(time1.toShortString());
        }catch (Exception e){
            System.out.println(e.getMessage());
        }
    }

    private static void simpleTryCatchTest() {
        Scanner scanner = new Scanner(System.in);

        try{
            System.out.println("please enter a value ");
            int value1 = scanner.nextInt();

            System.out.println("please enter another value ");
            int value2 = scanner.nextInt();

            System.out.println(value1/value2);
        }catch (Exception e){
            System.out.println(e.getMessage());
        }


        System.out.println("done!");
    }
}