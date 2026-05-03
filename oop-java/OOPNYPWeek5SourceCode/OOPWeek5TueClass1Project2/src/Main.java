
enum Season{
    SUMMER,
    AUTUMN,
    WINTER,
    SPRING;
}
public class Main {
    public static void main(String[] args) {


        Branch branch = Branch.PHSICS;

        System.out.println(branch.getId());

        Branch[] branches = Branch.values();

        for(Branch b : branches)
            System.out.println(b+ " " + b.description);


        //Season season = Season.S
        //
        //
        //
        // PRING;
      //  System.out.println(season);

//
//        Season[] seasons = Season.values();
//
//        for (Season s : seasons)
//            System.out.println(s);

    }
}

