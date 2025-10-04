import java.util.ArrayList;

public class Simulation {

    // Helper method to create item instances from string data
    ArrayList<Item> loadItems(String data) {
        // The original logic is retained but with corrected item names
        String[] itemLines = data.split("\n");

        ArrayList<Item> items = new ArrayList<>();
        Item item;
        for (String line : itemLines) {
            String[] parts = line.trim().split("=");
            if (parts.length == 2) {
                String name = parts[0].trim();
                int weight = Integer.parseInt(parts[1].trim());
                items.add(new Item(name, weight));
            }
        }
        return items;
    }

    // Helper method to create a new U1 rocket
    private U1 createNewU1() {
        return new U1();
    }

    // Helper method to create a new U2 rocket
    private U2 createNewU2() {
        return new U2();
    }

    // Loads items into U1 rockets
    ArrayList<Rocket> loadU1(ArrayList<Item> items) {
        ArrayList<Rocket> u1Rockets = new ArrayList<>();
        U1 currentRocket = createNewU1();

        for (Item item : items) {
            if (!currentRocket.canCarry(item)) {
                u1Rockets.add(currentRocket);
                currentRocket = createNewU1(); // Start a new rocket
            }
            currentRocket.carry(item);
        }
        // Add the last partially filled or full rocket
        u1Rockets.add(currentRocket);
        return u1Rockets;
    }

    // Loads items into U2 rockets
    ArrayList<Rocket> loadU2(ArrayList<Item> items) {
        ArrayList<Rocket> u2Rockets = new ArrayList<>();
        U2 currentRocket = createNewU2();

        for (Item item : items) {
            if (!currentRocket.canCarry(item)) {
                u2Rockets.add(currentRocket);
                currentRocket = createNewU2(); // Start a new rocket
            }
            currentRocket.carry(item);
        }
        // Add the last partially filled or full rocket
        u2Rockets.add(currentRocket);
        return u2Rockets;
    }

    /**
     * Runs the simulation for a list of rockets, handling failures and calculating total cost.
     * @param rockets The list of rockets to launch.
     * @return The total cost of the mission (including retries).
     */
    int runSimulation(ArrayList<Rocket> rockets) {
        long totalCost = 0; // Use long to prevent overflow with millions

        for (Rocket rocket : rockets) {
            totalCost += rocket.getConstructionCost(); // Initial cost for the launch

            // The mission must succeed (Launch AND Land) for the loop to exit
            while (!(rocket.launch() && rocket.land())) {
                // Relaunch/retry failure
                totalCost += rocket.getConstructionCost(); // Add cost of new rocket
            }
        }

        // Return cost as int since the main method expects int (be cautious of overflow)
        return (int) totalCost;
    }
}