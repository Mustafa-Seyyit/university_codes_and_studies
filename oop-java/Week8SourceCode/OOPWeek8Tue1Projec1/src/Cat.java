public class Cat extends Animal {
    public int age;

    public Cat(String color, int age){
    super(color);
    this.age = age;
    }


    public void meuw(){
        System.out.println("meuw");
    }
    @Override
    public void eat(){
        System.out.println("cat is eating");
    }
}
