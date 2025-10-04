import java.util.Random;

public class U1 extends Rocket {

    // NEW Max Carry Capacity (scaled from 10 to 18000 kg)
    private static final int U1_MAX_CARGO = 18000;
    // NEW Cost (scaled from 100 to 100 million)
    private static final int U1_COST = 100000000;

    // Total weight (Max Cargo + Rocket Weight) used in the probability formula
    private static final double U1_TOTAL_WEIGHT = 29000;

    public U1() {
        this.currentCargo = 0;
        this.totalCarry = U1_MAX_CARGO;
        this.constructionCost = U1_COST;
    }

    @Override
    public boolean launch() {
        // P(Launch Failure) = 5% * (Cargo Carried / Max Cargo)
        // Probability is scaled to a percentage (0 to 100)
        double failureProb = 0.05 * (currentCargo / (double) U1_MAX_CARGO);

        // Generate a random number between 0.0 and 1.0
        double randomRoll = random.nextDouble();

        // If random roll is greater than failure probability, launch succeeds
        return randomRoll >= failureProb;
    }

    @Override
    public boolean land() {
        // P(Land Failure) = 1% * (Cargo Carried / Max Cargo)
        double failureProb = 0.01 * (currentCargo / (double) U1_MAX_CARGO);

        double randomRoll = random.nextDouble();

        // If random roll is greater than failure probability, landing succeeds
        return randomRoll >= failureProb;
    }
}