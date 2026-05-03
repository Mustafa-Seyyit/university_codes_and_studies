public class Game {
    static boolean isOver;
    Player player1;
    Player player2;

    Game(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    void start(){
        while (!isOver){
            player1.makeMove();
            player2.makeMove();
            processMovements();
        }

        displayScores(player1);
        displayScores(player2);
    }

    private void displayScores(Player player) {
        String info = String.format("name: %s  wins %d draws %d trials %d success rate %f",
                player.name,
                player.wins,
                Player.draws,
                Player.trials,
                (Player.trials == 0) ? 0: (float)player.wins/Player.trials*100
                );

        System.out.println(info);
    }

    private void processMovements() {
        if (player1.sign == null || player2.sign == null || isOver) return;
        else if(player1.sign == player2.sign) {
            Player.draws++;
            System.out.println("draws!");
        }
        else if(player1.sign == HandSign.PAPER && player2.sign == HandSign.ROCK) {
            player1.wins++;
            System.out.println(player1.name + " wins!");
        }
        else if(player1.sign == HandSign.ROCK && player2.sign == HandSign.SCISSOR) {
            player1.wins++;
            System.out.println(player1.name + " wins!");
        }
        else if(player1.sign == HandSign.SCISSOR && player2.sign == HandSign.PAPER) {
            player1.wins++;
            System.out.println(player1.name + " wins!");
        }
        else
        {
            player2.wins++;
            System.out.println(player2.name + " wins!");
        }

        Player.trials++;
    }
}
