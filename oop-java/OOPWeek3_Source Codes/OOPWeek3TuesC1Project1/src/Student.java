public class Student {
    int id; //default, visible to the package
    public String name; //visible to everyone
    private int finalScore; // visible to class


    Student(){
        this.id = 10;
        this.name="no name";
        this.finalScore = 50;
    }
    Student(int id, String name, int finalScore){
        this.id = id;
        this.name = name;
        this.finalScore = finalScore;
    }

    public void printAllInfo(){
        System.out.println(this.id +" "+this.name+""+this.finalScore);
    }




    float getFinalScore(){
        return  finalScore;
    }



}
