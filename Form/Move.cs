using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crazy_Checkers
{
    public class Move
    {

        // 3 Pieces to work with in a "Move"
        // Stores the place the player currently sits
        public Counter Current { get; set; }
        // Stores where the player want to move
        public Counter Target { get; set; }
        // Stores a piece taken away from a player
        public Counter Taken { get; set; }

        // Creates a new Move
        public Move()
        {
            ResetUnit();
        }

        // Adds to the appropriate variable similar to a queue so the current position is added first, then target and taken
        // Returns true if a position has been placed
        public bool AddUnit(uint col, uint row, uint color, bool king = false)
        {
            if (Current.Used == false)
            {
                Current = new Counter(col, row, color, king);
            }
            else if (Target.Used == false)
            {
                Target = new Counter(col, row, color, king);
            }
            else if (Taken.Used == false)
            {
                Taken = new Counter(col, row, color, king);
            }
            else
            {
                return false;
            }
            return true;
        }

        // checks if current is blank
        public bool isBlank()
        {
            if (Current.Used == false)
            {
                return true;
            }
            return false;
        }

        // resets the current Move 
        public void ResetUnit()
        {
            Current = new Counter();
            Target = new Counter();
            Taken = new Counter();
        }
    }
}
