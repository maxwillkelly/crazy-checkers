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
        private FormMain formMain;

        public FormMenu()
        {
            InitializeComponent();
            formMain = new FormMain();
        }

        private void Btn1Player_Click(object sender, EventArgs e)
        {
            Hide();
            formMain.Show();
        }

        private void Btn2Player_Click(object sender, EventArgs e)
        {
            Hide();
            formMain.Show();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            BtnHelp_Click(sender, e);
            //MessageBox.Show("The Load/Save features of Crazy Checkers are not yet implemented");
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            string message = "How to Play:\nAt the top of the screen will be a colour red or black indicating whose turn it is to play.";
            MessageBox.Show(message, "Help");
        }
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            formMain.BtnSettings_Click(sender, e);
        }
    }
}
