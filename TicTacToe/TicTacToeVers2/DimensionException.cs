using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeVers2
{
    public class DimensionException : Exception
    {
        public DimensionException(string message) : base(message)
        { 
            // ko te darīt?
        }
        public DimensionException(string message, Exception exception) : base(message, exception)
        {

        }

    }
}
