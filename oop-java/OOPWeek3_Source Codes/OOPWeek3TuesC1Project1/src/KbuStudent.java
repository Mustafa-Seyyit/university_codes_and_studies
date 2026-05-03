import java.util.Random;

public class KbuStudent {
    private String firstName;
    private String lastName;
    private  int studentNumber;

    KbuStudent(String f, String l, int number){
        this.firstName = f;
        this.lastName =l;
        this.studentNumber =number;
    }

    public void setFirstName(String fName){
        //
        this.firstName = fName;
    }

    public String getFirstName(){
        return firstName;
    }



}
