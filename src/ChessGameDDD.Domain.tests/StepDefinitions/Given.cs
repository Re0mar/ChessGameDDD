using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Entities;
using ChessGameDDD.Domain.Entities.Pieces;
using ChessGameDDD.Domain.tests.Contexts;
using ChessGameDDD.Events;
using System.Collections.Generic;
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
            var events = new List<Event>();
            events.Add(new MoveMadeEvent
            {
                Move = new Move
                {
                    ToLocation = boardLocation
                },
                Piece = new Rook()
            });

            movePieceContext.Game = Game.Create(events);
        }
    }
}