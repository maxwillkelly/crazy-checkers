using System;
using System.Collections.Generic;

namespace Crazy_Checkers {
	public class Player {
		public uint Score { get; set; }
		private TactGrid tactGrid;
		private Stack<Move> moves;
		
		public Player(uint cols, uint rows)
		{
			tactGrid = new TactGrid(cols, rows);
			Score = 10;
		}

		public bool Turn() {
			// don't need to check if any moves left as this is done before calling method
			// get chosen move (current, target)
			// validateMove
			// until validateMove is true, keep getting chosen move (current, target)
			// then -----> return true
			return true;
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
