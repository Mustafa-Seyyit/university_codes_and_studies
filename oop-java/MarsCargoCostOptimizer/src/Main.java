import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        // Initialize the simulation core
        Simulation simulation = new Simulation();

        // --- Phase 1: Heavy Infrastructure Items ---
        // Total weight is 58000 kg.
        String phase1Data = "building tools=2000\n" +
                "building tools=2000\n" +
                "building tools=2000\n" +
                "building tools=5000\n" +
                "building tools=5000\n" +
                "building tools=2000\n" +
                "building tools=1000\n" +
                "building tools=5000\n" +
                "building tools=6000\n" +
                "shelter equipment=5000\n" +
                "construction equipment=5000\n" +
                "plants=1000\n" +
                "steel=8000\n" +
                "books=1000\n" +
                "water=5000";

        // --- Phase 2: Habitat and Supplies Items ---
        // Total weight is 32000 kg.
        String phase2Data = "habitat=3000\n" +
                "colony=5000\n" +
                "food=5000\n" +
                "habitat=3000\n" +
                "colony=5000\n" +
                "food=3000\n" +
                "colony=5000\n" +
                "food=3000";

        // 1. Load Items for Phase 1
        ArrayList<Item> itemsPhase1 = simulation.loadItems(phase1Data);
        ArrayList<Rocket> rocketsU1_P1 = simulation.loadU1(itemsPhase1);
        ArrayList<Rocket> rocketsU2_P1 = simulation.loadU2(itemsPhase1);

        // 2. Run Simulation for Phase 1 and get total cost
        long costU1_P1 = simulation.runSimulation(rocketsU1_P1);
        long costU2_P1 = simulation.runSimulation(rocketsU2_P1);

        // 3. Load Items for Phase 2
        ArrayList<Item> itemsPhase2 = simulation.loadItems(phase2Data);
        ArrayList<Rocket> rocketsU1_P2 = simulation.loadU1(itemsPhase2);
        ArrayList<Rocket> rocketsU2_P2 = simulation.loadU2(itemsPhase2);

        // 4. Run Simulation for Phase 2 and get total cost
        long costU1_P2 = simulation.runSimulation(rocketsU1_P2);
        long costU2_P2 = simulation.runSimulation(rocketsU2_P2);

        System.out.println("=========================================");
        System.out.println("      MARS MISSION COST OPTIMIZER        ");
        System.out.println("=========================================");

        // --- RESULTS PHASE 1 ---
        System.out.println("\n--- PHASE 1: Total Cargo 58,000 kg ---");
        System.out.println("U1 Rocket Count: " + rocketsU1_P1.size() + " (Capacity: 18,000 kg)");
        System.out.println("U2 Rocket Count: " + rocketsU2_P1.size() + " (Capacity: 29,000 kg)");
        System.out.printf("Total Cost U1: $%,d\n", costU1_P1);
        System.out.printf("Total Cost U2: $%,d\n", costU2_P1);
        System.out.println("Most cost-effective prototype for Phase 1: " + ((costU1_P1 < costU2_P1) ? "U1" : "U2"));

        // --- RESULTS PHASE 2 ---
        System.out.println("\n--- PHASE 2: Total Cargo 32,000 kg ---");
        System.out.println("U1 Rocket Count: " + rocketsU1_P2.size());
        System.out.println("U2 Rocket Count: " + rocketsU2_P2.size());
        System.out.printf("Total Cost U1: $%,d\n", costU1_P2);
        System.out.printf("Total Cost U2: $%,d\n", costU2_P2);
        System.out.println("Most cost-effective prototype for Phase 2: " + ((costU1_P2 < costU2_P2) ? "U1" : "U2"));

        System.out.println("\nNOTE: Costs will vary with each run due to the probabilistic nature of the simulation.");
    }
}