public class Book implements Comparable<Book>{
    String name;
    double price;

    public Book(String name, double price){
        this.name = name;
        this.price = price;
    }

    @Override
    public String toString() {
        return String.format("Name: %s Price: %.1f",name, totalPrice());
    }

    public double totalPrice(){return price + 0.08 * price;}

    @Override
        public int compareTo(Book other){
            if(this.totalPrice() > other.totalPrice()) return 1;
            else if(this.totalPrice() < other.totalPrice()) return -1;
            else return 0;
    }
}
