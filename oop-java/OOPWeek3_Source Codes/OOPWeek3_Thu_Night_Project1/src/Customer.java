public class Customer {
    String name;
    String familyName;
    private int id;

    public double discount;

    public Customer(String name){
        this.name = name;
    }
    Customer(String name, int id){
        this.name=name;
        this.id =id;
    }

}
