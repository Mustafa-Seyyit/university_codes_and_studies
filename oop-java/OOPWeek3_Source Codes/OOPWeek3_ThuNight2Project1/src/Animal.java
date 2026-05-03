public class Animal {
    public String origin;
    int age;
    private int numberOfLegs;


    public Animal(){

    }
    public Animal(String origin, int age, int numberOfLegs){
        this.origin= origin;
        this.age =age;
        this.numberOfLegs =numberOfLegs;
    }

    public Animal(String origin, int age){
        this.origin= origin;
        this.age =age;
    }

}
