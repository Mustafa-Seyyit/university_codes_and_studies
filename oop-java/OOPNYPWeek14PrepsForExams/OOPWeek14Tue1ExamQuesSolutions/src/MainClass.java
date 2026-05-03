public class MainClass {
    public static void main(String[] args) {
        Fish fish = new Fish();
        Duck duck = new Duck();

       // ((Flyable)fish).fly();
        Animal a = new Duck();
        ((Duck)a).swim();
        ((Swimmable)a).swim();
        ((Duck)a).fly();
        Flyable f = (Flyable)new Fish();

        f = new Duck();


    }
}
