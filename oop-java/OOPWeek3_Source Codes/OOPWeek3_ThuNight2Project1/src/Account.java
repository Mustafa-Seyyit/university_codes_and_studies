
import java.util.Scanner;

public class Account {
    private String name;
    private double balance;

    Account(String name, double balance){
        this.name = name;
        this.balance =balance;
    }

    public void deposit(double depositAmount)
    {
        if (depositAmount > 0)
        this.balance+=depositAmount;
    }

//    public double getBalance(){
//        return balance;
//    }
//
    public void setName(String name){
        //
        Scanner scanner = new Scanner(System.in);
        int pass = 1234;
        System.out.println("please enter your pass to change your account name");
        if (pass== scanner.nextInt())
            this.name = name;
        else
            System.out.println("you cannot change name");
    }
//
    public String getName(){
        return name;
    }
}
