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