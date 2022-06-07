using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeEksperiments
    {
        public void runGame()
        {
            string ret = "";
            string retOrig = "";
            int symbol = 0;

            Console.Clear();
            Console.WriteLine("Sveiks, spēlējam, Tavs gājiens.");
            Console.WriteLine("");

            string[] info = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            string[] log = { "x: ", "o: " };

            Human human1 = new Human();
            Human human2 = new Human();
            human1.Name = "X";
            human2.Name = "Y";
            Computer computer = new Computer();
            computer.Name = this.ToString();

            //Human[] user = { human1, human2 };
            string[] user = { "x", "o" };

            int defUser = 1;
            Data.DisplayBoard(info, log);

            for (int i = 0; i < (info.Length) * 2; i++)
            {
                ret = Console.ReadLine();
                retOrig = ret;
                if (ret.ToLower() == "x")
                {
                    Console.WriteLine("Paldies par spēli! Tiekamies citreiz! :)");
                    break;
                }
                ret = Data.CheckAndOrder(ret);

                if (ret.Length == 2)
                {
                    defUser = (defUser + 1) % 2;
                    log[defUser] = log[defUser] + " " + retOrig;
                    info = Data.FillDisplayInfo(info, user[defUser], ret, log);
                }
                if (i == (info.Length * 2 - 1))
                {
                    Console.WriteLine("Paldies! Šoreiz pietiks! Tiekamies citreiz! :)");
                }
            }
            //ILogEksports

            int kurEksportet = (int)Target.ToEmail;
            
            Email email = new Email();
            Printer printer = new Printer();

            List<ILogEksports> loges = new List<ILogEksports>();
            if (kurEksportet == (int)Target.ToEmail)
            {
                loges.Add(email);
            }
            loges.Add(printer);

            foreach (var eksports in loges)
            {
                eksports.export(log[0]);
                eksports.export(log[1]);
            }

        }
    }
}
