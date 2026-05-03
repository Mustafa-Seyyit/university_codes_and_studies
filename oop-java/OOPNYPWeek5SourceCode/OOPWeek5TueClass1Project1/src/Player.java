public class Player {
    int id;
    String position;
    String name;

    private static int counter;

    public Player(int id, String position, String name) {
        this.id = id;
        this.position = position;
        this.name = name;
        counter++;
    }

    public static int getCounter(){
        return counter;
    }




}
