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

        [Then(@"it can be moved in the following directions")]
        public void ThenItCanBeMovedInTheFollowingDirections(IEnumerable<MoveToCheck> moves)
        {
            foreach (var moveToCheck in moves)
            {
                moveToCheck.Move.StartLocation = _context.PieceLocationToMove;
                try
                {
                    _context.Game.MakeMove(moveToCheck.Move);
                    Assert.IsTrue(moveToCheck.ShouldBePossible);
                }
                catch (BusinessRuleViolationException)
                {
                    Assert.IsFalse(moveToCheck.ShouldBePossible);
                }
            }
        }
    }
}