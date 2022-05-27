using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    public class GameBoard
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        public char[,] Board { get; set; }
        public GameBoard(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            Board = new char[rows, columns];
        }
        public char BoardPosition(Position position)
        {
            return Board[position.row, position.column];
        }

        public char BoardPosition(int rows, int columns)
        {
            return Board[rows, columns];
        }
        //public void PlacePlayerAt( Position position)
        //{
        //    //if (PositionIsInUse(position))
        //    //{
        //    //    throw new BoardException("There is already a player in this position");
        //    //}
        //    Board[position.row, position.column] = Convert.ToChar(match.player);
        //    match.player.position = position;
        //}
    }
}

