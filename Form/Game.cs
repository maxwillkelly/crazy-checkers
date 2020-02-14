using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Crazy_Checkers
{
    public class Game
    {
        // Stores the player taking the turn
        private Player CurrentPlayer = null;

        // Grid Dimensions
        private uint colSize = 8;
        private uint rowSize = 8;

        // Main Grid
        public Grid MainGrid;

        // Players
        private Player[] players;

        // Settings
        private bool sound;

        // Storage
        private Move trailMove;

        // Event Handlers
        public event EventHandler ScoreEventHandler;
        public event EventHandler TurnChangeEventHandler;

        // Constructor
        public Game()
        {
            // Sets the settings to defaults
            sound = true;
            ResetGame();
        }

        // Basically the constructor except for default settings
        public void ResetGame()
        {
            // Creates the main grid to store each position
            MainGrid = new Grid(colSize, rowSize);
            // Adds an event handler which runs each time a position is clicked
            MainGrid.BtnEventHandler += ProcessBtn;
            // Creates two players
            players = new Player[2];
            // Initialises each player
            for (uint i = 0; i < 2; i++)
            {
                players[i] = new Player(colSize, rowSize, Convert.ToUInt32(i));
            }
            // Sets the current player to 0
            CurrentPlayer = players[0];
            trailMove = new Move();
        }


        public void Play()
        {
            // Swaps out the current player
            if (CurrentPlayer.playerNum == 0)
            {
                CurrentPlayer = players[1];
            }
            else
            {
                CurrentPlayer = players[0];
            }
            // Placeholder Event Arguments
            EventArgs e = new EventArgs();
            // Sets the score in the form
            ScoreEventHandler(players, e);
            // Changes the turn in the form
            TurnChangeEventHandler(CurrentPlayer.playerNum, e);
            // Checks if a player can no longer move
            if (!players[0].GeneratePlayable(ref MainGrid) && !players[1].GeneratePlayable(ref MainGrid)) {
                // Ends the game
                Finish();
            }
        }
        // Ends the game
        public void Finish()
        {
            // Stores information displayed to the player
            string text;
            // Checks if Black won
            if (players[0].Score > players[1].Score) {
                text = "Black";
            }
            // Checks if Red won
            else if (players[0].Score < players[1].Score) {
                text = "Red";
            }
            // Checks if there was a draw
            else {
                text = "Neither of you";
            }
            text += " won the game, Congratulations! Anyways would you play again? (Due to issues, both will just quit the game anyway)";
            if (MessageBox.Show(text, "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Quits the application
                Environment.Exit(0);
            }
            else {
                // Quits the application
                Environment.Exit(0);
            }
        }

        // Runs when a position is clicked in the grid
        public void ProcessBtn(object sender, EventArgs e)
        {
            // Converts the sender to its position type
            Position position = (Position)sender;
            // Extracts information from the position
            uint col = position.Column;
            uint row = position.Row;
            // Gets the position that the player has chosen
            Position chosen = MainGrid.GetPosition(position.Column, position.Row);

            // Checks if we haven't added a current
            if (chosen.Color == CurrentPlayer.playerNum && trailMove.isBlank())
            {
                // Adds the positon we have selected to the trialGrid
                trailMove.AddUnit(col, row, chosen.Color, chosen.King);
                // Determines which moves the player can play with the current piece selected
                CurrentPlayer.GenerateTactGrid(ref MainGrid, ref trailMove);
                // Sets the square colour of the piece we have clicked on to indicate it has been selected
                MainGrid.SetSquareColor(col, row, 2);
            }
            // Checks if the position we have clicked on is a valid move
            else if (CurrentPlayer.GetValidMove(col, row))
            {
                // Will move to the square (col, row) from the current position contained in trailMove
                DoMove(col,row);
            }
            else
            {
                // Resets the trailMove for the next turn
                trailMove.ResetUnit();
                // Gets rid of the selected and possible moves from the board
                MainGrid.ResetSquareColor();
            }
        }

        // Will move to the square (col, row) from the current position contained in trailMove
        public void DoMove(uint col, uint row)
        {
            Counter taken = CurrentPlayer.GetTaken(col, row);
            // Checks if a player has reached the end of the board
            if (row == 0 || row == colSize - 1)
            {
                trailMove.Current.King = true;
            }
            // Checks if the sound is enabled
            if (sound)
            {
                // Plays when a move is taken
                var sound = new SoundPlayer("../../audio/notifyShort.wav");
                // Plays the notification sound
                sound.Play();
            }
            // Removes the counter from its previous position
            MainGrid.SetPosition(trailMove.Current.Col, trailMove.Current.Row, 2, false);
            // Adds the counter in its new position
            MainGrid.SetPosition(col, row, CurrentPlayer.playerNum, trailMove.Current.King);
            if (taken.Used)
            {   // Takes an opponent's piece
                MainGrid.SetPosition(taken.Col, taken.Row, 2, false);
                // Increments the score
                CurrentPlayer.Score++;
                // Sets the score in the form
                ScoreEventHandler(players, new EventArgs());
            }
            else
            {
                // Starts the next turn
                Play();
            }
            // Resets the trailMove for the next turn
            trailMove.ResetUnit();
            // Gets rid of the selected and possible moves from the board
            MainGrid.ResetSquareColor();
        }


        // Extracts the settings from the setting form
        // Commented due to issues reseting the form
        public void SetSettings(ref FormSettings formSettings) {
            /*ruleSet = formSettings.ruleSet;
            colSize = Convert.ToUInt32(Math.Sqrt(formSettings.gridSize));
            rowSize = colSize;
            sound = formSettings.sound;
            ResetGame();*/
        }
    }
}
