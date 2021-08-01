using ChessGameDDD.Domain.Entities;
using ChessGameDDD.Domain.tests.Contexts;
using ChessGameDDD.Domain.tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace ChessGameDDD.Domain.tests.StepDefinitions
{
    [Binding]
    public class Then
    {
        private MovePieceContext _context;

        public Then(MovePieceContext movePieceContext)
        {
            _context = movePieceContext;
        }

        [Then(@"it can be moved to the following locations")]
        public void ThenItCanBeMovedInTheFollowingDirections(IEnumerable<MoveToCheck> moves)
        {
            foreach (var moveToCheck in moves)
            {
                try
                {
                    _context.Game.MakeMove(Move.Create(_context.PieceLocationToMove, moveToCheck.ToLocation));
                    Assert.IsTrue(moveToCheck.ShouldBePossible, $"Move from {_context.PieceLocationToMove} to {moveToCheck.ToLocation}");
                }
                catch (BusinessRuleViolationException ex)
                {
                    Assert.IsFalse(moveToCheck.ShouldBePossible, ex.Message);
                }
            }
        }
    }
}