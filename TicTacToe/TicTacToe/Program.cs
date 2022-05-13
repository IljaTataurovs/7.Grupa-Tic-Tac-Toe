
//Does the console works for you guys? 
Console.Title = "Tic Tac Toe";
Console.Clear();
menu();

void printBoard()
{
    char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    Console.Clear();
    Console.WriteLine($" _________________ ");
    Console.WriteLine($"[     |     |     ]");
    Console.WriteLine($"[  {0}  |  {1}  |  {2}  ]", array[1], array[2], array[3]);
    Console.WriteLine($"[_____|_____|_____]");
    Console.WriteLine($"[     |     |     ]");
    Console.WriteLine($"[  {4}  |  {5}  |  {6}  ]", array[4], array[5], array[6]);
    Console.WriteLine($"[_____|_____|_____]");
    Console.WriteLine($"[     |     |     ]");
    Console.WriteLine($"[  {7}  |  {8}  |  {9}  ]", array[7], array[8], array[9]);
    Console.WriteLine($"[_____|_____|_____]");

}

void menu()
{
    
    Console.Clear();
    Console.WriteLine("================");
    Console.WriteLine("Hello, do you want to play a game?");
    Console.WriteLine("Please make a choise! ");
    Console.WriteLine("1: Yes! Lets play a game! ");
    Console.WriteLine("2: No! Leave me alone! ");
    Console.WriteLine("================");

    int userChoise = int.Parse(Console.ReadLine());
    switch (userChoise)
    {
        case 1:
            Console.Clear();
            printBoard();
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


//One idea on how to create a board.

//int[] board = new int[9];
//board[0] = 1;
//board[1] = 2;
//board[2] = 0;
//board[3] = 0;
//board[4] = 0;
//board[5] = 0;
//board[6] = 0;
//board[7] = 0;
//board[8] = 0;

//for (int i = 0; i < 9; i++)
//{
//   
//    //Print o or x in each square, where X is player1, O player2;
//    if (board[i] == 0)
//    {
//        Console.WriteLine("*");
//    }
//    if (board[i] == 1)
//    {
//        Console.WriteLine("X");
//    }

//    if (board[i] == 2)
//    {
//        Console.WriteLine("O");
//    }

//    //Insert new line at end of second char;
//    if (i == 2 || i == 5 || i == 8)
//    {
//        Console.WriteLine();
//    }
//}







