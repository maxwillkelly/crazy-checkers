using System;
using System.Collections.Generic;
using System.Drawing;
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
        public bool isKing { get; set; }
        // 0 indicates black, 1 indicates red, 2 indicates blank
        public uint Color { get { return _Color; } set { _Color = value; ColorChanged(); } }
        private uint _Color;
        public uint SquareColor { get { return _SquareColor; } set { _SquareColor = value; SquareColorChanged(); } }
        private uint _SquareColor;
        public bool Highlight { get { return _Highlight; } set { _Highlight = value; HighlightChanged(); } }
        private bool _Highlight;

        public Position(uint col, uint row, uint color)
        {
            Column = col;
            Row = row;
            MakeButton();
            Color = color;
            isKing = false;
            // Names button based on location
            Name = "Btn_" + col + "_" + row;
        }

        private void MakeButton()
        {
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.White;
            Dock = DockStyle.Fill;
            //FlatStyle = FlatStyle.System;
            Font = new Font(Font.FontFamily, 36);
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            TabIndex = 0;
            //UseVisualStyleBackColor = true;
        }

        private void ColorChanged()
        {
            switch(Color)
            {
                case 0:
                    Text = "⬤";
                    ForeColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    Text = "⬤";
                    ForeColor = System.Drawing.Color.Black;
                    break;
                case 2:
                    Text = "";
                    break;
                default:
                    throw new Exception("The color has attempted to be changed to an invalid value");
            }
        }

        private void SquareColorChanged()
        {
            switch(SquareColor)
            {
                case 0:
                    BackColor = System.Drawing.Color.White;
                    break;
                case 1:
                    BackColor = System.Drawing.Color.Gray;
                    break;
                default:
                    throw new Exception("The color has attempted to be changed to an invalid value");
            }
        }

        private void HighlightChanged()
        {
            switch (Highlight)
            {
                case true:
                    BackColor = System.Drawing.Color.Yellow;
                    break;
                case false:
                    // BackColor = System.Drawing.Color.Yellow;
                    break;
            }
        }

        public bool isBlack()
        {
            if (Color == 0)
            {
                return true;
            }
            return false;
        }
        public bool isRed()
        {
            if (Color == 1)
            {
                return true;
            }
            return false;
        }

        public bool isBlank()
        {
            if (Color == 2)
            {
                return true;
            }
            return false;
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