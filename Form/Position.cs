using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crazy_Checkers
{
    public class Position : Button
    {
        public Position() {
            MakeButton();
        }

        public uint Column { get; set; }
        public uint Row { get; set; }
        public uint isKing { get; set; }

        public Position(uint col, uint row)
        {
            Column = col;
            Row = row;
            MakeButton();
            // Names button based on location
            Name = "Btn_" + col + "_" + row;
        }

        private void MakeButton()
        {
            AutoSize = true;
            Dock = DockStyle.Fill;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            TabIndex = 0;
            UseVisualStyleBackColor = true;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Position Position = obj as Position;
            
            if ((System.Object)Position == null)
            {
                return false;
            }

            return Row == Position.Row && Column == Position.Column;
        }
    }
}