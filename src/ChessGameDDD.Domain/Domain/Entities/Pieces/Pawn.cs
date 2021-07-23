using ChessGameDDD.Domain.Entities;
using System.Collections.Generic;

namespace ChessGameDDD.Domain.Domain.Entities.Pieces
{
    public class Pawn : Piece
    {
        protected override IEnumerable<object> GetAtomicValues()
        {
            return null;
        }
    }
}