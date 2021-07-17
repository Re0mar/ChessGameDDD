using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Entities;
using ChessGameDDD.Events;
using System.Collections.Generic;

namespace ChessGameDDD.Domain.tests.Contexts
{
    public class MovePieceContext
    {
        public Game Game { get; internal set; }
        public BoardLocation PieceLocationToMove { get; internal set; }
        public List<Event> Events { get; internal set; }
    }
}