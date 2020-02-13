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
        private bool[,] ValidMove;
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
            // Checks if the piece is blank
            bool blank = grid.GetPosition(col, row).isBlank();
            bool king = grid.GetPosition(col, row).isKing;
            bool forward = CheckForward(ref grid, ref move, col, row, playerNum, opposition) || king;
            double piecesAway = CheckPiecesAway(ref move, col, row);
            bool pieceTaken = CheckPieceTaken(ref grid, ref move, col, row, playerNum, piecesAway, blank, forward);
            bool standard = blank && forward && piecesAway == Math.Sqrt(2);
            
            // standard and taken
            if (standard || pieceTaken)
            {
                grid.SetSquareColor(col, row, 3);
                return true;
            }
            return false;
        }

        private double CheckPiecesAway(ref Move move, uint col, uint row)
        {
            int xDist = Convert.ToInt32(move.Current.Col) - Convert.ToInt32(col);
            int yDist = Convert.ToInt32(move.Current.Row) - Convert.ToInt32(row);
            double squaredDist = Math.Pow(xDist, 2) + Math.Pow(yDist, 2);
            return Math.Sqrt(squaredDist);
        }

        // Checks if a piece is being taken from another player
        private bool CheckPieceTaken(ref Grid grid, ref Move move, uint col, uint row, uint opposition, double piecesAway, bool blank, bool forward)
        {
            // Things to do:
            // 1. Get the current piece extracted from move
            // 2. Check the distance between the current and the target (col/row) is 8^1/2
            // 3. Calculate taken by getting the average point between current and target
            // 4. Check the distance between current and taken is 2^1/2
            // 5. Check the distance between taken and target is 2^1/2
            // 6. Check that the target is owned by the opposition

            /*
            // Opposition is actually playerNum
            int betweenRow, betweenCol;
            // Flipped
            int moveCol = Convert.ToInt32(move.Current.Row);
            int moveRow = Convert.ToInt32(move.Current.Col);

            for (int i = -1; i <= 1; i += 2)
            {
                for (int j = -1; j <= 1; j += 2)
                {
                    betweenCol = moveCol + i;
                    betweenRow = moveRow + j;
                    // Checks the position we're looking up on on the grid
                    bool inGrid = betweenCol >= 0 && betweenRow >= 0 && betweenCol < Columns && betweenRow < Rows;
                    bool ownedByOpposition = false;
                    bool isCurrent = true;
                    if (inGrid) {
                        ownedByOpposition = grid.GetPosition(Convert.ToUInt32(betweenCol), Convert.ToUInt32(betweenRow)).Color == opposition;
                        //isCurrent = moveCol == betweenCol && moveRow == betweenRow;
                    }
                    // Checks if this meets all the conditions
                    if (inGrid && ownedByOpposition && piecesAway == Math.Sqrt(8) && blank && forward && isCurrent)
                    {
                        Taken[col, row] = new Counter(Convert.ToUInt32(betweenCol), Convert.ToUInt32(betweenRow), opposition);
                        Console.WriteLine("Taken Option:\tCol:{0}\tRow:{1}\tfor Piece:\tCol:{2}\tRow:{3}", betweenCol, betweenRow, col, row);
                        Console.WriteLine("MoveCol: {0}\tMoveRow: {1}",moveCol,moveRow);
                        return true;
                    }
                }
            }*/
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
