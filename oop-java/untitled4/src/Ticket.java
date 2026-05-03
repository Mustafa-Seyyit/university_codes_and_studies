public abstract class Ticket {
    public int number;
    int seatNumber;

    public Ticket(int seatNumber, int number) {
        this.number = number;
        this.seatNumber = seatNumber;
    }

    abstract void print();
    abstract double computePrice();

}
