using System;
using System.Collections.Generic;

namespace Crazy_Checkers {
	public class Player {
		public bool human { get; set; }
		public uint Score { get; set; }
		public uint playerNum { get; set; }
		public uint opposition { get; }
		public bool playable { get; set; }
		public TactGrid tactGrid { get; }
		
		public Player(uint cols, uint rows, uint playerNum, bool human)
		{
			tactGrid = new TactGrid(cols, rows);
			Score = 0;
			playable = true;
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

        public bool GeneratePlayable(ref Grid grid)
        {
            playable = tactGrid.CheckPlayable(ref grid, playerNum, opposition);
            return playable;
        }

		public void GenerateTactGrid(ref Grid grid, ref Move move)
		{
			tactGrid.Gen(ref grid, ref move, playerNum, opposition);
		}

		public bool GetValidMove(uint col, uint row)
		{
			return tactGrid.GetSquare(col, row);
		}

		public Counter GetTaken(uint col, uint row)
		{
			return tactGrid.GetTaken(col, row);
		}
	}
}
