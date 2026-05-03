import java.util.Collections;
import java.util.Comparator;
import java.util.LinkedList;

public class Main {
    public static void main(String[] args) {

      //  boolean isEqual  = (3==5);
      //  System.out.println(isEqual);


        Teacher teacher1  = new Teacher("Engin",123,2000,Branch.CS);
        Teacher teacher2  = new Teacher("Eren",54645,2500,Branch.PHYSICS);
        Teacher teacher3  = new Teacher("Nurdan",5623,2400,Branch.MATH);
        LinkedList<Teacher> teacherList = new LinkedList<>();

        teacherList.add(teacher1);
        teacherList.add(teacher2);
        teacherList.add(teacher3);


       for (Teacher teacher: teacherList)
           System.out.println(teacher);

       NameComparator nameComparator = new NameComparator();
       IDComparator idComparator = new IDComparator();
       BranchComparator branchComparator = new BranchComparator();
       WageComparator wageComparator = new WageComparator();

        Comparator myComparator = null;

        myComparator = nameComparator;
        System.out.println("sort by name: ");
        Collections.sort(teacherList,myComparator);
        for (Teacher teacher: teacherList)
            System.out.println(teacher);

        System.out.println("***********");

        myComparator = idComparator;
        System.out.println("sort by id: ");
        Collections.sort(teacherList,myComparator);
        for (Teacher teacher: teacherList)
            System.out.println(teacher);

        System.out.println("***********");

        myComparator = wageComparator;
        System.out.println("sort by wage: ");
        Collections.sort(teacherList,myComparator);
        for (Teacher teacher: teacherList)
            System.out.println(teacher);

        System.out.println("***********");

        myComparator = branchComparator;
        System.out.println("sort by branch: ");
        Collections.sort(teacherList,myComparator);
        for (Teacher teacher: teacherList)
            System.out.println(teacher);


//        System.out.println("after sort");
//        for (Teacher teacher: teacherList)
//            System.out.println(teacher);
//
//        Collections.reverse(teacherList);
//        System.out.println("reverse");
//        for (Teacher teacher: teacherList)
//            System.out.println(teacher);
        //boolean isEqual = (teacher1 == teacher2);

        //boolean isEqual = teacher1.equals(teacher2);
       // System.out.println(isEqual);

    }


}