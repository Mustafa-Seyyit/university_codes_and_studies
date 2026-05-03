public class Cat extends Animal {

    int age;

    public Cat(String color, int age){
       super(color);
       this.age = age;
    }
    public void meuw(){}

    @Override
    public void eat(){
        System.out.println("cat is eating");
    }


    public void test(){
        super.eat();
        this.eat();
    }
}
