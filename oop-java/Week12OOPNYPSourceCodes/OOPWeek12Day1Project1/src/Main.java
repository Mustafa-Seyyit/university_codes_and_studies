import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

public class Main {



    public static void main(String[] args) {

        //Engineer engineer1 = new Engineer("john",12, "ai");
        String filePath = "mydata.kbu";

        Engineer engineer1 = new Engineer("john",12, "ai");
        Engineer engineer2 = new Engineer("nash",15, "network");
        Engineer engineer3 = new Engineer("mike",9, "graphics");

        ArrayList<Engineer> engineers = new ArrayList<>();
        engineers.add(engineer1);
        engineers.add(engineer2);
        engineers.add(engineer3);

        SaveLoadManager.WriteToFile(engineers,filePath);

        ArrayList<Engineer> loadedEngineers  = (ArrayList<Engineer>)SaveLoadManager.ReadFromFile(filePath);
        System.out.println(loadedEngineers);

       // CompareElements();
    }

    private static void CompareElements() {
        Engineer engineer1 = new Engineer("john",12, "ai");
        Engineer engineer2 = new Engineer("nash",15, "network");
        Engineer engineer3 = new Engineer("mike",9, "graphics");

        ArrayList<Engineer> engineers = new ArrayList<>();
        engineers.add(engineer1);
        engineers.add(engineer2);
        engineers.add(engineer3);

        NameComparator nameComparator = new NameComparator();
        IdComparator idComparator = new IdComparator();
        FieldComparator fieldComparator = new FieldComparator();


        Comparator myComparator = null;

        myComparator = idComparator;
        Collections.sort(engineers,myComparator);

        Collections.reverse(engineers);

        for (Engineer e : engineers)
            System.out.println(e);


        myComparator = nameComparator;
        Collections.sort(engineers,myComparator);

        for (Engineer e : engineers)
            System.out.println(e);

        myComparator = fieldComparator;
        Collections.sort(engineers,myComparator);

        for (Engineer e : engineers)
            System.out.println(e);
//        for (Engineer e : engineers)
//            System.out.println(e);
//
//        System.out.println("after sorting");
//        Collections.sort(engineers);
//
//        for (Engineer e : engineers)
//            System.out.println(e);


//      //  boolean isEqual = engineer1 == engineer2;
//        boolean isEqual = engineer1.equals(engineer2);
//
//        ArrayList<String> nameList = new ArrayList<>();
//        nameList.add("ahmet");
//        nameList.add("zeynep");
//        nameList.add("murat");
//        nameList.add("elif");
//
//        System.out.println(nameList);
//
//        Collections.sort(nameList);
//
//        System.out.println(nameList);


        //   System.out.println(isEqual);
    }
}