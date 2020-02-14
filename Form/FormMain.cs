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
        // Used to launch other forms
        FormAbout formAbout;
        FormSettings formSettings;

        public FormMain()
        {
            InitializeComponent();
            game = new Game();
            // Adds Event Handlers
            game.ScoreEventHandler += SetScore;
            game.TurnChangeEventHandler += SetTurn;
            // Initalises forms
            formAbout = new FormAbout();
            formSettings = new FormSettings();
            // Adds the game's grid onto the Top Panel Table contained in grid
            TopPanelTable.Controls.Add(game.MainGrid, 0, 1);
            // Starts the inital turn
            game.Play();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            // Displays the about form
            formAbout.Show();
        }

        public void BtnSettings_Click(object sender, EventArgs e)
        {
            // Displays the settings form
            formSettings.ShowDialog();
            // Sets the settings in game
            game.SetSettings(ref formSettings);
        }

        // Called by the game to set the scores counters
        public void SetScore(object sender, EventArgs e)
        {
            // Allows the array to be looped through
            var players = sender as IEnumerable<Player>;
            // Loops through each player
            foreach (Player player in players)
            {
                // Sets each player's score
                if (player.playerNum == 1)
                {
                    ScoreBlack.Text = Convert.ToString(player.Score);
                }
                else if (player.playerNum == 0)
                {
                    ScoreRed.Text = Convert.ToString(player.Score);
                }
            }
        }

        // Displays whose turn it is
        public void SetTurn(object sender, EventArgs e)
        {
            // Gets the current player's number
            uint playerNum = (uint)sender;
            // Shows the appropriate turn indicator
            switch (playerNum)
            {
                case 0:
                    blackTurnIndicator.Visible = false;
                    redTurnIndicator.Visible = true;
                    break;
                case 1:
                    blackTurnIndicator.Visible = true;
                    redTurnIndicator.Visible = false;
                    break;
                default:
                    break;
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
                    // Closes the dialog
                    e.Cancel = true;
                    break;
                default:
                    // Quits the application
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
