public class Game {
    static boolean isOver;
    Player player1;
    Player player2;
    Game(Player player1, Player player2){
        this.player1 = player1;
        this.player2 = player2;
    }

    public void start(){
        while (!isOver){
            player1.move();
            player2.move();
            processMove();
        }
        displayScore(player1);
        displayScore(player2);
    }



    void processMove(){
        if (player1.sign == null || player2.sign == null || isOver==true) return;
        if (player1.sign == HandSign.SCISSOR && player2.sign == HandSign.PAPER) {
            System.out.println(player1.name +" wins!");
            player1.wins++;
        }
        else if (player1.sign == HandSign.ROCK && player2.sign == HandSign.SCISSOR){
            System.out.println(player1.name +" wins!");
            player1.wins++;
        }
        else if (player1.sign == HandSign.PAPER && player2.sign == HandSign.ROCK) {
            System.out.println(player1.name +" wins!");
            player1.wins++;
        }
        else if(player1.sign == player2.sign) {
            Player.draws++;
            System.out.println("draws!");
        }
        else{
            player2.wins++;
            System.out.println(player1.name +" wins!");
        }
        Player.trials++;
    }

    private void displayScore(Player player) {
        String info = String.format("name: %s wins: %d draws: %d trials: %d success %f",
                player.name,
                player.wins,
                Player.draws,
                Player.trials,
                (Player.trials== 0) ? 0:(float)player.wins/Player.trials*100
                );
        System.out.println(info);
    }
}
