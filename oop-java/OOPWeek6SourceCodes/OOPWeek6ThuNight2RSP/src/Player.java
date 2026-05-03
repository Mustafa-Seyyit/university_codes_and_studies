import java.util.Scanner;

enum HandSign {ROCK, SCISSOR, PAPER}
public class Player {
    String name;
    int wins;
    static int trials;
    static int draws;
    HandSign sign;

    public Player(String name){
        this.name = name;
    }


    void makeMove(){
        if (Game.isOver) return;
        System.out.println(this.name +"! your turn!");
        System.out.println("please enter q to quit r for rock s for scissor p for paper");

        boolean isInputValid;
        Scanner scanner = new Scanner(System.in);
       do {
           isInputValid=true;
           char choice = scanner.next().charAt(0);

           switch (choice){
               case 'q':
                   Game.isOver=true;
                   break;
               case 'r':
                   this.sign = HandSign.ROCK;
                   break;
               case 's':
                   this.sign = HandSign.SCISSOR;
                   break;
               case 'p':
                   this.sign = HandSign.PAPER;
                   break;
               default:
                   System.out.println("wrong choice!");
                   System.out.println("please enter q to quit r for rock s for scissor p for paper");
                   isInputValid=false;
                   break;
           }
           System.out.println(this.name +" is " + sign);
       }while (!isInputValid);
    }
}
