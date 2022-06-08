using TicTacToeVers2;

Console.Title = "Tic Tac Toe";

Console.Clear();
Console.WriteLine("==============Main Menu===============");
Console.WriteLine("Sveiks, vai spēlējam?");
Console.WriteLine("Lūdzu izvēlies!");
Console.WriteLine("======================================");
Console.WriteLine("1: Spēlējam! ");
Console.WriteLine("2: Nē!");
Console.WriteLine("======================================");

string userChoice = Console.ReadLine();

switch (userChoice)
{
    case "1":
        TicTacToeV2 ttte = new TicTacToeV2();
        ttte.runGame();
        break;
    case "2":
        Console.WriteLine("See you next time!");
        break;
    default:
        Console.WriteLine("Incorrect option...press any key");
        Console.ReadKey();
        break;
}
