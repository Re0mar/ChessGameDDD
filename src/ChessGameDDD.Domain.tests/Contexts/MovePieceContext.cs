using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Entities;

namespace ChessGameDDD.Domain.tests.Contexts
{
    public class MovePieceContext
    {
        public Game Game { get; internal set; }
        public BoardLocation PieceLocationToMove { get; internal set; }
    }
}