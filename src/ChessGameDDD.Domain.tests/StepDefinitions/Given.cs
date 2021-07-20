using ChessGameDDD.Domain.Domain.Entities;
using ChessGameDDD.Domain.Domain.Entities.Pieces;
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
        public void GivenThereIsABoardWithARookOn(BoardLocation toLocation)
        {
            var events = new List<Event>();
            events.Add(new MoveMadeEvent
            {
                Move = Move.Create(BoardLocation.Create("a1"), toLocation),
                Piece = new Rook()
            });

            movePieceContext.Events = events;
        }

        [Given(@"there is a pawn on '(.*)'")]
        public void GivenThereIsAPawnOn(BoardLocation toLocation)
        {
            movePieceContext.Events.Add(new MoveMadeEvent
            {
                Move = Move.Create(BoardLocation.Create("a1"), toLocation),
                Piece = new Pawn()
            });
        }
    }
}