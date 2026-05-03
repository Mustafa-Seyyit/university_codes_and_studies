import other.Worker;
public class Main {
    public static void main(String[] args) {
      //  Worker worker = new Worker();
        Customer customer = new Customer("mike", 45);
        Customer customer2 = new Customer("john");

        Account account = new Account("my account", 100);

        System.out.println(account.getName());

        account.setName("my new account");

        System.out.println(account.getName());


        //RectangleTest();


        //   System.out.println(customer.name);

       // System.out.println(customer.discount);
    }

    private static void RectangleTest() {
        Rectangle r1 = new Rectangle();
        Rectangle r2 = new Rectangle(10,15);
        Rectangle r3= new Rectangle(-5,5,10,15);
    }



}