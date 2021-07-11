namespace ChessGameDDD.Domain.Entities
{
    internal abstract class Piece /*: ValueObject*/
    {
        //protected override IEnumerable<object> GetAtomicValues()
        //{
        //    throw new NotImplementedException();
        //}

        internal virtual bool CanMakeMove(Move move, Board board)
        {
            // check if king is checked by move
            return true;
        }
    }
}