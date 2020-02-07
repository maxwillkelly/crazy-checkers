using System;
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

		private FormMain formMain;
		private FormSettings formSettings;
		private FormAbout formAbout;
		private Player[] players;

		public Game()
		{
			// Initalises the forms
			formAbout = new FormAbout();
			formMain = new FormMain();
			formSettings = new FormSettings();

			players = new Player[2];
			for (int i = 0; i < players.Length; i++)
			{
				players[i] = new Player();
				Console.WriteLine("Player " + (i + 1) + ": " + players[i].Score);
			}
		}

		public void Play() {
			// Displays the main form
			formMain.Show();
			// Repeats until the game has finished
			while (!gameOver) {
				// check if gameOver
				// do this, by checking all valid moves and/or player is out of positions
				if (players[0].Turn()) {
					playersTurn = !playersTurn; 
				}
			}
		}

		// Shows the settings form
		public void ShowSettings()
		{
			// Closes the main form
			formMain.Close();
			// Opens the settings form
			formSettings.Show();
		}
	}
}
