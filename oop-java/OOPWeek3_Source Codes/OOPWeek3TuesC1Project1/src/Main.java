import otherpackage.Worker;
public class Main {
    public static void main(String[] args) {
     //   Student s1 = new Student(15,"tommy", 100); //  Student() is class class constructor


        Student s2 = new Student();
        s2.printAllInfo();
        //  System.out.println(s1.id);
       // System.out.println(s1.getFinalScore());

       // Worker w1 = new Worker();
        //w1.name public so visible.
        //w1.id  default so invisible to otherpackage


      //  Rectangle r1 = new Rectangle();
        Rectangle r2 = new Rectangle(10,15);

        Rectangle r3 = new Rectangle(-5,5,10,15);




        KbuStudent kbuStudent = new KbuStudent("tom","tomson", 3453252);
        kbuStudent.setFirstName("tommy");
        System.out.println(kbuStudent.getFirstName());
    }



}