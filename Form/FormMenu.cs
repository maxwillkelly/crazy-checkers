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
        private Game game;

        public FormMenu()
        {
            InitializeComponent();
            game = new Game();
        }

        private void Btn1Player_Click(object sender, EventArgs e)
        {
            Hide();
            game.Play();
            Show();
        }

        private void Btn2Player_Click(object sender, EventArgs e)
        {
            Hide();
            game.Play();
            Show();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Load/Save features of Crazy Checkers are not yet implemented");
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Hide();
            game.ShowSettings();
            Show();
        }
    }
}
