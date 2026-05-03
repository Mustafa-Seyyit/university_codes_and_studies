package Test;

public class Subclass extends SuperClass{
    public void method1(){
        System.out.println("method 1 in subclass");
    }

    public void test(){
        super.method1();
        this.method1();
    }
}
