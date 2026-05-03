package Test;

public class SuperClass extends GrandSuperClass {

    public void method1(){
        System.out.println("method 1 in superclass");
    }

    public void test(){
        super.method1();
    }
}
