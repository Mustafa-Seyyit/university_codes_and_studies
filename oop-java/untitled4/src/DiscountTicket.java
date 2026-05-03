public class DiscountTicket extends StandardTicket{
    double discount;
    DiscountTicket(int sNumber, int number, double discount){
        super(sNumber,number);
        this.discount = discount;
    }

    @Override
    double computePrice() {
        return super.computePrice() - discount;
    }

    @Override
    void print() {
        System.out.println(seatNumber +" " + number + " "+computePrice());
    }
}