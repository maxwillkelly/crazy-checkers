using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crazy_Checkers
{
    public class Move
    {
        public uint[] Current { get; set; }
        public uint[] Target { get; set; }

        public Move()
        {
            ResetUnit();
        }

        // Returns true if a position has been placed
        public bool AddUnit(uint col, uint row, uint color)
        {
            if (Current[2] == 0)
            {
                Current = new uint[4] { col, row, color, 1 };
            }
            else if (Target[2] == 0)
            {
                Target = new uint[4] { col, row, color, 1 };
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool isFull()
        {
            if (Current[3] == 1 && Target[3] == 1)
            {
                return true;
            }
            return false;
        }

        public void printMove()
        {
            Console.WriteLine("Current: Col: " + Current[0]);
            Console.WriteLine("         Row: " + Current[1]);
            Console.WriteLine("         Color: " + Current[2]);

            if (Target[2] != 0)
            {
                Console.WriteLine("Target: Col: " + Target[0]);
                Console.WriteLine("         Row: " + Target[1]);
                Console.WriteLine("         Color: " + Target[2]);
            }
        }
        public void ResetUnit()
        {
            Current = new uint[4];
            Target = new uint[4];
        }
    }
}
