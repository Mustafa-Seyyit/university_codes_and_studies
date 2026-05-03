import java.util.Collections;
import java.util.Iterator;
import java.util.LinkedList;

public class MainClass {

    public static void main(String[] args) {
        //q2();
        q3();
    }

    private static void q2() {
        Fish fish = new Fish();
        Duck duck = new Duck();

        Animal a = new Duck();
        ((Duck)a).swim();

        ((Flyable)a).fly();
        Flyable f = new Duck();//(Flyable)new Fish();
        f.fly();
    }

    private static void q3() {
        Book b1 = new Book("b1", 15);
        Book b2 = new Book("b2", 8);
        Book b3 = new Book("b3", 20);
        Book b4 = new Book("b4", 12);

        LinkedList<Book> books = new LinkedList<>();
        books.add(b1);
        books.add(b2);
        books.add(b3);
        books.add(b4);



        Collections.sort(books);
        Collections.reverse(books);

        Iterator iterator = books.iterator();

        while (iterator.hasNext())
            System.out.println(iterator.next());
    }
}
