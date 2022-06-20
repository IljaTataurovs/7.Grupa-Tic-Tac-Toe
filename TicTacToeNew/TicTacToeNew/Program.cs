namespace TicTacToeNew
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();

            Console.Clear();
            Console.WriteLine("==============Main Menu===============");
            Console.WriteLine("Hello, do you want to play a game?");
            Console.WriteLine("Please make a choise! ");
            Console.WriteLine("======================================");
            Console.WriteLine("1: Yes! Let's play a game! ");
            Console.WriteLine("2: No! Leave me alone! ");
            Console.WriteLine("======================================");
            //Console.ReadKey();

            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.Clear();
                    game.Play();
                    game.PlayAnotherGame();
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
