using System;
using System.Collections.Generic;

namespace Crazy_Checkers {
	public class Player {
		public uint Score { get; set; }
		private TactGrid tactGrid;
		private Stack<Move> moves;
		
		public Player()
		{
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
	}
}
