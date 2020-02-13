using System;
using System.Media;
using System.Windows.Forms;

namespace Crazy_Checkers
{
    public class Game
    {
        // Max: Instead of playersTurn and opposition I've set it to store the current player playing
        // Max: You can access playerNum and opposition in the CurrentPlayer object
        private Player CurrentPlayer = null;

        // Grid Dimensions
        private uint colSize = 8;
        private uint rowSize = 8;

        // Main Grid
        public Grid MainGrid;

        // Players
        private Player[] players;

        // Settings
        private int ruleSet;
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
            ruleSet = 0;
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
                players[i] = new Player(colSize, rowSize, Convert.ToUInt32(i), true);
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
            EventArgs e = new EventArgs();
            ScoreEventHandler(players, e);
            TurnChangeEventHandler(CurrentPlayer.playerNum, e);
            if (players[0].Score == 12 || players[1].Score == 12) {
                Finish();
            }
        }

        public void Finish()
        {
            if (players[0].Score > players[1].Score) {
                MessageBox.Show("So Black Player won apparently, Red Player's dad won't be happy!");
            }
            else if (players[0].Score < players[1].Score) {
                MessageBox.Show("So Red Player won apparently, Black Player's dad won't be happy!");
            }
            else {
                MessageBox.Show("You tied so you both lost in my playbook anyway! Daddy won't be happy.");
            }
        }

        // Runs when a position is clicked in the grid
        public void ProcessBtn(object sender, EventArgs e)
        {
            // 
            Position position = (Position)sender;
            uint col = position.Column;
            uint row = position.Row;
            bool king = position.King;

            Position chosen = MainGrid.GetPosition(position.Column, position.Row);

                // this requires:
                // 	- being able to check 4 diagonal spots around button
                // 	- being able to check spots after opposition buttons 

                // if opposition = 0 and CurrentPlayer = 1 (op: black, cur: red)
                //      we check row - 1  (column += 1 and column += -1)
                //  else 
                //      we check row + 1 (column += 1 and column += -1)
                // as the direction "forward" flips each turn


            // Checks if we haven't added a current
            if (chosen.Color == CurrentPlayer.playerNum && trailMove.isBlank())
            {
                // Adds the positon we have selected to the trialGrid
                trailMove.AddUnit(col, row, chosen.Color);
                // Determines which moves the player can play with the current piece selected
                CurrentPlayer.GenerateTactGrid(ref MainGrid, ref trailMove);
                // Sets the square colour of the piece we have clicked on to indicate it has been selected
                MainGrid.SetSquareColor(col, row, 2);
            }
            // Checks if the position we have clicked on is a valid move
            else if (CurrentPlayer.GetValidMove(col, row))
            {
                Counter taken = CurrentPlayer.GetTaken(col, row);
                // Checks if a piece is needs to be taken
                if (taken.Used)
                {
                    // trailMove.printMove();
                    // Takes an opponent's piece
                    MainGrid.SetPosition(taken.Col, taken.Row, 2, taken.King);
                    CurrentPlayer.Score++;
                }
                if (row == 0 || row == colSize - 1)
                {
                    trailMove.Current.King = true;
                }
                // Checks if the sound is enabled
                if (sound) {
                    // Plays when a move is taken
                    var sound = new SoundPlayer("../../audio/notifyShort.wav");
                    // Plays the notification sound
                    sound.Play();
                }
                // Removes the counter from its previous position
                MainGrid.SetPosition(trailMove.Current.Col, trailMove.Current.Row, 2, false);
                // Adds the counter in its new position
                MainGrid.SetPosition(col, row, CurrentPlayer.playerNum, trailMove.Current.King);
                trailMove.ResetUnit();
                MainGrid.ResetSquareColor();
                Play();
            }
            else
            {
                trailMove.ResetUnit();
                MainGrid.ResetSquareColor();
            }

            // validation to do:
            // - Three categories of validation (Standard forward, standard take, king)
            // - Standard forward:
            // - Check its only 1 position : Target[1] - Current[1] == 1 ✅
            // - Check the piece is blank : Target.Color ✅
            // - Check the piece is moving towards the opponent ✅
            // - Standard take:
            // - Check its diagonal ✅
            // - Check the target is two pieces away
            // - Check an opponent player is between current and taken ✅
            // - King:
            // - Check if position is at end of board (turn into King) : Position.King = True
            // - Check diagonal positions behind and in front


            // now we need to determine how we check if:
            // 1. position isKing - Position.King
            // 2. moving forward - if (Position.Target[1] > Positon.Current[1]) or if (Position.Target[1] < Positon.Current[1]) 
            // 3. taking a piece - CheckPieceTaken() in TactGrid
        }

        public bool AI()
        {
            bool playable = false;
            for (uint i = 0; i < colSize; i++)
            {
                for (uint j = 0; j < rowSize; j++)
                {
                    if (MainGrid.GetPosition(i, j).Color == CurrentPlayer.playerNum)
                    {

                    }
                }
            }
            return playable;
        }

        public void SetSettings(ref FormSettings formSettings) {
            ruleSet = formSettings.ruleSet;
            colSize = Convert.ToUInt32(Math.Sqrt(formSettings.gridSize));
            rowSize = colSize;
            sound = formSettings.sound;
            ResetGame();
        }
    }
}
