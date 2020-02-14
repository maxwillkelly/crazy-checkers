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
        public uint Column { get; set; }
        public uint Row { get; set; }
        public bool King { get { return _King; } set { _King = value; KingChanged(); } }
        private bool _King;
        // 0 indicates black, 1 indicates red, 2 indicates blank
        public uint Color { get { return _Color; } set { _Color = value; ColorChanged(); } }
        private uint _Color;
        public uint SquareColor { get { return _SquareColor; } set { _SquareColor = value; SquareColorChanged(); } }
        private uint _SquareColor;

        // Creates a new Position
        public Position(uint col, uint row, uint color, bool king)
        {
            Column = col;
            Row = row;
            MakeButton();
            Color = color;
            King = king;
            // Names button based on location
            Name = "Btn_" + col + "_" + row;
        }

        // Setting up Button designs
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

        // Sets the icon of piece depending on Color
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
                case 3:
                    Text = "👑";
                    break;
                default:
                    throw new Exception("The color has attempted to be changed to an invalid value");
            }
        }

        // Handles Square Colour being changed
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
                case 2:
                    BackColor = System.Drawing.Color.Blue;
                    break;
                case 3:
                    BackColor = System.Drawing.Color.Yellow;
                    break;
                default:
                    throw new Exception("The color has attempted to be changed to an invalid value");
            }
        }

        // Checks if the King has been changed
        private void KingChanged()
        {
            switch (King)
            {
                case true:
                    Text = "👑";
                    break;
            }
        }
        // checks if Position is blank
        public bool isBlank()
        {
            if (Color == 2)
            {
                return true;
            }
            return false;
        }
    }
}