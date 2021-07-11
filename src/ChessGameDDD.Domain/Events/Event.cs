using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Entities;

namespace ChessGameDDD.Events
{
    public class Event
    {
        public BoardLocation PiecToLocation { get; set; }
        public Piece Piece { get; set; }
    }
}