using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Entities;
using ChessGameDDD.Domain.tests.Contexts;
using TechTalk.SpecFlow;

namespace ChessGameDDD.Domain.tests.StepDefinitions
{
    [Binding]
    public class When
    {
        private MovePieceContext MovePieceContext;

        public When(MovePieceContext movePieceContext)
        {
            this.MovePieceContext = movePieceContext;
        }

        [When(@"I want to move the piece on '(.*)'")]
        public void WhenIWantToMoveThePieceOn(BoardLocation boardLocation)
        {
            MovePieceContext.Game = Game.Create(MovePieceContext.Events);
            MovePieceContext.PieceLocationToMove = boardLocation;
        }
    }
}