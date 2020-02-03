using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crazy_Checkers
{
    public class Move
    {
        public Piece blackPiece { get; set; }
        public Piece redPiece { get; set; }

        public Move()
        {
            this.blackPiece = null;
            this.redPiece = null;
        }

        public Move(Piece blackPiece, Piece redPiece)
        {
            this.blackPiece = blackPiece;
            this.redPiece = redPiece;
        }

        public bool getNeighbour(string color)
        {
            if (color == "Black")
            {
                if ((blackPiece.Row - 1 == redPiece.Row) && (blackPiece.Column - 1 == redPiece.Column))
                    return true;

                else if ((blackPiece.Row - 1 == redPiece.Row) && (blackPiece.Column + 1 == redPiece.Column))
                    return true;
            }

            else if (color == "Red")
            {
                if ((blackPiece.Row + 1 == redPiece.Row) && (blackPiece.Column - 1 == redPiece.Column))
                    return true;

                else if ((blackPiece.Row + 1 == redPiece.Row) && (blackPiece.Column + 1 == redPiece.Column))
                    return true;
            }

            else if (color == "King")
            {
                if ((blackPiece.Row - 1 == redPiece.Row) && (blackPiece.Column - 1 == redPiece.Column))
                    return true;

                else if ((blackPiece.Row - 1 == redPiece.Row) && (blackPiece.Column + 1 == redPiece.Column))
                    return true;

                else if ((blackPiece.Row + 1 == redPiece.Row) && (blackPiece.Column - 1 == redPiece.Column))
                    return true;

                else if ((blackPiece.Row + 1 == redPiece.Row) && (blackPiece.Column + 1 == redPiece.Column))
                    return true;
            }

            return false;
        }

        public Piece checkMove(string color)
        {
            if (color == "Black")
            {
                if ((blackPiece.Row - 2 == redPiece.Row) && (blackPiece.Column - 2 == redPiece.Column))
                    return new Piece(blackPiece.Row - 1, blackPiece.Column - 1);

                if ((blackPiece.Row - 2 == redPiece.Row) && (blackPiece.Column + 2 == redPiece.Column))
                    return new Piece(blackPiece.Row - 1, blackPiece.Column + 1);
            }
            if (color == "Red")
            {
                if ((blackPiece.Row + 2 == redPiece.Row) && (blackPiece.Column - 2 == redPiece.Column))
                    return new Piece(blackPiece.Row + 1, blackPiece.Column - 1);

                if ((blackPiece.Row + 2 == redPiece.Row) && (blackPiece.Column + 2 == redPiece.Column))
                    return new Piece(blackPiece.Row + 1, blackPiece.Column + 1);
            }
            if (color == "King")
            {
                if ((blackPiece.Row - 2 == redPiece.Row) && (blackPiece.Column - 2 == redPiece.Column))
                    return new Piece(blackPiece.Row - 1, blackPiece.Column - 1);

                if ((blackPiece.Row - 2 == redPiece.Row) && (blackPiece.Column + 2 == redPiece.Column))
                    return new Piece(blackPiece.Row - 1, blackPiece.Column + 1);

                if ((blackPiece.Row + 2 == redPiece.Row) && (blackPiece.Column - 2 == redPiece.Column))
                    return new Piece(blackPiece.Row + 1, blackPiece.Column - 1);
                    
                if ((blackPiece.Row + 2 == redPiece.Row) && (blackPiece.Column + 2 == redPiece.Column))
                    return new Piece(blackPiece.Row + 1, blackPiece.Column + 1);
            }

            return null;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Move move = obj as Move;
            if ((System.Object)move == null)
            {
                return false;
            }

            return blackPiece.Equals(move.blackPiece) && redPiece.Equals(move.redPiece);
        }
    }
}
