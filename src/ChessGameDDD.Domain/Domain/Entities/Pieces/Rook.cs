using ChessGameDDD.Domain.BusinessRules.PieceRules;

namespace ChessGameDDD.Domain.Entities.Pieces
{
    internal class Rook : Piece
    {
        internal override bool CanMakeMove(Move move, Board board)
        {
            return base.CanMakeMove(move, board) &&
                this.DirectionIsAllowed(move);
        }
    }
}