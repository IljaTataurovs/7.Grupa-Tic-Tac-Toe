Console.Title = "Tic Tac Toe";
char player = 'X';
char[,] board = new char[3, 3];
int movesPlayed = 0;
menu();


void brainOfGame(char player)
{
    while (true)
    {
        Console.Clear(); 
        printBoard(board);
        Console.WriteLine($"Player {player} make your move! Please choose square were to put {player} sign ");
        Console.WriteLine($"2 cipari kā koordināte, piemēram 11 vai 23, vai ...");
        Console.WriteLine($"Pirmais skaitlis ir row(sarkans) Otrais skaitlis ir column (zals)");
        string info = Console.ReadLine();
        if (!info.Equals(11) || !info.Equals(12) || !info.Equals(13) || !info.Equals(21) || !info.Equals(22) || !info.Equals(23) || !info.Equals(31) || !info.Equals(32) || !info.Equals(33))
        {
            Console.WriteLine("Incorrect input1");
        }

        int row = int.Parse(info.Substring(0,1));
        int column = int.Parse(info.Substring(1,1));
        if (row < 1 || column < 1|| row > 3 || column >3)
        {
            Console.WriteLine("Incorrect input2");
        }

       //board[row-1, column-1] = player;//user ievadija 11 =(0,0) 22=(1,1)
       

        Move(row, column, player);

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

        movesPlayed++;//skaitam kartas cik nospeletas ja 9 tad ir neizskirts
        if (movesPlayed == 9)
        {
            Console.Clear();
            printBoard(board);
            Console.WriteLine("No one won a game! it's a draw!");
            break;
        }
      
        player = changePlayer(player);

    }
}

void Move(int row, int column,char player)
{
    if (board[row, column] == ' ')
    {
        board[row, column] = player;
    }

    for (int i = 0; i < 3; i++)//check rows
    {
        if (board[i, column] != player)
        {
            break;
        }
        if (i == 2)
        {
            Console.Clear();
            printBoard(board);
            Console.WriteLine($"Player {player} has won the game!");
            break;
        }
    }
    for (int i = 0; i < 3; i++)//check columns
    {
        if (board[row, i] != player)
        {
            break;
        }
        if (i == 2)
        {
            Console.Clear();
            printBoard(board);
            Console.WriteLine($"Player {player} has won the game!");
            break;
        }
    }
}

static char changePlayer(char currentplayer)//mainam speletaju
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

void printStartBoard(char[,] board)//inicializejam laukumu
{
    for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 3; col++)
        {
            board[row, col] = ' ';

        }
    }
}



void printBoard(char[,] board)//izprintejam laukumu
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"    0   1   2  ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"__|___|___|___|");
   
    for (int row = 0; row < 3; row++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{row }");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($" | ");
        for (int col = 0; col < 3; col++)
        {
            Console.Write(board[row, col]);
            Console.Write(" | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void menu()//menu kur lietotajs var izveleties vai vins grib uzspelet speli
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
            printStartBoard(board);
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









