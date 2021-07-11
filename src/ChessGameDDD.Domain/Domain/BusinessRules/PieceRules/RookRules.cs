using ChessGameDDD.Domain.Entities;
using ChessGameDDD.Domain.Entities.Pieces;

namespace ChessGameDDD.Domain.BusinessRules.PieceRules
{
    internal static class RookRules
    {
        internal static bool DirectionIsAllowed(this Rook piece, Move move)
        {
            return true;
        }
    }
}