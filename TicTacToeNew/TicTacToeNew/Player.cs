namespace TicTacToeNew
{
    public class Player
    {
        char sign;

        public Player(char playerSign)//constructors
        {
            sign = playerSign;
        }


        public char GetSign()//getojam player zimi
        {
            return sign;
        }


        public int TakeTurn()//lasam field no speletaja
        {
            int fieldNumber = int.Parse(Console.ReadLine());
            return fieldNumber;
        }

        private bool CheckRowsForWin(GameBoard gameBoard)//parbaudam rows
        {
            for (int i = 0; i < GameBoard.boardSize; i++)
            {
                if (CheckRowCol(gameBoard.Board[i, 0].GetFieldState(), gameBoard.Board[i, 1].GetFieldState(), gameBoard.Board[i, 2].GetFieldState()))
                    return true;
            }
            return false;
        }

        private bool CheckColumnsForWin(GameBoard gameBoard)//parbaudam columns
        {
            for (int i = 0; i < GameBoard.boardSize; i++)
            {
                if (CheckRowCol(gameBoard.Board[0, i].GetFieldState(), gameBoard.Board[1, i].GetFieldState(), gameBoard.Board[2, i].GetFieldState()))
                    return true;
            }
            return false;
        }


        private bool CheckDiagonalsForWin(GameBoard gameBoard)//parbaudam abas diagonales
        {
            return ((CheckRowCol(gameBoard.Board[0, 0].GetFieldState(), gameBoard.Board[1, 1].GetFieldState(), gameBoard.Board[2, 2].GetFieldState()) == true) || (CheckRowCol(gameBoard.Board[0, 2].GetFieldState(), gameBoard.Board[1, 1].GetFieldState(), gameBoard.Board[2, 0].GetFieldState()) == true));
        }

        private bool CheckRowCol(FIELD c1, FIELD c2, FIELD c3)//parbaudam vai 3 value are vienadi un nav tuksi
        {

            return (c1 != FIELD.Blank) && (c1 == c2) && (c2 == c3);
        }


        public bool CheckWin(GameBoard gameBoard)//parbaudam vai 3 conditions are patiesi
        {
            return (CheckRowsForWin(gameBoard) || CheckColumnsForWin(gameBoard) || CheckDiagonalsForWin(gameBoard));
        }

    }
}