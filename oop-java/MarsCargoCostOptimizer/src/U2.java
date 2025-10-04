import java.util.Random;

public class U2 extends Rocket {

    // NEW Max Carry Capacity (scaled from 11 to 29000 kg)
    private static final int U2_MAX_CARGO = 29000;
    // NEW Cost (scaled from 120 to 120 million)
    private static final int U2_COST = 120000000;

    // Total weight (Max Cargo + Rocket Weight) used in the probability formula
    private static final double U2_TOTAL_WEIGHT = 47000;

    public U2() {
        this.currentCargo = 0;
        this.totalCarry = U2_MAX_CARGO;
        this.constructionCost = U2_COST;
    }

    @Override
    public boolean launch() {
        // P(Launch Failure) = 4% * (Cargo Carried / Max Cargo)
        double failureProb = 0.04 * (currentCargo / (double) U2_MAX_CARGO);

        double randomRoll = random.nextDouble();

        return randomRoll >= failureProb;
    }

    @Override
    public boolean land() {
        // P(Land Failure) = 8% * (Cargo Carried / Max Cargo)
        double failureProb = 0.08 * (currentCargo / (double) U2_MAX_CARGO);

        double randomRoll = random.nextDouble();

        return randomRoll >= failureProb;
    }
}