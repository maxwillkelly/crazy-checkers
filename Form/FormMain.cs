using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crazy_Checkers
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CreateBtnGrid();
        }

        private void CreateBtnGrid()
        {
            uint colSize = 8;
            uint rowSize = 8;

            Button[,] BtnArray = new Button[colSize, rowSize];
            grid.ColumnCount = Convert.ToInt32(colSize);
            grid.RowCount = Convert.ToInt32(rowSize);

            for (uint col = 0; col < colSize; col++)
            {
                for (uint row = 0; row < rowSize; row++)
                {
                    // Places button in array
                    Button btn = BtnArray[col, row];
                    // Creates button
                    btn = new Button();
                    // Adds button to Main form
                    grid.Controls.Add(btn, Convert.ToInt32(col), Convert.ToInt32(row));
                    // Names button based on location
                    btn.Name = "Btn_" + col + "_" + row;
                    btn.AutoSize = true;
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = Padding.Empty;
                    btn.Padding = Padding.Empty;
                    btn.TabIndex = 0;
                    btn.UseVisualStyleBackColor = true;
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
