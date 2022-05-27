namespace TicTacToe
{
    public class Field
    {
        public static void PrintStartBoard(GameBoard b)//inicializejam laukumu
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    b.Board[row, column] = ' ';

                }
            }
        }
        public static void PrintBoard(GameBoard b)//izprintejam laukumu
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"    0   1   2  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"__|___|___|___|");

            for (int row = 0; row < 3; row++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{row}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" | ");
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(b.Board[row, column]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public Position readPosition()
        {

            //Console.WriteLine($"Player{match.player} make your move! Please choose square were to put sign ");
            Console.WriteLine($"2 cipari kā koordināte, piemēram 11 vai 23, vai ...");
            Console.WriteLine($"Pirmais skaitlis ir row(sarkans) Otrais skaitlis ir column (zals)");
            string info = Console.ReadLine();

            int row = int.Parse(info.Substring(0, 1));
            int column = int.Parse(info.Substring(1, 1));
            return new Position(row, column);
        }
    }
}