public class Main {
    public static void main(String[] args) {


        Vehicle plane = (Vehicle) new Plane();  //upcasting  Plane to Vehicle
        Vehicle car  = new  Car();
        Vehicle ship =  new Ship();
        ship.test();

   //     Ship s = (Ship)ship;
     //   s.swim();
        ((Ship)ship).swim();

      //  ((Plane)plane).fly();  //downcasting  Vehicle -> Plane
      //  ((Plane)car).fly();

       // plane = ship;

        //((Plane)plane).fly(); // run time error.

        //((Ship)plane).swim();


        Vehicle[] vehicles = new Vehicle[]{plane, car, ship};

                for(Vehicle v : vehicles)
                    v.drive();
    }
}