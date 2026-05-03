public class Main {
    public static void main(String[] args) {

        //Animal animal = new Animal();

        Animal pointer  = new Horse();
        Animal dog = new Dog();
        Animal horse = new Horse();
        dog.eat();

        pointer.eat();
        ((Cat)pointer).meuw();

      //  ((Cat)pointer).meuw(); // CAT IS AN ANIMAL THAT IS  POINTING A CAT OBJECT IN RAM. SO CAT CAN MEUW

       // ((Cat)dog).meuw(); ILLEGAL, DOG IS NOT A CAT. SO NO CASTING AT ALL.

        //Animal[] animals = {cat, dog, horse};

     //   for (Animal a : animals)
     //       a.eat();
    }
}