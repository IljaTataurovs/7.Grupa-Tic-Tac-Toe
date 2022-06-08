using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeVers2
{
    public class LogToPrinter : ILogEksports
    {
        public void export(string info)
        {
            //izdrukāt
            Console.WriteLine("Dati izdrukāti uz A4 lapas! :)");
        }
        public void setPrinter(string printerName)
        {
            //iestādīt printeri
        }
    }
}
