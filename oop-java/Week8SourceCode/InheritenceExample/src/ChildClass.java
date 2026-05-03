public class ChildClass extends ParentClass {

    @Override
    public void method1(){
        System.out.println("method 1 in child");
    }

    void test(){
        super.method1();
        this.method1();
    }
}
