public class Game {
    Player player1;
    Player player2;

    static boolean isOver;

    Game(Player player1, Player player2){
        this.player1 = player1;
        this.player2 = player2;
    }

    void start(){
        while (!isOver){
            player1.makeMove();
            player2.makeMove();
            processMoves();
        }

        displayScores(player1);
        displayScores(player2);
    }

    void processMoves(){
        if (player1.sign == null || player2.sign ==null || isOver ) return;
        if (player1.sign ==HandSign.ROCK && player2.sign ==HandSign.SCISSOR){
            player1.wins++;
            System.out.println(player1.name +" wins!");
        }
        else if (player1.sign ==HandSign.SCISSOR && player2.sign ==HandSign.PAPER) {
            player1.wins++;
            System.out.println(player1.name +" wins!");
        }
        else if (player1.sign ==HandSign.PAPER && player2.sign ==HandSign.ROCK) {
            player1.wins++;
            System.out.println(player1.name + " wins!");
        }
        else if(player1.sign == player2.sign) {
            Player.draws++;
            System.out.println("draws!");
        }
        else
        {
            player2.wins++;
            System.out.println(player2.name +" wins!");
        }

        Player.trials++;

    }

    private void displayScores(Player player) {
        String info = String.format(
                "name: %s wins: %d  trials: %d draws %d success rate %f",
                player.name,
                player.wins,
                Player.trials,
                Player.draws,
                (Player.trials == 0)  ? 0f: (float)player.wins/Player.trials*100
        );

        System.out.println(info);
    }

}
