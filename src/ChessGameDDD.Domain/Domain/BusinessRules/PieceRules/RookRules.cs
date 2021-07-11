using ChessGameDDD.Domain.Entities;
using ChessGameDDD.Domain.Entities.Pieces;

namespace ChessGameDDD.Domain.BusinessRules.PieceRules
{
    internal static class RookRules
    {
        internal static bool DirectionIsAllowed(this Rook piece, Move move)
        {
            return (move.FromLocation.Rank == move.ToLocation.Rank &&
                move.FromLocation.File != move.ToLocation.File) ||

                (move.FromLocation.Rank != move.ToLocation.Rank &&
                move.FromLocation.File == move.ToLocation.File);
        }
    }
}