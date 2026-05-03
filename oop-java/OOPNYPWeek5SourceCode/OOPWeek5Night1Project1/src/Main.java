
enum Season{
    WINTER(1, "asdasdsadas"),
    SUMMER(2,"asdsasd"),
    AUTUMN(3),
    SPRING(5);

    private int index;
    String desc;

    private Season(int index){
        this.index = index;
    }

    private Season(int index,String desc){
        this.index = index;
        this.desc = desc;
    }

    public int getIndex(){
        return  index;
    }
}
public class Main {
    public static void main(String[] args) {
       // System.out.println("Hello world!");

        Season season = Season.AUTUMN;

        Season[] seasons  = Season.values();


        for(Season s : seasons)
            System.out.println(s + " " + s.getIndex());

       // System.out.println(season);

       // Patient patient1 = new Patient("asd","a+");
        //Patient patient2 = new Patient("asd2","a-");

        //System.out.println(Patient.getCounter());
    }
}