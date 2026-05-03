import other.Computer;
public class Main {
    public static void main(String[] args) {
        //createAnimals();

        //createRectangles();

        Account account = new Account("my account", 100);
        System.out.println(account.getName());

        account.setName("my premium account");
        System.out.println(account.getName());


        // animal1.numberOfLegs

        //Computer computer = new Computer();

    }

    private static void createAnimals() {
        Animal animal1 = new Animal("asia",5,4);
        Animal animal3 = new Animal("asia",6);

        Animal animal = new Animal();
        System.out.println(animal1.age);
    }

    static void createRectangles(){
        Rectangle r1 = new Rectangle();
        Rectangle r2 = new Rectangle(10,15);
        Rectangle r3 = new Rectangle(-5,5,10,15);

    }
}