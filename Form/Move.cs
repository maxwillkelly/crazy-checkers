using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crazy_Checkers
{
    public class Move
    {
        private Position current { get; set; }
        private Position target { get; set; }
        private Position taken { get; set; }

        public Position blackPosition { get; set; }
        public Position redPosition { get; set; }

        public Move()
        {
            this.blackPosition = null;
            this.redPosition = null;
        }

        public Move(Position blackPosition, Position redPosition)
        {
            this.blackPosition = blackPosition;
            this.redPosition = redPosition;
        }

        public int ProcessMove(ref Position current, ref Position target)
        {
            throw new System.Exception("Not implemented");
        }

        public bool getNeighbour(string color)
        {
            if (color == "Black")
            {
                if ((blackPosition.Row - 1 == redPosition.Row) && (blackPosition.Column - 1 == redPosition.Column))
                    return true;

                else if ((blackPosition.Row - 1 == redPosition.Row) && (blackPosition.Column + 1 == redPosition.Column))
                    return true;
            }

            else if (color == "Red")
            {
                if ((blackPosition.Row + 1 == redPosition.Row) && (blackPosition.Column - 1 == redPosition.Column))
                    return true;

                else if ((blackPosition.Row + 1 == redPosition.Row) && (blackPosition.Column + 1 == redPosition.Column))
                    return true;
            }

            else if (color == "King")
            {
                if ((blackPosition.Row - 1 == redPosition.Row) && (blackPosition.Column - 1 == redPosition.Column))
                    return true;

                else if ((blackPosition.Row - 1 == redPosition.Row) && (blackPosition.Column + 1 == redPosition.Column))
                    return true;

                else if ((blackPosition.Row + 1 == redPosition.Row) && (blackPosition.Column - 1 == redPosition.Column))
                    return true;

                else if ((blackPosition.Row + 1 == redPosition.Row) && (blackPosition.Column + 1 == redPosition.Column))
                    return true;
            }

            return false;
        }

        public Position checkMove(string color)
        {
            if (color == "Black")
            {
                if ((blackPosition.Row - 2 == redPosition.Row) && (blackPosition.Column - 2 == redPosition.Column))
                    return new Position(blackPosition.Row - 1, blackPosition.Column - 1);

                if ((blackPosition.Row - 2 == redPosition.Row) && (blackPosition.Column + 2 == redPosition.Column))
                    return new Position(blackPosition.Row - 1, blackPosition.Column + 1);
            }
            if (color == "Red")
            {
                if ((blackPosition.Row + 2 == redPosition.Row) && (blackPosition.Column - 2 == redPosition.Column))
                    return new Position(blackPosition.Row + 1, blackPosition.Column - 1);

                if ((blackPosition.Row + 2 == redPosition.Row) && (blackPosition.Column + 2 == redPosition.Column))
                    return new Position(blackPosition.Row + 1, blackPosition.Column + 1);
            }
            if (color == "King")
            {
                if ((blackPosition.Row - 2 == redPosition.Row) && (blackPosition.Column - 2 == redPosition.Column))
                    return new Position(blackPosition.Row - 1, blackPosition.Column - 1);

                if ((blackPosition.Row - 2 == redPosition.Row) && (blackPosition.Column + 2 == redPosition.Column))
                    return new Position(blackPosition.Row - 1, blackPosition.Column + 1);

                if ((blackPosition.Row + 2 == redPosition.Row) && (blackPosition.Column - 2 == redPosition.Column))
                    return new Position(blackPosition.Row + 1, blackPosition.Column - 1);
                    
                if ((blackPosition.Row + 2 == redPosition.Row) && (blackPosition.Column + 2 == redPosition.Column))
                    return new Position(blackPosition.Row + 1, blackPosition.Column + 1);
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

            return blackPosition.Equals(move.blackPosition) && redPosition.Equals(move.redPosition);
        }
    }
}
