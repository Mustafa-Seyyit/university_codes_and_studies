public class Car {
    private int modelYear;
    private  int enginePower;
    static String brand = "BMW";

    static int counter;

    public Car(int mYear, int ePower){
        this.modelYear = mYear;
        this.enginePower = ePower;
        counter++;
    }




}
