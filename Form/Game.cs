using System;
namespace Crazy_Checkers {
	public class Game {
		private Grid grid;

		// change turn
		// validate winning move
		// 
		private bool playersTurn = false;
		private bool gameOver = false;
		
		private FormSettings formSettings;
		private FormAbout formAbout;
		private Player[] players;

		public void Play() {
			while (!gameOver) {
				// check if gameOver
				// do this, by checking all valid moves and/or player is out of positions
				if (players[0].Turn()) {
					playersTurn = !playersTurn; 
				}
			}
		}
		public Game()
		{
			Grid grid = new Grid();
			players = new Player[2];
			for (int i = 0; i < players.Length; i++)
			{
				players[i] = new Player();		
				Console.WriteLine("Player " + (i + 1) + ": " + players[i].Score);
			}
		}
	}
}
