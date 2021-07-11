namespace ChessGameDDD.Domain.Entities
{
    public abstract class Piece /*: ValueObject*/
    {
        //protected override IEnumerable<object> GetAtomicValues()
        //{
        //    throw new NotImplementedException();
        //}

        internal virtual bool CanMakeMove(Move move, Board board)
        {
            return true;
        }
    }
}