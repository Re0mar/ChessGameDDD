using ChessGameDDD.Domain.Entities;

namespace ChessGameDDD.Domain.BusinessRules
{
    internal static class MoveRule
    {
        internal static void IsPossible(this Move move, Board board, Piece pieceToMove)
        {
            // If move is valid?
            // Can the piece make the move
            if (pieceToMove.CanMakeMove(move, board))
            {
                throw new BusinessRuleViolationException("Move is not possible");
            }
        }
    }
}