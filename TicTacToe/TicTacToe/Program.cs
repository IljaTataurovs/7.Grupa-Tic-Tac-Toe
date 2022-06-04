
using TicTacToe;

Console.Title = "Tic Tac Toe";


Field field = new Field();
Match match = new Match();

Console.Clear();
Console.WriteLine("==============Main Menu===============");
Console.WriteLine("Hello, do you want to play a game?");
Console.WriteLine("Please make a choice! ");
Console.WriteLine("======================================");
Console.WriteLine("1: Yes! Let's play a game! ");
Console.WriteLine("2: No! Leave me alone! ");
Console.WriteLine("3: Eksperiments ");
Console.WriteLine("======================================");

string userChoice = Console.ReadLine();

switch (userChoice)
   {
     case "1":
        Console.Clear();
        Field.PrintStartBoard(match.board);
        //Match.StartGame();
        Field.PrintBoard(match.board);
        // Console.WriteLine($"Waiting for player{match.player}");
        Position position = field.readPosition();
        // match.makeMove(position)
        //StartGame(player);
        break;
    case "2":
        Console.WriteLine("See you next time!");
        break;
    case "3":
        break;
    default:
        Console.WriteLine("Incorrect option...press any key");
        Console.ReadKey();
        break;
    }

if (userChoice == "3")  //papildinājums testa nolūkiem
{
    TicTacToeEksperiments ttte = new TicTacToeEksperiments();
    ttte.runGame();
}