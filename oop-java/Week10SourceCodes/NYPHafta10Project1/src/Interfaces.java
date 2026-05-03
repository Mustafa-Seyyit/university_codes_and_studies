
interface FlyBehaviour{
    void fly();
}

interface ShotBehaviour{
    void shot();
}

interface SwimBehaviour{
    void swim();
}


class Dragon implements FlyBehaviour, SwimBehaviour{

    @Override
    public void fly() {

    }

    @Override
    public void swim() {

    }
}
