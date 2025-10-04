public class Item {
    private final String name;
    public final int weight; // kg

    public Item(String name, int weight) {
        this.name = name;
        this.weight = weight;
    }

    public String getName() {
        return name;
    }
}