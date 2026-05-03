import diger.Worker;
public class Main {
    public static void main(String[] args) {
        //Worker worker = new Worker();

        Employee employee = new Employee(1232,"adadsad");
        System.out.println(employee.name);

        Employee employee1 = new Employee();
        System.out.println(employee1.name);



        Rectangle rectangle1 = new Rectangle();
         rectangle1.width = 15;
        Rectangle rectangle2 = new Rectangle(10,15);
        Rectangle rectangle3 = new Rectangle(-5,5,10,15);

        Rectangle[] rectangles = {rectangle1, rectangle2, rectangle3};

        for(Rectangle r: rectangles)
            r.showRectangleInfo();

    }
}

//class Employee{
//    int id;
//    private String name;
//}