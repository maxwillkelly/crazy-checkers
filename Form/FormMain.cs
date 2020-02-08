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
        Game game;
        FormAbout formAbout;
        FormSettings formSettings;

        public FormMain()
        {
            InitializeComponent();
            game = new Game();
            formAbout = new FormAbout();
            formSettings = new FormSettings();
            TopPanelTable.Controls.Add(game.MainGrid, 0, 1);
        }

        public void StartGame()
        {
            game.Play();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            formAbout.Show();
        }

        public void BtnSettings_Click(object sender, EventArgs e)
        {
            formSettings.Show();
            game.SetSettings(ref formSettings);
        }
    }
}
