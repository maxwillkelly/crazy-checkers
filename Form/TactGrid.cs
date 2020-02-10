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

        // Returns true if the player can move
        public bool Gen(ref Grid grid, ref Move move, uint playerNum, uint opposition)
        {
            bool playable = false;
            for (uint i = 0; i < Columns; i++)
            {
                for (uint j = 0; j < Rows; j++)
                {
                    validMove[i, j] = false;
                    if (GenValidMove(ref grid, ref move, i, j, playerNum, opposition))
                    {
                        playable = true;
                    }
                }
            }
            return playable;
        }

        private bool GenValidMove(ref Grid grid, ref Move move, uint col, uint row, uint playerNum, uint opposition)
        {
            // Checks if the piece is blank
            bool blank = grid.GetPosition(col, row).isBlank();
            bool forward = CheckForward(ref move);
            bool pieceTaken = CheckPieceTaken(ref grid, ref move, playerNum, opposition);
            return blank && (forward || pieceTaken);
        }

        // Checks if a piece is being taken from another player
        private bool CheckPieceTaken(ref Grid grid, ref Move move, uint playerNum, uint opposition)
        {
            double xAverage = move.Current[0] - move.Target[0] / 2;
            double yAverage = move.Current[1] - move.Target[1] / 2;

            if (xAverage % 1 == 0 && yAverage % 1 == 0)
            {
                uint x = Convert.ToUInt32(xAverage);
                uint y = Convert.ToUInt32(yAverage);

                if (grid.GetPosition(x, y).Color == opposition)
                {
                    grid.SetPosition(x, y, 2, false);
                    return true;
                }
            }
            return false;
        }

        private bool CheckForward(ref Move move)
        {
            // on same line
            if (move.Current[1] == move.Target[1])
            {
                return false;
            }
            // current is red and target is black
            else if (move.Current[2] == 1 && move.Target[2] == 0)
            {
                if (move.Current[1] > move.Target[1])
                {
                    return true;
                }
            }
            // target is red and current is black
            else if (move.Current[2] == 0 && move.Target[2] == 1)
            {
                if (move.Current[1] < move.Target[1])
                {
                    return true;
                }
            }
            return false;
        }

        private void CheckOppositionAdjacent()
        {

        }

        public bool GetSquare(uint col, uint row)
        {
            return validMove[col, row];
        }

        public void SetSquare(uint col, uint row, bool valid)
        {
            validMove[col, row] = valid;
        }
    }
}
