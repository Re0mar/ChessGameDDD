using ChessGameDDD.Domain.Core;
using ChessGameDDD.Domain.Entities;
using System;

namespace ChessGameDDD.Domain.Domain.Entities
{
    public class BoardCell : Entity<Guid>
    {
        public BoardCell(BoardLocation boardLocation, Piece containingPiece)
            : base(Guid.NewGuid())
        {
            BoardLocation = boardLocation;
            ContainingPiece = containingPiece;
        }

        public BoardLocation BoardLocation { get; set; }
        public Piece ContainingPiece { get; set; }
    }
}