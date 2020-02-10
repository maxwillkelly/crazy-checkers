using System;
using System.Collections.Generic;

namespace Crazy_Checkers {
	public class Player {
		public uint Score { get; set; }
		public uint playerNum { get; set; }
		public uint opposition { get; }
		public bool playable { get; set; }
		public TactGrid tactGrid { get; }
		private Stack<Move> moves;
		
		public Player(uint cols, uint rows, uint playerNum)
		{
			tactGrid = new TactGrid(cols, rows);
			Score = 10;
			this.playerNum = playerNum;
			if (playerNum == 0)
			{
				opposition = 1;
			}
			else
			{
				opposition = 0;
			}
		}

		public void GenerateTactGrid(ref Grid grid, ref Move move)
		{
			playable = tactGrid.Gen(ref grid, ref move, playerNum, opposition);
		}

		public bool Turn() {
			// don't need to check if any moves left as this is done before calling method
			// get chosen move (current, target)
			// validateMove
			// until validateMove is true, keep getting chosen move (current, target)
			// then -----> return true
			return true;
		}

		public bool GetValidMove(uint col, uint row)
		{
			return tactGrid.GetSquare(col, row);
		}

		public void pushMove(Move move)
		{
			moves.Push(move);

			// yo, when should we be calling "processMove" or "processValidPositions"
			// there's a method in Game that occurs when a button is clicked
			// Well for ^ yeah I just put it there, it's so the game can do what it wants with this info
			// okay no problem,
		}

		public Move popMove()
		{
			return moves.Pop();
		}
	}
}
