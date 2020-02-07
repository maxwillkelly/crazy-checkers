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
    public partial class FormMenu : Form
    {
        private uint cols = 4;
        private uint rows = 4;

        public FormMenu()
        {
            InitializeComponent();
            Game game = new Game();
        }
    }
}
