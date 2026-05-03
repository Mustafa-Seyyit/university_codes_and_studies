public class Main {
    public static void main(String[] args) {

        Animal horse =  (Animal) new Horse();  // upcasting horse -> animal
        Animal cat = new Cat();
        Animal dog = new Dog();

        Animal p1 = cat;

        ((Cat)p1).meuw();

        p1 = dog;
       ((Dog)p1).bark();

      //  ((Cat)cat).meuw();  // downcasting Animal -> Cat

        //((Dog)cat).bark();

        Animal[] animals = new Animal[]{horse, cat, dog};

      //  for(Animal animal : animals)
      //      animal.eat();
    }
}