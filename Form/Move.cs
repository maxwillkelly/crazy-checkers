using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crazy_Checkers
{
    public class Move
    {
        public Counter Current { get; set; }
        public Counter Target { get; set; }
        public Counter Taken { get; set; }

        public Move()
        {
            ResetUnit();
        }

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

        public bool isAlmostFull()
        {
            if (Current.Used == true && Target.Used == true)
            {
                return true;
            }
            return false;
        }

        public bool isBlank()
        {
            if (Current.Used == false)
            {
                return true;
            }
            return false;
        }

        public bool useTaken()
        {
            if (Taken.Used == true)
            {
                return true;
            }
            return false;
        }
        public void ResetUnit()
        {
            Current = new Counter();
            Target = new Counter();
            Taken = new Counter();
        }

        public void printMove()
        {
            Console.Write("Current:\t");
            Current.printMove();
            Console.Write("Target:\t");
            Target.printMove();
            Console.Write("Taken:\t");
            Taken.printMove();

        }
    }
}
