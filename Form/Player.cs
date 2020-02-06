using System;
using System.Collections.Generic;

namespace Crazy_Checkers {
	public class Player {
		private uint score = 0;
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
