using ChessGameDDD.Domain.Core;
using ChessGameDDD.Domain.Entities.Pieces;
using ChessGameDDD.Events;
using System;

namespace ChessGameDDD.Domain.Entities
{
    public class Board : Entity<Guid>
    {
        private Board()
            : base(Guid.NewGuid())
        {
        }

        public static Board Create()
        {
            return new Board();
        }

        internal Piece GetPieceToMove(Move move)
        {
            return new Rook();
        }

        internal void UpdateBoardPosition(MoveMadeEvent @event)
        {
            // set piece to location
            throw new NotImplementedException();
        }
    }
}