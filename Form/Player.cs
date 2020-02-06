using System;
using System.Collections.Generic;

namespace Crazy_Checkers {
	public class Player {
		private uint score = 10;
		private TactGrid tactGrid;

		public bool Turn() {
			// don't need to check if any moves left as this is done before calling method
			// get chosen move (current, target)
			// validateMove
			// until validateMove is true, keep getting chosen move (current, target)
			// then -----> return true
			return true;
		}

		public uint Score {
			get {
				return score;
			}
			set {
				score = value;
			}
		}
		private Stack<Move> moves;
	}

}
