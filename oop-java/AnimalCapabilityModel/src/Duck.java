public class Duck extends Animal implements Flyable, Moveable, Swimmable {

    public Duck(String name) {
        super(name);
    }

    @Override
    public void fly() {
        System.out.println(getName() + " (Duck): Flies short distances by flapping wings.");
    }

    @Override
    public void move() {
        System.out.println(getName() + " (Duck): Moves by waddling.");
    }

    @Override
    public void swim() {
        System.out.println(getName() + " (Duck): Swims using webbed feet (Naturally).");
    }
}