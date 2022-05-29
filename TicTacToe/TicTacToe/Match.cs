namespace TicTacToe
{

    public class Match
    {
        int n = 3;
        int movesPlayed = 0;
        // public State currentPlayer;
        public GameBoard board { get; set; }
        public char player = 'X';
        bool isValid = true;
        public Match()
        {
            board = new GameBoard(n, n);

        }
        public void StartGame(char player)
        {
            while (isValid)
            {
                Console.Clear();


                if (board.Rows < 0 || board.Columns < 0 || board.Rows > n || board.Columns > n)
                {
                    Console.WriteLine("Input error");
                }


                if (board.BoardPosition(board.Rows, board.Columns) == ' ')//ja laukums ir tukss tad mes pieskiram X vai 0(player)
                {

                    //board.BoardPosition(board.Rows, board.Columns)=player ;


                    // board.BoardPosition(board.Rows, board.Columns) = Convert.ToChar(player);
                    //gameBoard[board.Rows, board.Columns] = Convert.ToChar(player);
                    //player.position = position;

                    movesPlayed++;//skaitam kartas cik nospeletas ja 9 tad ir neizskirts

                }
                else
                {
                    // ... output an error message
                    Console.WriteLine("That spot is already taken!...press any key");
                    movesPlayed--;
                    Console.ReadKey();
                    player = ChangePlayer(player);


                }
                //public void checkWinner()
                //{
                //    for (int i = 0; i < 3; i++)//check rows
                //    {
                //        if (board.BoardPosition(i, board.Columns) != null)
                //        {
                //            break;

                //        }
                //        if (i == 3 - 1)
                //        {
                //            Console.WriteLine($"Winner is ; {board.Columns}");
                //            Console.Read();
                //            matchIsFinished = true;
                //            //OutputWinner();
                //        }
                //    }
                //}


                for (int i = 0; i < n; i++)//check rows
                {
                    if (board.BoardPosition(i, board.Columns) != player)
                    {
                        break;
                    }
                    if (i == n - 1)
                    {
                        // OutputWinner();

                    }
                }
                for (int i = 0; i < n; i++)//check columns
                {
                    if (board.BoardPosition(i, board.Columns) != player)
                    {
                        break;
                    }
                    if (i == n - 1)
                    {
                        //OutputWinner();

                    }
                }
                if (board.Rows == board.Columns) //check diagonal
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (board.BoardPosition(i, i) != player)
                        {
                            break;
                        }
                        if (i == n - 1)
                        {
                            // OutputWinner();

                        }
                    }
                }
                if ((board.Rows + board.Columns) == n - 1) //check diagonal diffrent direction
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (board.BoardPosition(i, (n - 1) - i) != player)
                        {
                            break;
                        }
                        if (i == n - 1)
                        {
                            //OutputWinner();

                        }
                    }
                }



                if (movesPlayed == 9)
                {
                    //Console.Clear();
                    //PrintBoard(board);
                    //Console.WriteLine("No one won a game! it's a draw!");
                    //Console.WriteLine("Please press any key for main menu");
                    //Console.ReadKey();
                    //Menu();

                }

                player = ChangePlayer(player);

            }
        }

        public char ChangePlayer(char currentplayer)//mainam speletaju
        {
            if (currentplayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }
    }
}
