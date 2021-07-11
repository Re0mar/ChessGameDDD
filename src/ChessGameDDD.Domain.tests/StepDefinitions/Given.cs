using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Entities;
using ChessGameDDD.Domain.tests.Contexts;
using TechTalk.SpecFlow;

namespace ChessGameDDD.Domain.tests.StepDefinitions
{
    [Binding]
    public class Given
    {
        private MovePieceContext movePieceContext;

        public Given(MovePieceContext movePieceContext)
        {
            this.movePieceContext = movePieceContext;
        }

        [Given(@"there is a board with a rook on '(.*)'")]
        public void GivenThereIsABoardWithARookOn(BoardLocation boardLocation)
        {
            movePieceContext.Board = Board.Create();
        }
    }
}