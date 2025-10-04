# Mars Mission Cost Optimizer (Java Simulation)

This project is a Java simulation designed to model and compare the total mission costs of transporting cargo to Mars using two different fictional rocket prototypes: **U1** and **U2**. The simulation calculates the most cost-effective rocket for two mission phases by considering cargo capacity, construction cost, and the probabilistic risk of launch and landing failures.

---

## 🚀 Project Goal

The primary objective is to determine which rocket prototype offers better value across different cargo requirements. The total mission cost includes the initial construction cost of all rockets launched, plus the cost of replacements for any launch or landing failure, as these retries incur the full cost of a new rocket.

### Mission Phases

1.  **Phase 1: Heavy Infrastructure Items** (Total Cargo: 58,000 kg)
2.  **Phase 2: Habitat and Supplies Items** (Total Cargo: 32,000 kg)

---

## ⚙️ Rocket Specifications and Failure Logic

The success of a launch or landing is determined by a **Monte Carlo simulation** (random chance) based on a failure probability formula that scales with the cargo load:

$$P(\text{Failure}) = \text{Base Failure Rate} \times \left(\frac{\text{Current Cargo}}{\text{Max Cargo}}\right)$$

| Prototype | Max Cargo (kg) | Construction Cost (USD) | Launch Failure Formula | Landing Failure Formula |
| :--- | :--- | :--- | :--- | :--- |
| **U1** | 18,000 kg | $100,000,000 | $5\% \times (\text{Cargo} / 18000)$ | $1\% \times (\text{Cargo} / 18000)$ |
| **U2** | 29,000 kg | $120,000,000 | $4\% \times (\text{Cargo} / 29000)$ | $8\% \times (\text{Cargo} / 29000)$ |

**Note:** Since the simulation uses random number generation, the total cost will be slightly different with every execution of the `Main` class.

---

## 📂 Code Structure

The project uses a clean **Object-Oriented** structure:

* **`SpaceShip` (Interface):** Defines the contract for all rockets (`launch()`, `land()`, `canCarry()`, `carry()`).
* **`Rocket` (Abstract Class):** Base class that implements common rocket properties (cargo capacity, cost) and the `SpaceShip` contract.
* **`U1` / `U2` (Classes):** Concrete implementations of the `Rocket` class with specific capacity, cost, and failure rates.
* **`Item` (Class):** Represents a single piece of cargo with a name and weight.
* **`Simulation` (Class):** Handles the core logic: loading items from data, packing them efficiently into rockets (a simple knapsack approach), and running the launch/landing loop until success.
* **`Main` (Class):** The main entry point to run the two-phase mission and print the comparative cost analysis.

---

## ▶️ How to Run

1.  **Prerequisites:** Ensure you have the **Java Development Kit (JDK)** installed.
2.  **Compile:** Navigate to the project directory and compile all Java files:
    ```bash
    javac *.java
    ```
3.  **Execute:** Run the simulation from the `Main` class:
    ```bash
    java Main
    ```

The console will display the total cargo weights, the number of rockets used, the final costs (including retries), and the most cost-effective prototype for Phase 1 and Phase 2.
