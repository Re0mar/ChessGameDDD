using ChessGameDDD.Domain.Entities;

namespace ChessGameDDD.Events
{
    public class MoveMadeEvent : Event
    {
        public Move Move { get; set; }
        public Piece Piece { get; set; }
    }
}