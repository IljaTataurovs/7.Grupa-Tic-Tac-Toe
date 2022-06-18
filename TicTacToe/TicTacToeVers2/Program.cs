using TicTacToeVers2;

Console.Title = "Tic Tac Toe";

Console.Clear();
Console.WriteLine("==============Main Menu===============");
Console.WriteLine("Sveiks, vai spēlējam?");
Console.WriteLine("Lūdzu izvēlies!");
Console.WriteLine("======================================");
Console.WriteLine("1: Spēlējam! 25 lauciņi, Large");
Console.WriteLine("2: Spēlējam! 49 lauciņi, Extra Large");
Console.WriteLine("3: Spēlējam! 64 lauciņi, Extra Extra Large!");
Console.WriteLine("");
Console.WriteLine("4: Nē!, Aizveram programmu!");
Console.WriteLine("======================================");

string userChoice = Console.ReadLine();

TicTacToeV2 ttte = new TicTacToeV2();
PlayerHuman human1 = new PlayerHuman();
PlayerHuman human2 = new PlayerHuman();

human1.Name = "X";
human2.Name = "O";


switch (userChoice)
{
    case "1":
        ttte.runGame(human1, human2, userChoice);
        break;
    case "2":
        ttte.runGame(human1, human2, userChoice);
        break;
    case "3":
        ttte.runGame(human1, human2, userChoice);
        break;
    case "4":
        Console.WriteLine("See you next time!");
        break;
    case "10":
        PlayerComputer computer = new PlayerComputer();
        computer.Name = Environment.MachineName.ToString(); 

        //..............
        break;
    default:
        Console.WriteLine("Incorrect option...press any key");
        Console.ReadKey();
        break;
}
