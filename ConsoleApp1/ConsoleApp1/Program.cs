Console.Title = "Tic Tac Toe";
char player = 'X';
char[,] board = new char[4, 4];
int movesPlayed = 0;
menu();


void brainOfGame(char player)
{
    while (true)
    {
        Console.Clear();
        printBoard(board);
        Console.WriteLine($"Player {player} make your move! Please choose square were to put {player} sign");
        Console.WriteLine("Please choose a row ");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Please choose a column ");
        int column = int.Parse(Console.ReadLine());
        board[row, column] = player;

        if (player == board[1, 1] && player == board[1, 2] && player == board[1, 3])//parbaudam var ir vinnejs
        {
            Console.WriteLine($"Player {player} has won the game!");
            break;
        }

        movesPlayed++;//skaitam kartas cik nospeletas ja 9 tad ir neizskirts
        if (movesPlayed == 9)
        {
            Console.WriteLine("No one won a game! it's a draw!");//pp
            break;
        }
        player = changePlayer(player);

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
    for (int row = 1; row < 4; row++)
    {
        for (int col = 1; col < 4; col++)
        {
            board[row, col] = ' ';

        }
    }
}



void printBoard(char[,] board)//izprintejam laukumu
{
    Console.WriteLine($"__|_1_|_2_|_3_|");
    for (int row = 1; row < 4; row++)
    {
        Console.Write($"{row} | ");
        for (int col = 1; col < 4; col++)
        {
            Console.Write(board[row, col]);
            Console.Write(" | ");
        }
        Console.WriteLine();
    }

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









