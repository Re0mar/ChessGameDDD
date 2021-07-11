using ChessGameDDD.Domain.BusinessRules;
using ChessGameDDD.Domain.Core;
using ChessGameDDD.Events;
using System;
using System.Collections.Generic;

namespace ChessGameDDD.Domain.Entities
{
    public class Game : AggregateRoot<Guid>
    {
        private Board Board;

        private Game() :
            base(Guid.NewGuid())
        {
        }

        public static Game Create(List<Event> oldEvents)
        {
            var game = new Game()
            {
                Board = Board.Create()
            };

            foreach (var @event in oldEvents)
            {
                game.When(@event);
            }

            return game;
        }

        public void MakeMove(Move move)
        {
            var pieceToMove = Board.GetPieceToMove(move/*.startPosition*/);

            // Check business rules
            move.IsAllowed(Board, pieceToMove);

            // Create event
            var eventResult = move.MapToMoveMade();

            // Raise event
            RaiseEvent(eventResult);
        }

        protected override void When(dynamic @event)
        {
            switch (@event)
            {
                case MoveMadeEvent:
                    When(@event as MoveMadeEvent);
                    break;

                default:
                    break;
            }
        }

        private void When(MoveMadeEvent @event)
        {
            Board.UpdateBoardPosition(@event/*.move*/);
        }
    }
}