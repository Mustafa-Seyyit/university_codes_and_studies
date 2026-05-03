
interface InterfaceA{
    void A();
}
interface InterfaceB {
    void B();
}

interface InterfaceC extends InterfaceA, InterfaceB{
    void C();
}

class MyClass implements InterfaceB, InterfaceA{

    @Override
    public void A() {

    }

    @Override
    public void B() {

    }
}
