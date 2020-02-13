using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crazy_Checkers
{
    public class Counter
    {
        public uint Col { get; set; }
        public uint Row { get; set; }
        public uint Color { get; set; }
        public bool King { get; set; }
        public bool Used { get; set; }

        public Counter()
        {
            Used = false;
        }

        public Counter(uint col, uint row, uint color, bool king = false, bool used = true)
        {
            Col = col;
            Row = row;
            Color = color;
            King = king;
            Used = used;
        }

        public void printMove()
        {
            Console.WriteLine("Col: {0}\tRow: {1}\tColor: {2}\tKing: {3}\tUsed: {4}", Col, Row, Color, King, Used);
        }
    }
}
