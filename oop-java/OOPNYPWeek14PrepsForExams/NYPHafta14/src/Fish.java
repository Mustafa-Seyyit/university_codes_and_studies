public class Fish extends Animal implements Swimmable{
    @Override
    public void swim() {
        System.out.println("fish swims");
    }

    @Override
    void move() {
        System.out.println("fish moves");
    }


}
