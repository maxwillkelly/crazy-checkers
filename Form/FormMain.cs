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
            // SuspendLayout();
            InitializeComponent();
            CreateBtnGrid();
        }

        private void CreateBtnGrid()
        {
            uint colSize = 8;
            uint rowSize = 8;
            uint colLength = 50;
            uint rowLength = 50;

            Button[,] BtnArray = new Button[colSize, rowSize];
            // TableLayoutPanel grid = new TableLayoutPanel();
            // Adds Grid to Main form
            // Controls.Add(grid);
            // grid.SuspendLayout();
            // grid.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right);
            // grid.Dock = DockStyle.Fill;
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
                    // Calculates and sets button location
                    // int colLocation = Convert.ToInt32(colLength * col);
                    // int rowLocation = Convert.ToInt32(rowLength * row);
                    // btn.Location = new Point(colLocation, rowLocation);
                    // Names button based on location
                    btn.Name = "Btn_" + col + "_" + row;
                    btn.Anchor = AnchorStyles.Right;
                    btn.AutoSize = true;
                    btn.Size = new Size(Convert.ToInt32(colLength), Convert.ToInt32(rowLength));
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
