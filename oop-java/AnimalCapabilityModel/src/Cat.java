public class Cat extends Animal implements Moveable, Swimmable {

    public Cat(String name) {
        super(name);
    }

    @Override
    public void swim() {
        System.out.println(getName() + " (Cat): Swims using strokes (Reluctantly).");
    }

    @Override
    public void move() {
        System.out.println(getName() + " (Cat): Moves by running/walking.");
    }
}