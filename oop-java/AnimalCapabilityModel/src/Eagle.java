public class Eagle extends Animal implements Flyable {

    public Eagle(String name) {
        super(name);
    }

    @Override
    public void fly() {
        System.out.println(getName() + " (Eagle): Flies high and glides using large wings.");
    }

    // Note: Eagle implicitly inherits the Animal class's properties but only implements Flyable.
}