using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Checkers
{
    // Stores temporarily a counter during data processing
    public class Counter
    {
        // Dimensions
        public uint Col { get; set; }
        public uint Row { get; set; }
        // Ownership
        public uint Color { get; set; }
        public bool King { get; set; }
        // Whether this counter stores anything
        public bool Used { get; set; }

        // Creates a blank counter
        public Counter()
        {
            Used = false;
        }

        // Creates a counter with data
        public Counter(uint col, uint row, uint color, bool king = false, bool used = true)
        {
            Col = col;
            Row = row;
            Color = color;
            King = king;
            Used = used;
        }

        // Prints a counter
        public void printCounter()
        {
            Console.WriteLine("Col: {0}\tRow: {1}\tColor: {2}\tKing: {3}\tUsed: {4}", Col, Row, Color, King, Used);
        }
    }
}
