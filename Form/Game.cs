using System;
using System.Windows.Forms;

namespace Crazy_Checkers {

	/*
	 NOTE: The class design has changed so FormMain owns Grid not Game
	*/
	public class Game {
		// change turn
		// validate winning move
		// 
		private bool playersTurn = false;
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

		public void Play() {
			if (!gameOver) {
				// check if gameOver
				// do this, by checking all valid moves and/or player is out of positions
				if (players[0].Turn()) {
					playersTurn = !playersTurn; 
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

			// Add to this method to specify what happens when a button is clicked
		}

		public void SetSettings(ref FormSettings formSettings)
		{
			ruleSet = formSettings.ruleSet;
			gridSize = formSettings.gridSize;
			sound = formSettings.sound;
		}
	}
}
