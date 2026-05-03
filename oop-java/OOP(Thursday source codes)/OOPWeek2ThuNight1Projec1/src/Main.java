import java.util.*;

public class Main {
    public static void main(String[] args) {
        //CollectionWithIterator();
       // ListWithListItarator();
        ComparatorExample();

        //ComparableExample();

//        boolean isEqual = (car1== car2);
//        boolean isAnotherEqual = car1.equals(car2);
//
//        System.out.println(isEqual);
//
//        System.out.println(isAnotherEqual);


    }

    private static void ComparatorExample(){
        Car car1 = new Car("BMW",2024, 50000);
        Car car2 = new Car("GMC",2020, 40000);
        Car car3 = new Car("Ford",2021, 35000);

        ArrayList<Car> cars = new ArrayList<>();

        cars.add(car1);
        cars.add(car2);
        cars.add(car3);

        for (Car car: cars)
            System.out.println(car);

        BrandComparator brandComparator = new BrandComparator();
        PYearComparator pYearComparator = new PYearComparator();
        PriceComparator priceComparator = new PriceComparator();

        Comparator currentComparator = null;

        System.out.println("sort by year");
        currentComparator = pYearComparator;
        Collections.sort(cars,currentComparator);
        for (Car car: cars)
            System.out.println(car);

        System.out.println("sort by brand");

        currentComparator = brandComparator;
        Collections.sort(cars,currentComparator);
        for (Car car: cars)
            System.out.println(car);

        System.out.println("sort by price");
        currentComparator = priceComparator;
        Collections.sort(cars,currentComparator);
        for (Car car: cars)
            System.out.println(car);

        Collections.reverse(cars);
    }

    private static void ComparableExample() {
        Car car1 = new Car("BMW",2024, 50000);
        Car car2 = new Car("GMC",2020, 40000);
        Car car3 = new Car("Ford",2021, 35000);

        ArrayList<Car> cars = new ArrayList<>();

        cars.add(car1);
        cars.add(car2);
        cars.add(car3);

        for (Car car: cars)
            System.out.println(car);


        Collections.sort(cars);
        System.out.println("after sorting");
        for (Car car: cars)
            System.out.println(car);

        Collections.reverse(cars);

        System.out.println("reversed");
        for (Car car: cars)
            System.out.println(car);
    }

    private static void ListWithListItarator(){

        List<Employee> employeeList = new ArrayList<>();   //Generic for type safetly.
        // myCollection.add(2);
        // myCollection.add("data");
        Employee employee1 = new Employee(15,"mike");
        Employee employee2 = new Employee(25,"jane");
        Employee employee3 = new Employee(5,"george");

        employeeList.add(employee1);
        employeeList.add(employee2);
        employeeList.add(employee3);

        //ListIterator listIterator = employeeList.listIterator();

        ListIterator listIterator = employeeList.listIterator(employeeList.size());

//        System.out.println(employeeList.size());
//        while (listIterator.hasNext()){
//            System.out.println(listIterator.next());
//            //listIterator.remove();
//        }

        while (listIterator.hasPrevious()){
            System.out.println(listIterator.previous());
            listIterator.remove();
        }

        System.out.println(employeeList.size());


    }

    private static void CollectionWithIterator() {
        Collection<Employee> myCollection = new ArrayList<>();   //Generic for type safetly.
        // myCollection.add(2);
        // myCollection.add("data");
        Employee employee1 = new Employee(15,"mike");
        Employee employee2 = new Employee(25,"jane");
        Employee employee3 = new Employee(5,"george");

        myCollection.add(employee1);
        myCollection.add(employee2);
        myCollection.add(employee3);

        for (Employee employee : myCollection)
            System.out.println(employee);


        System.out.println("before removing elements");
        System.out.println(myCollection.size());

        Iterator iterator = myCollection.iterator();
        while (iterator.hasNext())
        {
            System.out.println(iterator.next());
            iterator.remove();
        }

        System.out.println("after removing elements");
        System.out.println(myCollection.size());
    }
}

class Employee{
    int id;
    String name;

    public Employee(int id, String name) {
        this.id = id;
        this.name = name;
    }

    @Override
    public String toString() {
        return id +" " + name;
    }
}