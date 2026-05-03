public class Dog extends Animal{

    public String breed;

    Dog(String color, String breed){
        super(color);
        this.breed = breed;
    }

    public void bark(){

    }

    public void test(){
        this.eat();
        super.eat();
    }

//    @Override
//    public void eat(){
//        System.out.println("dog is eating");
//    }
}
