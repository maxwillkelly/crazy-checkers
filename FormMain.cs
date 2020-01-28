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

            for (uint col = 0; col < colSize; col++)
            {
                for (uint row = 0; row < rowSize; row++)
                {
                    Button btn = BtnArray[col, row];
                    btn = new Button();
                    btn.Location = new Point(343, 139);
                    btn.Name = "Btn_" + col + "_" + row;
                    btn.Size = new Size(75, 23);
                    btn.TabIndex = 0;
                    btn.Text = "button1";
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += new EventHandler(BtnClick);
                }
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {

        }
    }
}
