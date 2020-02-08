using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Checkers
{
    public class TactGrid
    {
        private uint Columns = 8;
        private uint Rows = 8;
        private bool[,] validMove;

        public TactGrid()
        {
            validMove = new bool[Columns, Rows];
        }

        public TactGrid(uint Columns, uint Rows)
        {
            this.Columns = Columns;
            this.Rows = Rows;
            validMove = new bool[Columns, Rows];
        }

        public bool getSquare(uint col, uint row)
        {
            return validMove[col, row];
        }

        public void setSquare(uint col, uint row, bool valid)
        {
            validMove[col,row] = valid;
        }
    }
}
