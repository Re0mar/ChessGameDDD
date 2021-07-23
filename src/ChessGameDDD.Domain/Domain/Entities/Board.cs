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
        private BoardCell[,] boardSetup;

        private Board()
            : base(Guid.NewGuid())
        {
            boardSetup = new BoardCell[8, 8];
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
            var fromFileBoardLocation = ParseFile(move.FromLocation.File);
            var fromRankBoardLocation = ParseRank(move.FromLocation.Rank);

            var toFileBoardLocation = ParseFile(move.ToLocation.File);
            var toRankBoardLocation = ParseRank(move.ToLocation.Rank);

            //// GetPieces between from and to location
            //return GetPiecesBetweenLocation(fromBoardLocation, toBoardLocation);

            return null;
        }

        private int ParseFile(char file)
        {
            return file - 97;
        }

        private int ParseRank(char rank)
        {
            return rank - 49;
        }
    }
}