using ChessGameDDD.Domain.Domain.Entities;

namespace ChessGameDDD.Domain.tests.Models
{
    public class MoveToCheck
    {
        public bool ShouldBePossible { get; internal set; }
        public BoardLocation ToLocation { get; internal set; }
    }
}