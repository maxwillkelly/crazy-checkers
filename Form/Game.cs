using System;
using System.Windows.Forms;

namespace Crazy_Checkers
{

    /*
	 NOTE: The class design has changed so FormMain owns Grid not Game
	*/
    public class Game
    {
        // change turn
        // validate winning move
        // 
        private int playersTurn = 0;
        private bool gameOver = false;

        // Grid Dimensions
        private uint colSize = 8;
        private uint rowSize = 8;

        // Main Grid
        public Grid MainGrid { get; set; }

        // Players
        private Player[] players;

        // Settings
        private int ruleSet;
        private int gridSize;
        private bool sound;

        public Game()
        {
            MainGrid = new Grid(colSize, rowSize);
            MainGrid.BtnEventHandler += processBtn;
            players = new Player[2];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player(colSize, rowSize);
                Console.WriteLine("Player " + (i + 1) + ": " + players[i].Score);
            }
        }

        public void Play()
        {
            if (!gameOver)
            {
                // check if gameOver
                // do this, by checking all valid moves and/or player is out of positions
                if (players[0].Turn())
                {
                    // playersTurn = !playersTurn; 
                }
            }
        }

        // Runs when a position is clicked in the grid
        public void processBtn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string[] btnString = button.Name.Split('_');
            uint col = Convert.ToUInt32(btnString[1]);
            uint row = Convert.ToUInt32(btnString[2]);

            // all valid moves will be highlighted around position

            // check if Button is 0 or 1
            // if Button is same number as playersTurn
            // validate if any of [x-1, y-1], [x+1, y-1], [x+1, y+1], [x-1, y+1] are opposite of playersTurn
            // if so, add these to an array and check if there is a Position with Color = 2 (blank), if so, this move is valid and 
            // can be highlighted

            // this requires:
            // 	- being able to retrieve button color
            // 	- being able to check 4 diagonal spots around button
            // 	- being able to check spots after opposition buttons 


            // Add to this method to specify what happens when a button is clicked

            // Max: I'm gonna work on method to set up an inital grid for the start of a game
        }

        public void SetSettings(ref FormSettings formSettings)
        {
            ruleSet = formSettings.ruleSet;
            gridSize = formSettings.gridSize;
            sound = formSettings.sound;
        }
    }
}
