using TicTacToeVers2;

Console.Title = "Tic Tac Toe";

Console.Clear();
Console.WriteLine("==============Main Menu===============");
Console.WriteLine("Sveiks, vai spēlējam?");
Console.WriteLine("Lūdzu izvēlies!");
Console.WriteLine("======================================");
//Console.WriteLine("1: Spēlējam! 3 x 3 laukums");
//Console.WriteLine("2: Spēlējam! 4 x 4 laukums");
Console.WriteLine("3: Spēlējam! 5 x 5 laukums");
Console.WriteLine("4: Nē!");
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
