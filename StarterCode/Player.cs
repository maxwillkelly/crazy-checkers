using System;
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
		private Stack moves;

		private Game game;

		private Move move;

	}

}
