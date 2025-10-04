import java.util.ArrayList;
import java.util.List;

public class Main {

    /** Helper method to check and call capabilities polymorphically. */
    public static void checkCapabilities(Animal animal) {
        System.out.println("\n--- Checking Capabilities for " + animal.getName() + " ---");

        // Use 'instanceof' to check if the object implements the interface
        if (animal instanceof Moveable) {
            ((Moveable) animal).move();
        } else {
            System.out.println(animal.getName() + " cannot Move.");
        }

        if (animal instanceof Flyable) {
            ((Flyable) animal).fly();
        } else {
            System.out.println(animal.getName() + " cannot Fly.");
        }

        if (animal instanceof Swimmable) {
            ((Swimmable) animal).swim();
        } else {
            System.out.println(animal.getName() + " cannot Swim.");
        }
    }

    public static void main(String[] args) {

        System.out.println("=========================================");
        System.out.println("        Animal Capability Model Demo     ");
        System.out.println("=========================================");

        // Create instances
        Cat whiskers = new Cat("Whiskers");
        Duck daffy = new Duck("Daffy");
        Eagle aquila = new Eagle("Aquila");

        // Add them to a list of the abstract superclass type (Animal)
        List<Animal> zoo = new ArrayList<>();
        zoo.add(whiskers);
        zoo.add(daffy);
        zoo.add(aquila);

        // Demonstrate Polymorphism and Interfaces
        for (Animal animal : zoo) {
            checkCapabilities(animal);
        }
    }
}