namespace TicTacToeNew
{
    class TicTacToe
    {
        public TicTacToe()
        {
            //Play();
        }

        public void Play()
        {
            GameBoard gameBoard = new GameBoard();
            Player playerX = new Player('X');
            Player playerO = new Player('O');
            Player currentPlayer = playerX;
            int moveCounter = 0;
            bool play = true;
            while (play)
            {
                gameBoard.PrintBoard();
                Console.WriteLine($"Player{currentPlayer.GetSign()} Please Enter the field in which you want to put the character {currentPlayer.GetSign()}", currentPlayer.GetSign());
                try
                {
                    gameBoard.PutMark(currentPlayer, playerX.TakeTurn());
                    gameBoard.ClearBoard();
                    moveCounter++;
                    if (currentPlayer.CheckWin(gameBoard))
                    {
                        Console.WriteLine($"Player: {currentPlayer.GetSign()} has won a game!", currentPlayer.GetSign());
                        gameBoard.PrintBoard();
                        play = false;
                    }
                    else if (CheckDraw(moveCounter))
                    {
                        Console.WriteLine($"DRAW");
                        gameBoard.PrintBoard();
                        play = false;
                    }
                    currentPlayer = ChangeCurrentPlayer(currentPlayer, playerX, playerO);
                }
                catch (Exception)
                {
                    Console.WriteLine($"Invalid Input. Please enter number between 1-9!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        private Player ChangeCurrentPlayer(Player currentPlayer, Player playerX, Player playerO)
        {
            return currentPlayer == playerX ? playerO : playerX;

        }

        private bool CheckDraw(int turnCounter)
        {
            if (turnCounter == 9)
                return true;
            return false;
        }

        public void PlayAnotherGame()
        {
            Console.WriteLine("Do you want to play another game ?");
            Console.WriteLine("======================================");
            Console.WriteLine("1: Yes! Let's play a game! ");
            Console.WriteLine("2: No! Leave me alone! ");
            Console.WriteLine("======================================");
            string userChoice2 = Console.ReadLine();
            switch (userChoice2)
            {
                case "1":
                    Console.Clear();
                    Play();

                    break;
                case "2":
                    Console.WriteLine("See you next time!");
                    break;
                default:
                    Console.WriteLine("Incorrect option...press any key");
                    Console.ReadKey();
                    break;
            }
        }

    }

}
