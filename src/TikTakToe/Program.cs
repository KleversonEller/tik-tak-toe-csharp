namespace TikTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TikTakToeGame game = new TikTakToeGame();

            Console.WriteLine("Boas vindas ao Tik Tak Toe!");
            
            // Enquanto o jogo não acaba
            while(!game.isGameOver())
            {
                // Imprimir o tabuleiro
                game.printBoard();
                
                // Pedir ao jogador que informe sua jogada
                char player = game.getCurrentPlayer();
                int[] playerEntry = game.getPlayerEntry();
                
                // Fazer a jogada
                game.makeMove(playerEntry[0], playerEntry[1], player);
                
                // Trocar o jogador
                game.changePlayer();
            }
            
            // Caso o jogo acabe, é mostrado os resultados
            game.printResults();
        }
    }
}