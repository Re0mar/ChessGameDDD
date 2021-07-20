using ChessGameDDD.Domain.Entities;
using ChessGameDDD.Domain.Entities.Pieces;

namespace ChessGameDDD.Domain.BusinessRules.PieceRules
{
    public static class RookRules
    {
        public static void DirectionIsAllowed(this Rook piece, Move move)
        {
            if (move.FromLocation.Rank != move.ToLocation.Rank &&
                move.FromLocation.File != move.ToLocation.File)
            {
                throw new BusinessRuleViolationException("Move direction not allowed for rook");
            }
        }

        internal static bool MoveIsAllowedOnBoard(this Rook piece, Move move, Board board)
        {
            // check if move jumps over other piece
            //List<Piece> piecesBetweenMove = board.GetPiecesBetweenMoveLocations(move);

            return false;
        }
    }
}