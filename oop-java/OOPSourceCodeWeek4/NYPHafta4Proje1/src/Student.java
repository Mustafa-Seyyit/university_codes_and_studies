public class Student {
    private int id;
    private String name;
     static  int counter;
    final static String univName="KARABUK UNIV";

    Student(int id, String name){
        this.id = id;
        this.name = name;
        counter++;
    }



}
