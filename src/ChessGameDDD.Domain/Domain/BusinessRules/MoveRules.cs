using ChessGameDDD.Domain.Entities;

namespace ChessGameDDD.Domain.BusinessRules
{
    internal static class MoveRule
    {
        internal static void IsAllowed(this Move move, Board board, Piece pieceToMove)
        {
            // If move is valid?
            // Can the piece make the move
            pieceToMove.CanMakeMove(move, board);
        }
    }
}