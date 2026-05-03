import java.util.Scanner;

public class Account {
    private  String name;
    private double balance;

    Account(String name,double balance){
        this.name  = name;
        this.balance = balance;
    }

    public void deposit(double dAmount){

        if (dAmount>0)
            balance+=dAmount;
    }

    public double getBalance(){
        Scanner scanner = new Scanner(System.in);
        int userPass =1234;
        System.out.println("please enter your pass to get balance:");
        while (scanner.nextInt()!=userPass)
            System.out.println("please enter valid pass");
        return balance;
    }

    public String getName(){

        return name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

}
