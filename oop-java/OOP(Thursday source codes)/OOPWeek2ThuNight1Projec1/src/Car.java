public class Car implements Comparable<Car>{
    String brand;
    int pYear;
    double price;


    Car(String brand, int pYear, double price){
        this.brand = brand;
        this.pYear = pYear;
        this.price = price;
    }


    @Override
    public String toString() {
        return String.format("Brand: %s Year: %d Price %.1f", brand, pYear, price);
    }

    @Override
    public boolean equals(Object other) {
        if(this == other) return true;
        if(other == null || this.getClass() != other.getClass()) return false;
        else {
            Car otherCar = (Car)other;
            return this.price == otherCar.price &&
                    this.pYear == otherCar.pYear &&
                    this.brand.equals(otherCar.brand);
        }
    }


    //to sort by price
    @Override
    public int compareTo(Car otherCar) {
        if(this.price > otherCar.price) return 1;
        else if(this.price< otherCar.price) return -1;
        else return 0;
    }

//to sort by brand name (string)
//    @Override
//    public int compareTo(Car otherCar) {
//        return this.brand.compareTo(otherCar.brand);
//    }


}
