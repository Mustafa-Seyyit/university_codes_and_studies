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

        Animal a= new Duck();
        Animal b =new Fish();

        //Flyable f = (Flyable)new Fish();
        Flyable f = new Duck();
        f.fly();


        //    ((Flyable)b).fly();
//
//        ((Duck)a).swim();
//        ((Swimmable)a).swim();
//
//        ((Duck)a).fly();
//        ((Flyable)a).fly();
    }
    private static void q3(){
        Book b1 = new Book("b1", 12);
        Book b2 = new Book("b2", 9);
        Book b3 = new Book("b3", 13);
        Book b4 = new Book("b4", 11);

        LinkedList<Book> books = new LinkedList<>();
        books.add(b1);
        books.add(b2);
        books.add(b3);
        books.add(b4);


        Iterator iterator = books.iterator();

        while (iterator.hasNext()){
            System.out.println(iterator.next());
        }

        Collections.sort(books);

        iterator = books.iterator();

        while (iterator.hasNext()){
            System.out.println(iterator.next());
        }
    }
}
