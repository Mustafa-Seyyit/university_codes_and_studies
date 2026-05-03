import java.util.Scanner;

public class Account {
    private String name;
    private  double balance;
    
    Account(String name, double balance){
        this.name = name;
        this.balance = balance;
    }

    public void deposit( double depositAmount)
    {
        if (depositAmount > 0)
            this.balance+=depositAmount;
    }
    public double getBalance(){
        return  balance;
    }

    public void setName(String  name){
        //
//        int userPass = 1234;
//        Scanner scanner = new Scanner(System.in);
//        if (userPass == scanner.nextInt())
            this.name = name;
    }

    public String getName(){
        //
        return  name;
    }

}
