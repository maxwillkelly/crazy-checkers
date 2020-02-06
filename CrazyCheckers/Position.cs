using System;
namespace Crazy_Checkers {
	public class Position {
		private uint column;
		public uint Column {
			get {
				return column;
			}
			set {
				column = value;
			}
		}
		private uint row;
		public uint Row {
			get {
				return row;
			}
			set {
				row = value;
			}
		}
		private bool isKing = false;
		public bool IsKing {
			get {
				return isKing;
			}
			set {
				isKing = value;
			}
		}

		public Position(ref uint col, ref uint row) {
			throw new System.Exception("Not implemented");
		}
		public Position() {
			throw new System.Exception("Not implemented");
		}
		private void MakeButton() {
			throw new System.Exception("Not implemented");
		}
		public bool Equals() {
			throw new System.Exception("Not implemented");
		}

		private Grid grid;

	}

}
