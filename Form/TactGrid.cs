using System;
// Can you type?
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
        private bool[,] ValidMove;
        // Stores counter than need to be taken
        private Counter[,] Taken;

        public TactGrid(uint Columns, uint Rows)
        {
            this.Columns = Columns;
            this.Rows = Rows;
            ValidMove = new bool[Columns, Rows];
            Taken = new Counter[Columns, Rows];
        }

        // Returns true if the player can move
        public bool Gen(ref Grid grid, ref Move move, uint playerNum, uint opposition)
        {
            bool playable = false;
            for (uint i = 0; i < Columns; i++)
            {
                for (uint j = 0; j < Rows; j++)
                {
                    ValidMove[i, j] = false;
                    Taken[i, j] = new Counter();
                    if (GenValidMove(ref grid, ref move, i, j, playerNum, opposition))
                    {
                        playable = true;
                        ValidMove[i, j] = true;
                    }
                }
            }
            return playable;
        }

        private bool GenValidMove(ref Grid grid, ref Move move, uint col, uint row, uint playerNum, uint opposition)
        {
            // standard and taken
            if (CheckStandard(ref grid, ref move, col, row, playerNum, opposition) || CheckPieceTaken(ref grid, ref move, col, row, playerNum, opposition))
            {
                grid.SetSquareColor(col, row, 3);
                return true;
            }
            return false;
        }

        private double CheckPiecesAway(Counter c, uint col, uint row)
        {
            int xDist = Convert.ToInt32(c.Col) - Convert.ToInt32(col);
            int yDist = Convert.ToInt32(c.Row) - Convert.ToInt32(row);
            double squaredDist = Math.Pow(xDist, 2) + Math.Pow(yDist, 2);
            return Math.Sqrt(squaredDist);
        }

        private bool CheckStandard(ref Grid grid, ref Move move, uint col, uint row, uint playerNum, uint opposition) {
          // Checks if the piece is blank
          bool blank = grid.GetPosition(col, row).isBlank();
          // 2. Check we are going forward or the piece is a king
          bool king = grid.GetPosition(move.Current.Col, move.Current.Col).King;
          bool forward = CheckForward(ref grid, ref move, col, row, playerNum, opposition);
          double piecesAway = CheckPiecesAway(move.Current, col, row);
          return blank && (forward || king) && piecesAway == Math.Sqrt(2);
        }

        // Checks if a piece is being taken from another player
        private bool CheckPieceTaken(ref Grid grid, ref Move move, uint col, uint row, uint playerNum, uint opposition)
        {
            if (col == 1 && row == 2)
            {
                Console.WriteLine("Dog");
            }
            // Things to do:
            // 1. Check the target is blank
            bool blank = grid.GetPosition(col, row).isBlank();
            // 2. Check we are going forward or the piece is a king
            bool king = grid.GetPosition(move.Current.Col, move.Current.Col).King;
            bool forward = CheckForward(ref grid, ref move, col, row, playerNum, opposition);
            // 3. Check the distance between the current and the target (col/row) is 8^1/2
            bool currentTarget = CheckPiecesAway(move.Current, col, row) == Math.Sqrt(8);
            // 4. Calculate taken by getting the average point between current and target
            move.Taken.Col = (col + move.Current.Col)/2;
            move.Taken.Row = (row + move.Current.Row)/2;

            // 5. Check the distance between current and taken is 2^1/2
            if (move.Taken.Col >= 0 && move.Taken.Col < Columns && move.Taken.Row >= 0 && move.Taken.Row < Rows) {
                bool currentTaken = CheckPiecesAway(move.Current, move.Taken.Col, move.Taken.Row) == Math.Sqrt(2);
                // 6. Check the distance between taken and target is 2^1/2
                bool takenTarget = CheckPiecesAway(move.Taken, col, row) == Math.Sqrt(2);
                // 7. Check that taken is owned by the opposition
                bool ownedByOpposition = grid.GetPosition(move.Taken.Col, move.Taken.Row).Color == opposition;
                if (blank && (forward || king) && currentTarget && currentTaken && takenTarget && ownedByOpposition)
                {
                    Taken[col, row] = new Counter(Convert.ToUInt32(move.Taken.Col), Convert.ToUInt32(move.Taken.Row), opposition);
                    return true;
                }
            }
            return false;
        }

        private bool CheckForward(ref Grid grid, ref Move move, uint col, uint row, uint playerNum, uint opposition)
        {
            if (playerNum == 0)
            {
                if (move.Current.Row < row)
                {
                    return true;
                }
            }
            else if (playerNum == 1)
            {
                if (move.Current.Row > row)
                {
                    return true;
                }
            }
            return false;
        }

        public bool GetSquare(uint col, uint row)
        {
            return ValidMove[col, row];
        }

        public void SetSquare(uint col, uint row, bool valid)
        {
            ValidMove[col, row] = valid;
        }

        public Counter GetTaken(uint col, uint row)
        {
            return Taken[col, row];
        }
    }
}
