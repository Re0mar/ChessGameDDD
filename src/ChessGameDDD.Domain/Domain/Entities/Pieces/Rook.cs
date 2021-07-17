using ChessGameDDD.Domain.BusinessRules.PieceRules;

namespace ChessGameDDD.Domain.Entities.Pieces
{
    public class Rook : Piece
    {
        internal override bool CanMakeMove(Move move, Board board)
        {
            return base.CanMakeMove(move, board) &&
                this.DirectionIsAllowed(move) &&
                this.MoveIsAllowedOnBoard(move, board);
        }
    }
}