using ChessGameDDD.Domain.Core;
using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Entities.Pieces;
using ChessGameDDD.Events;
using System;
using System.Collections.Generic;

namespace ChessGameDDD.Domain.Entities
{
    public class Board : Entity<Guid>
    {
        private BoardLocation[,] boardSetup;

        private Board()
            : base(Guid.NewGuid())
        {
            boardSetup = new BoardLocation[8, 8];
        }

        internal static Board Create()
        {
            return new Board();
        }

        internal Piece GetPieceToMove(BoardLocation boardLocation)
        {
            return new Rook();
        }

        internal void UpdateBoardPosition(MoveMadeEvent @event)
        {
            // set piece to location
            // not needed yet
        }

        internal IEnumerable<Piece> GetPiecesBetweenMoveLocations(Move move)
        {
            var fromBoardLocation = ParseLocation(move.FromLocation);
            var toBoardLocation = ParseLocation(move.ToLocation);

            return null;
        }

        private BoardLocation ParseLocation(BoardLocation fromLocation)
        {
            return boardSetup[fromLocation.File - 97, fromLocation.Rank - 49];
        }
    }
}