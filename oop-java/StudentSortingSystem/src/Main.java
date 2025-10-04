import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

// Main class to run the application
public class Main {
    public static void main(String[] args) {
        // Renaming 'students' to 'studentList' for slightly better clarity
        List<Student> studentList = new ArrayList<>();

        studentList.add(new Student(101, "Vijay", 23, 80));
        studentList.add(new Student(106, "Ajay", 27, 56));
        studentList.add(new Student(105, "Jai", 21, 100));

        // Sorts the list using the compareTo method implemented in the Student class
        Collections.sort(studentList);

        System.out.println("Students sorted by grade (Ascending):");
        for (Student st : studentList) {
            System.out.println(st);
        }
    }
}
