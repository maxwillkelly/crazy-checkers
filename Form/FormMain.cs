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
        Grid MainGrid;

        public FormMain()
        {
            InitializeComponent();
            MainGrid = new Grid();
            TopPanelTable.Controls.Add(MainGrid, 0, 1);
        }
    }
}
