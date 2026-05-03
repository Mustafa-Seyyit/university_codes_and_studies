public class Book implements Comparable<Book>{

    String name;
    double price;

    public Book(String name, double price) {
        this.name = name;
        this.price = price;
    }

    public double totalPrice(){
        return price + price *0.08 * price;
    }

    @Override
    public String toString() {
        return name + " "+ price;
    }

    @Override
    public int compareTo(Book other) {
        if(this.totalPrice() > other.totalPrice()) return 1;
        else if(this.totalPrice()< other.totalPrice())return -1;
        else return 0;
     }
}
