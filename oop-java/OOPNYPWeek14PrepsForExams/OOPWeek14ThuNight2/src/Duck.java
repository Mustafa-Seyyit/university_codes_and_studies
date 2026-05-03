public class Duck extends Animal implements Flyable, Swimmable{

    @Override
    void move() {
        System.out.println("duck moves");
    }

    @Override
    public void fly() {
        System.out.println("duck flies");
    }

    @Override
    public void swim() {
        System.out.println("duck swims");
    }
}
