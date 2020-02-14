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
            string message = "How to Play Crazy-Checkers:\n 1. All the pieces can only move diagonally. That is on the black part of the board (highlighted area).\n 2. In the centre of the menu bar, individual pieces will displayed to detrmine players turn.\n 3. Initially, player 1 (Black piece) will start the game and take turns simultaneously.\n 4. Player will only be able to move forward diagonally. Unless it is a king.\n 5. Player can only jump if it's an opponent piece followed with a blank space further.\n 6. If either player piece reaches to the end row of the opponent their piece will change into king.\n 7. King piece will be to move both either backward or forward.\n 8. Everytime an opponent peice is taken, player will receive a point (score).\n 9. When either of the player score a total of 12 points, that player will win.\n10. All the best.";
            MessageBox.Show(message, "Help");
        }
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            formMain.BtnSettings_Click(sender, e);
        }
    }
}
