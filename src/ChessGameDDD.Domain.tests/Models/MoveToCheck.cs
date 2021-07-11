using ChessGameDDD.Domain.Entities;

namespace ChessGameDDD.Domain.tests.Models
{
    public class MoveToCheck
    {
        public bool ShouldBePossible { get; internal set; }
        public Move Move { get; internal set; }
    }
}