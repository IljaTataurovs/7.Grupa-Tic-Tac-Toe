Console.Title = "Tic Tac Toe";
char player = 'X';
int n = 3;
char[,] board = new char[n, n];
int movesPlayed = 0;
Menu();


void brainOfGame(char player)
{
    while (true)
    {
        Console.Clear(); 
        PrintBoard(board);
        Console.WriteLine($"Player {player} make your move! Please choose square were to put {player} sign ");
        Console.WriteLine($"2 cipari kā koordināte, piemēram 11 vai 23, vai ...");
        Console.WriteLine($"Pirmais skaitlis ir row(sarkans) Otrais skaitlis ir column (zals)");
        string info = Console.ReadLine();
        if (!info.Equals(11) || !info.Equals(12) || !info.Equals(10) || !info.Equals(21) || !info.Equals(22) || !info.Equals(20) || !info.Equals(01) || !info.Equals(02) || !info.Equals(00))
        {
            Console.WriteLine("Incorrect input1");
        }

        int row = int.Parse(info.Substring(0,1));
        int column = int.Parse(info.Substring(1,1));
        if (row < 0 || column < 0|| row > n || column > n)
        {
            Console.WriteLine("Incorrect input2");
        }

       //board[row-1, column-1] = player;//user ievadija 11 =(0,0) 22=(1,1)
       

        

        //if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])//parbaudam var ir uzvaretajs pirma rinda
        //{
        //    Console.Clear();
        //    printBoard(board);
        //    Console.WriteLine($"Player {player} has won the game!");
        //    break;
        //}
        //if (player == board[3, 1] && player == board[2, 2] && player == board[1, 3])//parbaudam var ir uzvaretajs diagonala rinda
        //{
        //    Console.Clear();
        //    printBoard(board);
        //    Console.WriteLine($"Player {player} has won the game!");
        //    break;
        //}
        //if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])//parbaudam var ir uzvaretajs diagonala rinda 2
        //{
        //    Console.Clear();
        //    printBoard(board);
        //    Console.WriteLine($"Player {player} has won the game!");
        //    break;
        //}
        //if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])//parbaudam var ir uzvaretajs otra rinda
        //{
        //    Console.Clear();
        //    printBoard(board);
        //    Console.WriteLine($"Player {player} has won the game!");
        //    break;
        //}
        //if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])//parbaudam var ir uzvaretajs tresaja rinda
        //{
        //    Console.Clear();
        //    printBoard(board);
        //    Console.WriteLine($"Player {player} has won the game!");
        //    break;
        //}
        //if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])//parbaudam var ir uzvaretajs 1 kolonna
        //{
        //    Console.Clear();
        //    printBoard(board);
        //    Console.WriteLine($"Player {player} has won the game!");
        //    break;
        //}
        //if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])//parbaudam var ir uzvaretajs 2 kolonna
        //{
        //    Console.Clear();
        //    printBoard(board);
        //    Console.WriteLine($"Player {player} has won the game!");
        //    break;
        //}
        //if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])//parbaudam var ir uzvaretajs 3 kolonna
        //{
        //    Console.Clear();
        //    printBoard(board);
        //    Console.WriteLine($"Player {player} has won the game!");
        //    break;
        //}
        //else
        //{
        //    Console.WriteLine($"Incorrect input3");
        //}

        
        if (movesPlayed == 9)
        {
            Console.Clear();
            PrintBoard(board);
            Console.WriteLine("No one won a game! it's a draw!");
            break;
        }

        
        
        //Move(row, column, player);
        if (board[row, column] == ' ')
        {

            board[row, column] = player;

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

        for (int i = 0; i < n; i++)//check rows
        {
            if (board[i, column] != player)
            {
                break;
            }
            if (i == 2)
            {
                Console.Clear();
                PrintBoard(board);
                Console.WriteLine($"Player {player} has won the game!");
                break;
            }
        }
        for (int i = 0; i < n; i++)//check columns
        {
            if (board[row, i] != player)
            {
                break;
            }
            if (i == n - 1)
            {
                Console.Clear();
                PrintBoard(board);
                Console.WriteLine($"Player {player} has won the game!");
                break;
            }
        }
        if (row == column) //check diagonal
        {
            for (int i = 0; i < n; i++)
            {
                if (board[i, i] != player)
                {
                    break;
                }
                if (i == n - 1)
                {
                    Console.Clear();
                    PrintBoard(board);
                    Console.WriteLine($"Player {player} has won the game!");
                    break;
                }
            }
        }
        if ((row + column) == n - 1) //check diagonal diffrent direction
        {
            for (int i = 0; i < n; i++)
            {
                if (board[i, (n - 1) - i] != player)
                {
                    break;
                }
                if (i == n - 1)
                {
                    Console.Clear();
                    PrintBoard(board);
                    Console.WriteLine($"Player {player} has won the game!");
                    break;
                }
            }
        }
        player = ChangePlayer(player);
    }
}



static char ChangePlayer(char currentplayer)//mainam speletaju
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



void PrintStartBoard(char[,] board)//inicializejam laukumu
{
    for (int row = 0; row < n; row++)
    {
        for (int column = 0; column < n; column++)
        {
            board[row, column] = ' ';

        }
    }
}



void PrintBoard(char[,] board)//izprintejam laukumu
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"    0   1   2  ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"__|___|___|___|");
   
    for (int row = 0; row < n; row++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{row }");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($" | ");
        for (int column = 0; column < n; column++)
        {
            Console.Write(board[row, column]);
            Console.Write(" | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Menu()//menu kur lietotajs var izveleties vai vins grib uzspelet speli
{

    Console.Clear();
    Console.WriteLine("======================");
    Console.WriteLine("Hello, do you want to play a game?");
    Console.WriteLine("Please make a choise! ");
    Console.WriteLine("======================");
    Console.WriteLine("1: Yes! Let's play a game! ");
    Console.WriteLine("2: No! Leave me alone! ");
    Console.WriteLine("======================");

    int userChoise = int.Parse(Console.ReadLine());
    switch (userChoise)
    {
        case 1:
            Console.Clear();
            PrintStartBoard(board);
            brainOfGame(player);
            break;
        case 2:
            Console.WriteLine("See you next time!");
            break;
        default:
            Console.WriteLine("Incorrect option...press any key");
            Console.ReadKey();
            break;
    }
}









