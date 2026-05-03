

interface  InterfaceA{
    void A();
}

interface  InterfaceB{
    void B();
}

interface InterfaceC extends InterfaceB {
    void C();
}

class ImplementingClass implements InterfaceC, InterfaceA{
    @Override
    public void C() {

    }

    @Override
    public void A() {

    }

    @Override
    public void B() {

    }
}