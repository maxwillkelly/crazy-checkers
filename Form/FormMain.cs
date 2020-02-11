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
            game.Play();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            formAbout.Show();
        }

        public void BtnSettings_Click(object sender, EventArgs e)
        {
            if (formSettings.ShowDialog() == DialogResult.OK)
            {
                game.SetSettings(ref formSettings);
            }
        }

        // Based on a method from Stackoverflow user Chap
        // https://stackoverflow.com/questions/1669318/override-standard-close-x-button-in-a-windows-form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Prevents the game from preventing a Windows Shutdown
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            switch (MessageBox.Show(this, "Are you sure you want to close the game, your progress will be lost?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
    }
}
