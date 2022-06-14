using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeVers2
{
    public class TicTacToeV2
    {
        public void runGame(PlayerHuman human1, PlayerHuman human2, string mode)
        {
            SpelesLogika spelesLogika = new SpelesLogika();
            string ret = "";
            string retOrig = "";
      //      int symbol = 0;

            Console.Clear();
            Console.WriteLine("Sveiks, spēlējam, Tavs gājiens.");
            Console.WriteLine("");

            string[] info = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            string[] log = { human1.Name + ": ", human2.Name + ": " };
            string[] user = { human1.Name, human2.Name };

            int defUser = 1;
            spelesLogika.DisplayBoard(info, log);

            for (int i = 0; i < (info.Length) * 2; i++)
            {
                ret = Console.ReadLine();
                retOrig = ret;
                if (ret.ToLower() == "x")
                {
                    Console.WriteLine("Paldies par spēli! Tiekamies citreiz! :)");
                    break;
                }
                ret = spelesLogika.CheckAndOrder(ret);

                if (ret.Length == 2)
                {
                    defUser = (defUser + 1) % 2;
                    log[defUser] = log[defUser] + " " + retOrig;
                    info = spelesLogika.FillDisplayInfo(info, user[defUser], ret, log);
                }
                if (i == (info.Length * 2 - 1))
                {
                    Console.WriteLine("Paldies! Šoreiz pietiks! Tiekamies citreiz! :)");
                }
            }
            //ILogEksports

            int kurEksportet = (int)LogToTarget.ToEmail;
            
            LogToEmail email = new LogToEmail();
            LogToPrinter printer = new LogToPrinter();

            List<ILogEksports> loges = new List<ILogEksports>();
            if (kurEksportet == (int)LogToTarget.ToEmail)
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

        public static string CheckAndOrder(string no)
        {
            throw new NotImplementedException();
        }
    }
}
