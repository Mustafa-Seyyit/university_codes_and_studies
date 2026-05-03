public class Main {
    public static void main(String[] args) {
        //School s = new School();
        School sch = new HighSchool();
        School elementarySchool = new ElementarySchool();

       School[] schools = new School[]{sch, elementarySchool};

      // for(School school : schools)
    //       school.doStudy();

        sch = elementarySchool;
        //sch.doClubActivity();
      //  ((HighSchool)sch).doClubActivity();

        ((ElementarySchool)sch).playGames();


 //      HighSchool hs = (HighSchool) highSchool;
  //     hs.doClubActivity();



    }
}