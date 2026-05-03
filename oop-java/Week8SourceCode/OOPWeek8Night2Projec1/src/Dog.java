public class Dog extends Animal{
    String breed;

    Dog(String color, String breed){
        super(color);
        this.breed = breed;

        //this.color = color;
    }

    public void eat(){
        System.out.println("dog is eating");
    }

    public void bark(){}
}
