using ChessGameDDD.Domain.BusinessRules.PieceRules;

namespace ChessGameDDD.Domain.Entities.Pieces
{
    public class Rook : Piece
    {
        internal override void CanMakeMove(Move move, Board board)
        {
            base.CanMakeMove(move, board);
            this.DirectionIsAllowed(move);
            this.MoveIsAllowedOnBoard(move, board);
        }
    }
}