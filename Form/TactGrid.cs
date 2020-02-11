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
                        validMove[i, j] = true;
                    }
                }
            }
            return playable;
        }

        private bool GenValidMove(ref Grid grid, ref Move move, uint col, uint row, uint playerNum, uint opposition)
        {
            // Checks if the piece is blank
            bool blank = grid.GetPosition(col, row).isBlank();
            bool forward = CheckForward(ref grid, ref move, col, row, playerNum, opposition);
            double piecesAway = CheckPiecesAway(ref move, col, row);
            bool pieceTaken = CheckPieceTaken(ref grid, ref move, opposition, piecesAway);
            // standard
            if (blank && (forward && (piecesAway == Math.Sqrt(2)) || pieceTaken))
            {
                grid.SetSquareColor(col, row, 3);
                return true;
            }
            return false;
        }

        private double CheckPiecesAway(ref Move move, uint col, uint row)
        {
            int xDist = Convert.ToInt32(move.Current[0]) - Convert.ToInt32(col);
            int yDist = Convert.ToInt32(move.Current[1]) - Convert.ToInt32(row);
            double squaredDist = Math.Pow(xDist, 2) + Math.Pow(yDist, 2);
            return Math.Sqrt(squaredDist);
        }

        // Checks if a piece is being taken from another player
        private bool CheckPieceTaken(ref Grid grid, ref Move move, uint opposition, double piecesAway)
        {
            double xDist = (Convert.ToInt32(move.Current[0]) - Convert.ToInt32(move.Target[0]));
            double yDist = (Convert.ToInt32(move.Current[1]) - Convert.ToInt32(move.Target[1]));
            Console.WriteLine(xDist + " : " + yDist);
            if (piecesAway == 2 && xDist == 2.0 && yDist == 2.0)
            {
                uint x = Convert.ToUInt32(Math.Abs(xDist));
                uint y = Convert.ToUInt32(Math.Abs(yDist));
                // Math.abs(current[0] - target[0])
                // math.abs(current[1] - target[1])

                if (grid.GetPosition(x, y).Color == opposition)
                {
                    // grid.SetPosition(x, y, 2, false);
                    return true;
                }
            }
            return false;
        }

        private bool CheckForward(ref Grid grid, ref Move move, uint col, uint row, uint playerNum, uint opposition)
        {
            // Column, Row, Color, Used

            if (playerNum == 0)
            {
                if (move.Current[1] < row)
                {
                    return true;
                }
            } 
            else if (playerNum == 1)
            {
                if (move.Current[1] > row)
                {
                    return true;
                }
            }
            return false;
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
