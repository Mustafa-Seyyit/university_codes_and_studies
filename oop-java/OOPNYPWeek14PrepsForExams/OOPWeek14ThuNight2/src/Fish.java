public class Fish extends Animal implements Swimmable{

    @Override
    void move() {
        System.out.println("fish moves");
    }

    @Override
    public void swim() {
        System.out.println("fish swims");
    }
}
