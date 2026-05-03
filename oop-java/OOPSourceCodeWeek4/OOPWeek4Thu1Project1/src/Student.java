public class Student {
    private int id;
    private static   int counter;
    private String name;
   final static String univName="KBU";

    Student(int id, String name){
        this.id = id;
        this.name = name;
        counter++;
    }

    public static int getCounter(){
        return counter;
    }
}
