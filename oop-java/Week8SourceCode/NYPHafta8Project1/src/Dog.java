public class Dog extends Animal {

    String breed;
    Dog(String color){
        super(color);
    }

    public void bark(){
        System.out.println("hav hav");
    }
    @Override
    public void eat(){
        System.out.println("dog is eating");
    }

}
