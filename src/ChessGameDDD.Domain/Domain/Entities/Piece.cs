using ChessGameDDD.Domain.Core;

namespace ChessGameDDD.Domain.Entities
{
    public abstract class Piece : ValueObject
    {
        internal virtual void CanMakeMove(Move move, Board board)
        {
            // Move checks king
        }
    }
}