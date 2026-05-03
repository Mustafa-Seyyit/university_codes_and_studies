import java.util.Collections;
import java.util.Iterator;
import java.util.LinkedList;

public class MainClass {

    public static void main(String[] args) {
        //Duck a1 = new Duck();
        //Fish a2 = new Fish();

//        a2.swim();
//
//        Flyable a3 = a1;
//        Flyable a4 = (Flyable) a2;
//        a1.fly();
//        a4.fly();



        Book book1 = new Book("book 1", 100);

        Book book2 = new Book("book 1", 30);

        Book book3 = new Book("book 1", 50);

        Book book4 = new Book("book 1", 15);

        LinkedList<Book> books = new LinkedList<>();
        books.add(book1);
        books.add(book2);
        books.add(book3);
        books.add(book4);

        Collections.sort(books);
        Collections.reverse(books);

        //Iterator iterator = books.iterator();

        for(Book book : books){
            System.out.println(book);
        }




//        Animal animal = new Fish();
//
//
//        Animal a= new Duck();
//        ((Duck)a).swim();
//        ((Swimmable)a).swim();
//
//       // Flyable f =  (Flyable)new Fish();
//
//        Flyable f =  new Duck();
//
//
//        Animal myAnimal = new Duck();
//
//        ((Duck) a).swim();


        //  ((Flyable)a2).fly();

    }
}
