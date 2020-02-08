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
		public Grid MainGrid { get; set; }
		private Player[] players;

		public Game()
		{
			MainGrid = new Grid();
			players = new Player[2];
			for (int i = 0; i < players.Length; i++)
			{
				players[i] = new Player();
				Console.WriteLine("Player " + (i + 1) + ": " + players[i].Score);
			}
		}

		public void Play() {
			// Repeats until the game has finished
			/*while (!gameOver) {
				// check if gameOver
				// do this, by checking all valid moves and/or player is out of positions
				if (players[0].Turn()) {
					playersTurn = !playersTurn; 
				}
			}*/
		}

		public void SetSettings(ref FormSettings formSettings)
		{

		}
	}
}
