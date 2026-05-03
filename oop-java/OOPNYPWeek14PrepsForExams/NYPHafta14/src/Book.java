public class Book implements Comparable<Book>{
    String name;
    double price;

    public Book(String name, double price){
        this.name = name;
        this.price = price;
    }

    double totalPrice(){
        return  price +  0.08 * price;
    }

    @Override
    public int compareTo(Book otherBook) {
        if(this.totalPrice() > otherBook.totalPrice()) return  1;
        else if(this.totalPrice() < otherBook.totalPrice()) return  -1;
         else return  0;
    }


    @Override
    public String toString() {
        return String.format("total price %.2f", totalPrice());
    }
}
