namespace TicTacToeNew
{
    public class GameBoard
    {
        public const int boardSize = 3;
        public Cell[,] Board;


        public GameBoard()
        {
            initializeBoard();
        }


        private void initializeBoard()
        {
            Board = new Cell[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Board[i, j] = new Cell();
                }
            }
        }

        public void PrintBoard()
        {
            const int AsciiCode0 = 48;
            int fieldNumber = 1;
            Console.WriteLine("=====");
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (Board[i, j].isEmpty())
                        Console.Write((char)(AsciiCode0 + fieldNumber));
                    else
                        Console.Write((char)(Board[i, j].GetFieldState()));
                    fieldNumber++;

                    if (j < boardSize - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("=====");
        }

        public void PutMark(Player player, int fieldNumber)
        {

            int verticalY = (fieldNumber - 1) / 3;
            int horizontalX = (fieldNumber - 1) % 3;
            if (Board[verticalY, horizontalX].isEmpty())
            {
                Board[verticalY, horizontalX].markField(player);

            }

            else
            {
                ClearBoard();
                PrintBoard();
                Console.WriteLine($"This place is taken. Please Select the field again: ");
                PutMark(player, player.TakeTurn());
            }
        }

        public void ClearBoard()
        {
            Console.Clear();
        }
    }
}