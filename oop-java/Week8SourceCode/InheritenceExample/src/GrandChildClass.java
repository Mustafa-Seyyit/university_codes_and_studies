public class GrandChildClass extends ChildClass{

    @Override
    public void method1(){
        System.out.println("method 1 in grand child");
    }

    void test(){
        super.method1();
        this.method1();
    }
}
