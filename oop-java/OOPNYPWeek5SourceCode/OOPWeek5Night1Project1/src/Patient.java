public class Patient {

    private String name;
    private String bloodType;

    private static int counter;

    public Patient(String name, String bloodType){
        this.name = name;
        this.bloodType = bloodType;
        counter++;
    }

    public String getName() {
        return name;
    }

    public  String getBloodType() {
        return bloodType;
    }

    public static int getCounter(){
        return  counter;
    }

}
