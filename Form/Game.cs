using System;
using System.Windows.Forms;

namespace Crazy_Checkers
{

    /*
	 NOTE: The class design has changed so FormMain owns Grid not Game
	*/
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
        private int gridSize;
        private bool sound;

        // Storage
        private Move trailMove;

        // Constructor
        public Game()
        {
            ResetGame();
        }

        public void ResetGame()
        {
            // Creates the main grid to store each position
            MainGrid = new Grid(colSize, rowSize);
            // Adds an event handler which runs each time a position is clicked
            MainGrid.BtnEventHandler += ProcessBtn;
            // Creates two players
            players = new Player[2];
            // Initialises each player
            for (uint i = 0; i < players.Length; i++)
            {
                players[i] = new Player(colSize, rowSize, i);
            }
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
        }

        // Runs when a position is clicked in the grid
        public void ProcessBtn(object sender, EventArgs e)
        {
            // 
            Position position = (Position)sender;
            string[] posString = position.Name.Split('_');
            uint col = Convert.ToUInt32(posString[1]);
            uint row = Convert.ToUInt32(posString[2]);

            Position chosen = MainGrid.GetPosition(position.Column, position.Row);

            /*for (int i = -1; i <= 1; i += 2)
            {
                if (MainGrid.GetPosition(Convert.ToUInt32(position.Column + i), Convert.ToUInt32(position.Row - 1)).Color == CurrentPlayer.opposition)
                {
                    Console.WriteLine("There is an opponent diagonal of chosen position ");
                }
            }*/


            // this requires:
            // 	- being able to check 4 diagonal spots around button
            // 	- being able to check spots after opposition buttons 

            // if opposition = 0 and CurrentPlayer = 1 (op: black, cur: red)
            //      we check row - 1  (column += 1 and column += -1)
            //  else 
            //      we check row + 1 (column += 1 and column += -1)
            // as the direction "forward" flips each turn

            if (!trailMove.AddUnit(col, row, chosen.Color))
            {
                trailMove.ResetUnit();
                MainGrid.ResetSquareColor();
            }
            // Checks if we haven't added a target
            else if (!trailMove.isFull())
            {
                // Determines which moves the player can play with the current piece selected
                CurrentPlayer.GenerateTactGrid(ref MainGrid, ref trailMove);
            }

            // validation to do:
            // - Three categories of validation (Standard forward, standard take, king)
            // - Standard forward:
            // - Check its only 1 position : Target[1] - Current[1] == 1
            // - Check the piece is blank : Target.Color
            // - Check the piece is moving towards the opponent ✅
            // - Standard take:
            // - Check its diagonal
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


        public void SetSettings(ref FormSettings formSettings)
        {
            ruleSet = formSettings.ruleSet;
            colSize = Convert.ToUInt32(Math.Sqrt(formSettings.gridSize));
            rowSize = colSize;
            sound = formSettings.sound;
            ResetGame();
        }

        private void Finish()
        {
            MessageBox.Show("You have finished the game");
            throw new NotImplementedException();
        }
    }
}
