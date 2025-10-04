import java.util.Random;

public abstract class Rocket implements SpaceShip {
    protected int currentCargo; // current weight carried
    protected int totalCarry;   // maximum cargo weight capacity
    protected int constructionCost; // rocket's construction cost

    protected static final Random random = new Random();

    @Override
    public abstract boolean launch(); // Abstract methods must be implemented by subclasses

    @Override
    public abstract boolean land();

    @Override
    public boolean canCarry(Item item) {
        return currentCargo + item.weight <= totalCarry;
    }

    @Override
    public void carry(Item item) {
        if (canCarry(item)) {
            currentCargo += item.weight;
        }
    }

    // Getter for cost, needed by Simulation class
    public int getConstructionCost() {
        return constructionCost;
    }
}