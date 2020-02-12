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
            bool forward = CheckForward(ref grid, ref move, col, row, playerNum, opposition);
            double piecesAway = CheckPiecesAway(ref move, col, row);
            bool pieceTaken = CheckPieceTaken(ref grid, ref move, opposition);
            bool standard = blank && forward && piecesAway == Math.Sqrt(2);
            bool taken = piecesAway == Math.Sqrt(8) && pieceTaken && blank && forward;
            bool king = grid.GetPosition(col, row).isKing;
            // standard and taken
            if (standard || taken)
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
        private bool CheckPieceTaken(ref Grid grid, ref Move move, uint opposition)
        {
            // check that counter between move.Current move.Target is .Color == opposition
            uint averageRow = (move.Current.Row + move.Target.Row) / 2;
            uint averageCol = (move.Current.Col + move.Target.Col) / 2;
            //return grid.GetPosition(averageCol, averageRow);

            int betweenRow, betweenCol;
            int moveCol = Convert.ToInt32(move.Current.Col);
            int moveRow = Convert.ToInt32(move.Current.Row);

            for (int i = -1; i < 1; i += 2)
            {
                for (int j = -1; j < 1; j += 2)
                {
                    betweenCol = moveCol + i;
                    betweenRow = moveRow + j;

                    // Checks the position we're looking up is correct
                    if (betweenCol >= 0 && betweenRow >= 0 && betweenCol < Columns && betweenRow < Rows) {
                        // Checks piece to be taken is owned by the opposition
                        if (grid.GetPosition(Convert.ToUInt32(betweenCol), Convert.ToUInt32(betweenRow)).Color == opposition) {
                            Taken[move.Current.Col, move.Current.Row] = new Counter(Convert.ToUInt32(betweenCol), Convert.ToUInt32(betweenRow), opposition);
                            return true;
                        }
                    }
                    
                    // if (betweenCol >= 0 && betweenRow >= 0 && betweenCol < Columns && betweenRow < Rows)
                    // {
                    //     if (moveCol == (moveCol + (i / 2)) && moveRow == moveRow + (j / 2)) 
                    //     {
                    //         if (grid.GetPosition(Convert.ToUInt32(betweenCol), Convert.ToUInt32(betweenRow)).Color == opposition)
                    //         {
                    //             Taken[move.Current.Col, move.Current.Row] = new Counter(Convert.ToUInt32(betweenCol), Convert.ToUInt32(betweenRow), opposition);
                    //             Console.WriteLine("[" + betweenCol + "," + betweenRow + "] : " + grid.GetPosition(Convert.ToUInt32(betweenCol), Convert.ToUInt32(betweenRow)).Color);
                    //             return true;
                    //         }
                    //     }
                    //}
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
