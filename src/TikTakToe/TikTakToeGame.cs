namespace TikTakToe;

public class TikTakToeGame
{
    public char[,] board = new char[3, 3] {{' ', ' ', ' '}, {' ', ' ', ' '}, {' ', ' ', ' '}};
    public char currentPlayer = 'x';
    public char winner = ' ';

    public void printBoard()
    {
        for(int line=0; line < board.GetLength(0); line++){
            string result = "";

            for(int colum=0; colum < board.GetLength(1); colum++)
            {
                result += board[line, colum]+" ";
            }

            Console.Write(result);
        }
    }

    public void makeMove(int line, int column, char player)
    {
        board[line, column] = player;
    }

    public bool isGameOver()
    {
        int playerXVDia = 0;
        int playerXVDiaSec = 0;
        int playerOVDia = 0;
        int playerOVDiaSec = 0;
        int isDraw = 0;

        for(int line=0; line < board.GetLength(0); line++){
            int playerXVert = 0;
            int playerXHori = 0;
            int playerOVert = 0;
            int playerOHori = 0;

            int lineReverse = board.GetLength(0) - (line + 1);

            if(board[line, line] == 'x') playerXVDia += 1;
            if(board[line, line] == 'o') playerOVDia += 1;
            if(board[lineReverse, lineReverse] == 'x') playerXVDiaSec += 1;
            if(board[lineReverse, lineReverse] == 'o') playerOVDiaSec += 1;

            for(int colum=0; colum < board.GetLength(1); colum++)
            {
                if(board[line, colum] == 'x') playerXHori += 1;
                if(board[line, colum] == 'o') playerOHori += 1;
                if(board[colum, colum] == 'x') playerXVert += 1;
                if(board[colum, colum] == 'o') playerOVert += 1;
                if(board[line, colum] == ' ') isDraw += 1;
            }

            if(playerOHori == 3 || playerOVert == 3) winner = 'o';
            if(playerXHori == 3 || playerXVert == 3) winner = 'x';
        }

        if(playerOVDia == 3 || playerOVDiaSec == 3) winner = 'o';
        if(playerXVDia == 3 || playerXVDiaSec == 3) winner = 'x';
        if(isDraw != 0) return false;
        else return true;
    }

    public void printResults()
    {
        if(winner == ' ') Console.WriteLine("Empate! Deu Velha!");
        if(winner == 'x') Console.WriteLine("O jogador x venceu!");
        if(winner == 'o') Console.WriteLine("O jogador o venceu!");
    }

    public char getCurrentPlayer()
    {
        return currentPlayer;
    }

    public int[] getPlayerEntry()
    {
        Console.WriteLine("Jogador " + currentPlayer + " informe a linha:");
        string input = Console.ReadLine() ?? "";
        int line = int.Parse(input);

        Console.WriteLine("Jogador " + currentPlayer + " informe a coluna:");
        input = Console.ReadLine() ?? "";
        int column = int.Parse(input);

        return new int[] { line, column };
    }

    public void changePlayer()
    {
        if(currentPlayer == 'x')
        {
            currentPlayer = 'o';
        }
        else
        {
            currentPlayer = 'x';
        }
    }
}
