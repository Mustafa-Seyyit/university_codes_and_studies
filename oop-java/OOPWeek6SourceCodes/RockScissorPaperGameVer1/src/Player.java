import java.util.Scanner;

enum HandSign{
    ROCK,SCISSOR,PAPER
}
public class Player {
    HandSign sign;
    String name;
    int wins;
    static int trials;
    static int draws;
    public Player(String name){
        this.name = name;
    }


    // take the player movements. whether if rock scissor or paper
    public void move(){
        if (Game.isOver) return;
        System.out.println(this.name + "! your turn!");
        System.out.println("please enter r for rock s for scissor p for paper and q for quit");
        Scanner userInput = new Scanner(System.in);

        boolean isInputValid;

        do{
            isInputValid=true;
            String choice = userInput.next();
            switch (choice){
                case "q":
                    Game.isOver=true;
                    break;
                case "r":
                    sign = HandSign.ROCK;
                    break;
                case "s":
                    sign = HandSign.SCISSOR;
                    break;
                case "p":
                    sign = HandSign.PAPER;
                    break;
                default:
                    System.out.println("wrong input.");
                    System.out.println("please enter r for rock s for scissor p for paper and q for quit");
                    isInputValid=false;
                    break;
            }
            System.out.println(this.name +" sign is "+ sign);

        }
        while (!isInputValid);
    }
}
