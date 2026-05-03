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

    public void move(){
       if (Game.isOver) return;
        System.out.println("please enter r for rock, s for scissor, p for paper q for quit");
        System.out.println(this.name +"' your turn!");
        Scanner scanner = new Scanner(System.in);
        boolean isInputValid;

        do {
            String choice =scanner.next();
            isInputValid=true;
            switch (choice){
                case "q":
                    Game.isOver=true;
                    break;
                case "r":
                    this.sign = HandSign.ROCK;
                    break;
                case "p":
                    this.sign = HandSign.PAPER;
                    break;
                case "s":
                    this.sign = HandSign.SCISSOR;
                    break;
                default:
                    isInputValid=false;
                    System.out.println("please enter a valid choice!");
                    System.out.println("please enter r for rock, s for scissor, p for paper q for quit");
                    break;
            }
            if (!Game.isOver)
                System.out.println(this.name +"-> "+ this.sign);
        }while (!isInputValid);
    }
}
