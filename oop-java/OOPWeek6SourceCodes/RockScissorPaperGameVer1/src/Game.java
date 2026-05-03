public class Game {
    static boolean isOver;
    Player player1;
    Player player2;

    public Game(Player player1, Player player2){
        this.player1 =player1;
        this.player2 = player2;
    }

    public void start() {
        while (!isOver){
            player1.move();
            player2.move();
            processMoves();
        }
        displayScores(player1);
        displayScores(player2);
    }


    // compare the signs and do pointing.
    void processMoves(){
        if (player1.sign == null || player2.sign == null  || Game.isOver) return;
        else if(player1.sign == player2.sign) Player.draws++;
        else if(player1.sign == HandSign.PAPER && player2.sign == HandSign.ROCK) player1.wins++;
        else if(player1.sign == HandSign.ROCK && player2.sign == HandSign.SCISSOR) player1.wins++;
        else if(player1.sign == HandSign.SCISSOR && player2.sign == HandSign.PAPER) player1.wins++;
        else player2.wins++;

        Player.trials++;
    }

    void displayScores(Player player){
        String info = String.format(" Name: %s wins: %d draws %d trials %d success rate: %f",
                player.name,
                player.wins,
                Player.draws,
                Player.trials,
                (Player.trials == 0) ? 0: (float)player.wins/Player.trials*100
                );

        System.out.println(info);
    }
}
