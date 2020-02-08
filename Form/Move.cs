using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crazy_Checkers
{
    public class Move
    {
        private Position Current { get; set; }
        private Position Target { get; set; }
        private Position Taken { get; set; }

        public Position BlackPosition { get; set; }
        public Position RedPosition { get; set; }

        public Move()
        {
            this.BlackPosition = null;
            this.RedPosition = null;
        }

        public Move(Position BlackPosition, Position RedPosition)
        {
            this.BlackPosition = BlackPosition;
            this.RedPosition = RedPosition;
        }

        public int ProcessMove(ref Position Current, ref Position Target)
        {
            throw new System.Exception("Not implemented");
        }

        public bool GetNeighbour(uint color)
        {
            if (color == 0)
            {
                if ((BlackPosition.Row - 1 == RedPosition.Row) && (BlackPosition.Column - 1 == RedPosition.Column))
                    return true;

                else if ((BlackPosition.Row - 1 == RedPosition.Row) && (BlackPosition.Column + 1 == RedPosition.Column))
                    return true;
            }

            else if (color == 1)
            {
                if ((BlackPosition.Row + 1 == RedPosition.Row) && (BlackPosition.Column - 1 == RedPosition.Column))
                    return true;

                else if ((BlackPosition.Row + 1 == RedPosition.Row) && (BlackPosition.Column + 1 == RedPosition.Column))
                    return true;
            }

            else if (color == 2)
            {
                if ((BlackPosition.Row - 1 == RedPosition.Row) && (BlackPosition.Column - 1 == RedPosition.Column))
                    return true;

                else if ((BlackPosition.Row - 1 == RedPosition.Row) && (BlackPosition.Column + 1 == RedPosition.Column))
                    return true;

                else if ((BlackPosition.Row + 1 == RedPosition.Row) && (BlackPosition.Column - 1 == RedPosition.Column))
                    return true;

                else if ((BlackPosition.Row + 1 == RedPosition.Row) && (BlackPosition.Column + 1 == RedPosition.Column))
                    return true;
            }

            return false;
        }

        public Position CheckMove(uint color)
        {
            if (color == 0)
            {
                if ((BlackPosition.Row - 2 == RedPosition.Row) && (BlackPosition.Column - 2 == RedPosition.Column))
                    return new Position(BlackPosition.Row - 1, BlackPosition.Column - 1, color);

                else if ((BlackPosition.Row - 2 == RedPosition.Row) && (BlackPosition.Column + 2 == RedPosition.Column))
                    return new Position(BlackPosition.Row - 1, BlackPosition.Column + 1, color);
            }
            
            else if (color == 1)
            {
                if ((BlackPosition.Row + 2 == RedPosition.Row) && (BlackPosition.Column - 2 == RedPosition.Column))
                    return new Position(BlackPosition.Row + 1, BlackPosition.Column - 1, color);

                else if ((BlackPosition.Row + 2 == RedPosition.Row) && (BlackPosition.Column + 2 == RedPosition.Column))
                    return new Position(BlackPosition.Row + 1, BlackPosition.Column + 1, color);
            }
            
            else if (color == 2)
            {
                if ((BlackPosition.Row - 2 == RedPosition.Row) && (BlackPosition.Column - 2 == RedPosition.Column))
                    return new Position(BlackPosition.Row - 1, BlackPosition.Column - 1, color);

                else if ((BlackPosition.Row - 2 == RedPosition.Row) && (BlackPosition.Column + 2 == RedPosition.Column))
                    return new Position(BlackPosition.Row - 1, BlackPosition.Column + 1, color);

                else if ((BlackPosition.Row + 2 == RedPosition.Row) && (BlackPosition.Column - 2 == RedPosition.Column))
                    return new Position(BlackPosition.Row + 1, BlackPosition.Column - 1, color);

                else if ((BlackPosition.Row + 2 == RedPosition.Row) && (BlackPosition.Column + 2 == RedPosition.Column))
                    return new Position(BlackPosition.Row + 1, BlackPosition.Column + 1, color);
            }

            return null;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Move move = obj as Move;
            if ((System.Object)move == null)
            {
                return false;
            }

            return BlackPosition.Equals(move.BlackPosition) && RedPosition.Equals(move.RedPosition);
        }
        
        // The method is current outside the class
        public List<Move> checkJumps(uint color)
        {
            List<Move> jumps = new List<Move>();
            for (uint r = 0; r < 8; r++)
            {
                for (uint c = 0; c < 8; c++)
                {
                    if (color == 0)
                    {
                        if (getState(r, c) == 4)
                        {
                            if ((getState(r - 2, c - 2) == 0) && ((getState(r - 1, c - 1) == 1) || (getState(r - 1, c - 1) == 3)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r - 1, c - 2, color)));
                            }

                            else if ((getState(r - 2, c + 2) == 0) && ((getState(r - 1, c + 1) == 1) || (getState(r - 1, c + 1) == 3)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r - 1, c + 2, color)));
                            }

                            else if ((getState(r + 2, c - 2) == 0) && ((getState(r + 1, c - 1) == 1) || (getState(r + 1, c - 1) == 3)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r + 3, c - 2, color)));
                            }

                            else if ((getState(r + 2, c + 2) == 0) && ((getState(r + 1, c + 1) == 1) || (getState(r + 1, c + 1) == 3)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r + 3, c + 2, color)));
                            }
                        }

                        else if (getState(r, c) == 2)
                        {
                            if ((getState(r - 2, c - 2) == 0) && ((getState(r - 1, c - 1) == 1) || (getState(r - 1, c - 1) == 3)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r - 1, c - 2, color)));
                            }

                            else if ((getState(r - 2, c + 2) == 0) && ((getState(r - 1, c + 1) == 1) || (getState(r - 1, c + 1) == 3)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r - 1, c + 2, color)));
                            }
                        }
                    }

                    else if (color == 1)
                    {
                        if (getState(r, c) == 3)
                        {
                            if ((getState(r - 2, c - 2) == 0) && ((getState(r - 1, c - 1) == 2) || (getState(r - 1, c - 1) == 4)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r - 1, c - 2, color)));
                            }

                            else if ((getState(r - 2, c + 2) == 0) && ((getState(r - 1, c + 1) == 2) || (getState(r - 1, c + 1) == 4)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r - 1, c + 2, color)));
                            }

                            else if ((getState(r + 2, c - 2) == 0) && ((getState(r + 1, c - 1) == 2) || (getState(r + 1, c - 1) == 4)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r + 3, c - 2, color)));
                            }

                            else if ((getState(r + 2, c + 2) == 0) && ((getState(r + 1, c + 1) == 2) || (getState(r + 1, c + 1) == 4)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r + 3, c + 2, color)));
                            }
                        }

                        else if (getState(r, c) == 1)
                        {
                            if ((getState(r + 2, c - 2) == 0) && ((getState(r + 1, c - 1) == 2) || (getState(r + 1, c - 1) == 4)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r + 3, c - 2, color)));
                            }

                            else if ((getState(r + 2, c + 2) == 0) && ((getState(r + 1, c + 1) == 2) || (getState(r + 1, c + 1) == 4)))
                            {
                                jumps.Add(new Move(new Position(r + 1, c, color), new Position(r + 3, c + 2, color)));
                            }
                        }
                    }
                }
            }  
            
            return jumps;
        }

        public bool setState(uint r, uint c, int state)
        {
            if ((state > 4) || (state < -1))
                return false;

            // board[r, c] = state;
            return true;
        }

        public int getState(uint r, uint c)
        {
            if ((r > 7) || (r < 0) || (c > 7) || (c < 0))
            {
                return -1;
            }

            // what is this condition doing? checking that the piece is still on the board?
            // it's not possible to click off the board

            //return board[r, c];
            return 0;
        }
    }
}
