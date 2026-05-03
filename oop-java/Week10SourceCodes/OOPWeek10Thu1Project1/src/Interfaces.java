

interface InterfaceA{
    void A();
}

interface InterfaceB{
    void B();
}

interface InterfaceC extends InterfaceA,InterfaceB{
    void C();
}

class ImplementingClass implements InterfaceC{
    @Override
    public void A() {

    }

    @Override
    public void B() {

    }

    @Override
    public void C() {

    }
}

