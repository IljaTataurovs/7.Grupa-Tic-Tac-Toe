using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeVers2
{
    public class LogToEmail : ILogEksports
    {
        public void export(string info)
        {
            //nosūtīt epastu
            Console.WriteLine("E-Pasts nosūtīts :) ");
        }
        public void setMail(string email, string adresats)
        {
            //iestādīt saņēmēju un epasta adresi
        }
    }
}
