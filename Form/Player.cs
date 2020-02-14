using System;
using System.Collections;
using System.Collections.Generic;

namespace Crazy_Checkers {
	public class Player {

		// Player State
		public uint Score { get; set; }
		public uint playerNum { get; set; }
		public uint opposition { get; }

		// Move Validation Variables
		public bool playable { get; set; }
		public TactGrid tactGrid { get; }
		
		// Player Setup
		public Player(uint cols, uint rows, uint playerNum)
		{
			// Setting up new TactGrid
			tactGrid = new TactGrid(cols, rows);

			// initialses player score to 0
			Score = 0;

			playable = true;
			this.playerNum = playerNum;

			// calculates opposition player number
			if (playerNum == 0)
			{
				opposition = 1;
			}
			else
			{
				opposition = 0;
			}
		}

		// Checks if there is a playable piece on the grid, returns true if playable piece exists
    public bool GeneratePlayable(ref Grid grid)
    {
			playable = tactGrid.CheckPlayable(ref grid, playerNum, opposition);
			return playable;
		}

		// generates the TactGrid around the player's counter
		public void GenerateTactGrid(ref Grid grid, ref Move move)
		{
			tactGrid.Gen(ref grid, ref move, playerNum, opposition, true);
		}

		// checks if position is a valid move and returns result
		public bool GetValidMove(uint col, uint row)
		{
			return tactGrid.GetSquare(col, row);
		}

		// returns the Counter reference to Taken
		public Counter GetTaken(uint col, uint row)
		{
			return tactGrid.GetTaken(col, row);
		}
	}
}
