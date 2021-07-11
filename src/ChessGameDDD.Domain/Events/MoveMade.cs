using ChessGameDDD.Domain.Entities;

namespace ChessGameDDD.Events
{
    internal class MoveMadeEvent : Event
    {
        public Move Move { get; set; }
    }
}