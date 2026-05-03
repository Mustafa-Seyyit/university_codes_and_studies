public class Cat extends Animal {
    public int age;

    Cat(String color, int age){
        super(color);
        this.age = age;
    }
    public void meuw(){

    }
    @Override
    public void eat(){
        System.out.println("cat is eating");
    }

}
