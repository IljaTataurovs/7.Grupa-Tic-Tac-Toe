using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeVers2
{
    public class TicTacToeV2
    {
        public string[] board64 = { "a", "b", "c", "d", "e", "f", "g", "h", "1", "2", "3", "4", "5", "6", "7", "8" };
        public string[] board49 = { "a", "b", "c", "d", "e", "f", "g", "1", "2", "3", "4", "5", "6", "7"};
        public string[] board25 = { "a", "b", "c", "d", "e", "1", "2", "3", "4", "5"};


        public void runGame(PlayerHuman human1, PlayerHuman human2, string mode)
        {
            SpelesLogika spelesLogika = new SpelesLogika();
            string ret = "";
            string retOrig = "";
            //      int symbol = 0;
            int laucini = 64;

            Console.Clear();
            Console.WriteLine("Sveiks, spēlējam, Tavs gājiens.");
            Console.WriteLine("");
            
            string[] info = new string[laucini];
            for (int i = 0; i < (info.Length); i++)
            {
                info[i] = " ";
            }

            string[] log = { human1.Name + ": ", human2.Name + ": " };
            string[] user = { human1.Name, human2.Name };

            int defUser = 1;

            if (mode == "1")
            {
                spelesLogika.DisplayBoard(info, log, board25);
            }
            else if (mode == "2")
            {
                spelesLogika.DisplayBoard(info, log, board49);
            }
            else if (mode == "3")
            {
                spelesLogika.DisplayBoard(info, log, board64);
            }


            for (int i = 0; i < (info.Length) * 2; i++)
            {
                ret = Console.ReadLine();
                retOrig = ret;
                if (ret.ToLower() == "x")
                {
                    Console.WriteLine("Paldies par spēli! Tiekamies citreiz! :)");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    int kurEksportet = (int)LogToTarget.ToEmail;
                    int j = 0;
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
                        eksports.export(log[j]);
                        j++;
                    }
                    break;
                }

                if (mode == "1")
                {
                    ret = spelesLogika.CheckAndOrder(ret, board25);
                }
                else if (mode == "2")
                {
                    ret = spelesLogika.CheckAndOrder(ret, board49);
                }
                else if (mode == "3")
                {
                    ret = spelesLogika.CheckAndOrder(ret, board64);
                }

                if (ret.Length == 2)
                {
                    defUser = (defUser + 1) % 2;
                    log[defUser] = log[defUser] + " " + retOrig;

                    if (mode == "1")
                    {
                        info = spelesLogika.FillDisplayInfo(info, user[defUser], ret, log, board25);
                    }
                    else if (mode == "2")
                    {
                        info = spelesLogika.FillDisplayInfo(info, user[defUser], ret, log, board49);
                    }
                    else if (mode == "3")
                    {
                        info = spelesLogika.FillDisplayInfo(info, user[defUser], ret, log, board64);
                    }


                }
                if (i == (info.Length * 2 - 1))
                {
                    Console.WriteLine("Paldies! Šoreiz pietiks! Tiekamies citreiz! :)");
                }
            }
            //ILogEksports
/*
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
*/
        }

        public static string CheckAndOrder(string no)
        {
            throw new NotImplementedException();
        }
    }
}
