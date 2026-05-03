import java.util.Comparator;

class BrandComparator implements Comparator<Car>{

    @Override
    public int compare(Car car1, Car car2) {
        return  car1.brand.compareTo(car2.brand);
    }
}

class PriceComparator implements Comparator<Car>{

    @Override
    public int compare(Car car1, Car car2) {
        if (car1.price >car2.price) return  1;
        else   if (car1.price < car2.price) return  -1;
        else  return 0;
    }
}

class PYearComparator implements Comparator<Car>{

    @Override
    public int compare(Car car1, Car car2) {
        return car1.pYear - car2.pYear;
//        if (car1.pYear >car2.pYear) return  1;
//        else   if (car1.pYear < car2.pYear) return  -1;
//        else  return 0;
    }
}