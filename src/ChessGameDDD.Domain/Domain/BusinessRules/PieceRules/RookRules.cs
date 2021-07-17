using ChessGameDDD.Domain.Entities;
using ChessGameDDD.Domain.Entities.Pieces;
using System.Collections.Generic;

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

        internal static bool MoveIsAllowedOnBoard(this Rook piece, Move move, Board board)
        {
            // check if move jumps over other piece
            List<Piece> piecesBetweenMove = board.GetPiecesBetweenMoveLocations(move);

            return false;
        }
    }
}