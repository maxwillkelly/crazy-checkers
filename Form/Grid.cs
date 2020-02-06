using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crazy_Checkers
{
    public class Grid : TableLayoutPanel
    {
        uint colSize = 8;
        uint rowSize = 8;

        Position[,] PositionArray;

        public Grid()
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoSize = true;
            Dock = DockStyle.Fill;
            Name = "grid";
            Location = new Point(0, 50);
            Margin = new Padding(0);
            Size = new Size(512, 512);

            ColumnCount = Convert.ToInt32(colSize);
            RowCount = Convert.ToInt32(rowSize);

            for (int i = 0; i < colSize;i++)
            {
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100/colSize));
            }
            for (int i = 0; i < rowSize; i++)
            {
                RowStyles.Add(new RowStyle(SizeType.Percent, 100/rowSize));
            }
            
            PositionArray = new Position[colSize, rowSize];
            CreateBtnGrid();
        }

        private void CreateBtnGrid()
        {
            for (uint col = 0; col < colSize; col++)
            {
                for (uint row = 0; row < rowSize; row++)
                {
                    // Places button in array
                    Position btn = PositionArray[col, row];
                    // Creates button
                    btn = new Position(col, row);
                    // Adds button to Main form
                    Controls.Add(btn, Convert.ToInt32(col), Convert.ToInt32(row));
                    btn.Click += new EventHandler(BtnClick);
                }
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Console.WriteLine("{0}\n", button.Name);
        }
    }
}
