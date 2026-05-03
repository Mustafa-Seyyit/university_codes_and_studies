import java.util.Scanner;

enum HandSign {ROCK, SCISSOR, PAPER}
public class Player {
    String name;
    int wins;
    static  int draws;
    static int trials;
    HandSign sign;

    Player(String name){
        this.name = name;
    }

    void makeMove(){
        if (Game.isOver) return;
        System.out.println(this.name +" ! your turn!");
        System.out.println("please enter q for quit, r for rock, s for scissor, p for paper");
        Scanner scanner = new Scanner(System.in);

        char userChoice  = scanner.next().toLowerCase().charAt(0);
        boolean validInput;

        do{
            validInput = true;
            switch (userChoice){
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
                    validInput=false;
                    System.out.println("wrong input");
                    System.out.println("please enter q for quit, r for rock, s for scissor, p for paper");
                    break;
            }
          if (!Game.isOver)   System.out.println(this.name +"  is "+ this.sign);

        }while (!validInput);
    }
}
