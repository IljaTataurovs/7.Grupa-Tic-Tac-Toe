using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeVers2
{
    public class TicTacToeV2
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

            PlayerHuman human1 = new PlayerHuman();
            PlayerHuman human2 = new PlayerHuman();
            human1.Name = "X";
            human2.Name = "Y";
            PlayerComputer computer = new PlayerComputer();
            computer.Name = this.ToString();

            //Human[] user = { human1, human2 };
            string[] user = { "x", "o" };

            int defUser = 1;
            SpelesLaukums.DisplayBoard(info, log);

            for (int i = 0; i < (info.Length) * 2; i++)
            {
                ret = Console.ReadLine();
                retOrig = ret;
                if (ret.ToLower() == "x")
                {
                    Console.WriteLine("Paldies par spēli! Tiekamies citreiz! :)");
                    break;
                }
                ret = SpelesLaukums.CheckAndOrder(ret);

                if (ret.Length == 2)
                {
                    defUser = (defUser + 1) % 2;
                    log[defUser] = log[defUser] + " " + retOrig;
                    info = SpelesLaukums.FillDisplayInfo(info, user[defUser], ret, log);
                }
                if (i == (info.Length * 2 - 1))
                {
                    Console.WriteLine("Paldies! Šoreiz pietiks! Tiekamies citreiz! :)");
                }
            }
            //ILogEksports

            int kurEksportet = (int)Target.ToEmail;
            
            LogToEmail email = new LogToEmail();
            LogToPrinter printer = new LogToPrinter();

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
