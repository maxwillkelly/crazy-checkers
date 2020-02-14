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
        // Dimensions
        private uint Columns = 8;
        private uint Rows = 8;

        // Stores whether a player can move to the appropriate position
        private bool[,] ValidMove;
        // Stores a counter that will be removed from the grid if the player moves to this position
        private Counter[,] Taken;

        // Constructor
        public TactGrid(uint Columns, uint Rows)
        {
            // Initialises global variables
            this.Columns = Columns;
            this.Rows = Rows;
            ValidMove = new bool[Columns, Rows];
            Taken = new Counter[Columns, Rows];
        }

        // Checks if the player can move from any square
        public bool CheckPlayable(ref Grid grid, uint playerNum, uint opposition)
        {
            // Loops through each square in the grid
            for (uint i = 0; i < Columns; i++)
            {
                for (uint j = 0; j < Rows; j++)
                {
                    // Checks if this position is owned by the current player
                    if (grid.GetPosition(i,j).Color == playerNum)
                    {
                        Move m = new Move();
                        m.AddUnit(i, j, playerNum, grid.GetPosition(i, j).King);
                        // Checks if the player can move from this square
                        if (Gen(ref grid, ref m, playerNum, opposition))
                        {
                            // Finds the player can move from a particular square
                            return true;
                        }
                    }
                }
            }
            // Finds the player cannot move from any square
            return false;
        }

        // Returns true if the player can move from the square (col, row)
        public bool Gen(ref Grid grid, ref Move move, uint playerNum, uint opposition)
        {
            // Declares that the player can't play unil proven otherwise
            bool playable = false;
            // Loops through each square in the grid
            for (uint i = 0; i < Columns; i++)
            {
                for (uint j = 0; j < Rows; j++)
                {
                    // Declares the player can't play here unil proven otherwise
                    ValidMove[i, j] = false;
                    // Initialises the taken field
                    Taken[i, j] = new Counter();
                    // Checks if the player can move to this location
                    if (GenValidMove(ref grid, ref move, i, j, playerNum, opposition))
                    {
                        // Proves the player can play
                        playable = true;
                        // Proves the player can play here
                        ValidMove[i, j] = true;
                    }
                }
            }
            return playable;
        }

        // Checks if the player can move to a specific location
        private bool GenValidMove(ref Grid grid, ref Move move, uint col, uint row, uint playerNum, uint opposition)
        {
            // Checks if the player can move forward or take away a piece
            if (CheckStandard(ref grid, ref move, col, row, playerNum, opposition) || CheckPieceTaken(ref grid, ref move, col, row, playerNum, opposition))
            {
                // Highlights the appropriate square to tell the player they can move there
                grid.SetSquareColor(col, row, 3);
                return true;
            }
            return false;
        }

        // Returns the distance between a counter and the position col and row
        private double CheckPiecesAway(Counter c, uint col, uint row)
        {
            // Calculates the distance in each axis
            int xDist = Convert.ToInt32(c.Col) - Convert.ToInt32(col);
            int yDist = Convert.ToInt32(c.Row) - Convert.ToInt32(row);
            // Uses Pythagorus' Theorem to calculate the displacement
            double squaredDist = Math.Pow(xDist, 2) + Math.Pow(yDist, 2);
            return Math.Sqrt(squaredDist);
        }

        // Checks if the player can move forward on a specific location
        private bool CheckStandard(ref Grid grid, ref Move move, uint col, uint row, uint playerNum, uint opposition) {
          // Checks if the target (col, row) is blank
          bool blank = grid.GetPosition(col, row).isBlank();
          // Checks if the piece we are moving is a king
          bool king = move.Current.King;
          // Checks if the player is moving towards their opponent
          bool forward = CheckForward(ref grid, ref move, col, row, playerNum, opposition);
          // 
          double piecesAway = CheckPiecesAway(move.Current, col, row);
          return blank && (forward || king) && piecesAway == Math.Sqrt(2);
        }

        // Checks if a piece is being taken from another player
        private bool CheckPieceTaken(ref Grid grid, ref Move move, uint col, uint row, uint playerNum, uint opposition)
        {
            // Checks the target is blank
            bool blank = grid.GetPosition(col, row).isBlank();
            // Checks we are going forward or the piece is a king
            bool king = move.Current.King;
            bool forward = CheckForward(ref grid, ref move, col, row, playerNum, opposition);
            // Checks the distance between the current and the target (col/row) is 8^1/2
            bool currentTarget = CheckPiecesAway(move.Current, col, row) == Math.Sqrt(8);
            // Calculates the piece we are taking away by getting the average point between current and target
            move.Taken.Col = (col + move.Current.Col)/2;
            move.Taken.Row = (row + move.Current.Row)/2;

            // Checks the distance between current and taken is 2^1/2
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

        // Checks if the player is moving towards their opponent
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
