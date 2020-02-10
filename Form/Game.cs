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
        private bool GameOver = false;
        private int opposition = 1;

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

        // Constructor
        public Game()
        {
            // Creates the main grid to store each position
            MainGrid = new Grid(colSize, rowSize);
            // Adds an event handler which runs each time a position is clicked
            MainGrid.BtnEventHandler += ProcessBtn;
            // Creates two players
            players = new Player[2];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player(colSize, rowSize);
            }
        }

        public void Play()
        {
            if (!GameOver)
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
        public void ProcessBtn(object sender, EventArgs e)
        {
            Position position = (Position) sender;
            string[] posString = position.Name.Split('_');
            uint col = Convert.ToUInt32(posString[1]);
            uint row = Convert.ToUInt32(posString[2]);

            if (playersTurn == 0) {
                opposition = 1;
            } else {
                opposition = 0;
            }

            

            // all valid moves will be highlighted around position

            // check if Button is 0 or 1
            // if Button is same number as playersTurn
            // validate if any of [x-1, y-1], [x+1, y-1], [x+1, y+1], [x-1, y+1] are opposite of playersTurn
            // if so, add these to an array and check if there is a Position with Color = 2 (blank), if so, this move is valid and 
            // can be highlighted
            Console.WriteLine(position.Row + " " + position.Column);

            // Console.WriteLine(MainGrid.GetPosition(position.Column - 1, position.Row + 1));

            Position chosen = MainGrid.GetPosition(position.Column, position.Row);

            for (int i = -1; i <= 1; i+=2) {
                if (MainGrid.GetPosition(Convert.ToUInt32(position.Column + i), Convert.ToUInt32(position.Row - 1)).Color == opposition) {
                    Console.WriteLine("There is an opponent diagonal of chosen position ");
                }
            }

            // this requires:
            // 	- being able to retrieve button color
            // 	- being able to check 4 diagonal spots around button
            // 	- being able to check spots after opposition buttons 


            // Add to this method to specify what happens when a button is clicked

            // Max: I'm gonna work on method to set up and opening grid
            // Ramsay: Are you aware of how I can check the Button's/Position's "settings"? I'm not sure what "sender" refers to
            position.Color = 1;
        }

        public void SetSettings(ref FormSettings formSettings)
        {
            ruleSet = formSettings.ruleSet;
            gridSize = formSettings.gridSize;
            sound = formSettings.sound;
        }
    }
}
